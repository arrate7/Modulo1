using System;
using System.Data.SqlClient;

namespace HotelArrate
{
    class Program
    {
        static SqlConnection connection = new SqlConnection("Data source=DESKTOP-QEAKD04\\SQLEXPRESS;Initial Catalog=Hotel_Transilvania;Integrated Security=True");
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            int opcion;
            //BUCLE QUE ME MUESTRA EL MENÚ MIENTRAS LA OPCIÓN NO SEA NINGUNA DE LAS 5 
            do
            {

                Console.WriteLine("********************HOTEL************************");
                Console.WriteLine("1.Registrar Cliente");
                Console.WriteLine("2.Editar Cliente");
                Console.WriteLine("3.Check-In");
                Console.WriteLine("4.Check-out");
                Console.WriteLine("5.Salir");
                Console.WriteLine("********************************************");
                Console.WriteLine();
                Console.Write("Introduce una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion < 1 || opcion > 5);

            switch (opcion)
            {
                case 1:
                    RegistrarCliente();
                    break;
                case 2:
                    //Se lo tengo que pedir antes para pasárselo por parámetro al método
                    Console.WriteLine("Introduce tu DNI:");
                    string dni = Console.ReadLine();
                    EditarCliente(dni);
                    break;
                case 3:
                    CheckIn();
                    break;
                default:
                    Console.WriteLine("Agur!!!");
                    break;
            }

        }

        public static void RegistrarCliente()
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Introduce tu dni");
            string dni = Console.ReadLine().ToUpper();

            //Le paso el dni al método y miro si existe o no
            if (DNIExiste(dni))
            {
                Console.WriteLine("El DNI introducido ya está registrado");
                //Le redirijo al menú
                Menu();
            }
            else
            {
                //Si el DNI no existe en la BBDD registro al cliente
                connection.Open();
                string query = "INSERT INTO Clientes VALUES('" + nombre + "','" + apellido + "','" + dni + "') ";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Usuario registrado");
                //Le redirijo al menú
                Menu();

            }
        }

  
        public static bool DNIExiste(string dni)
        {
            connection.Open();
            string query = "SELECT * FROM CLIENTES WHERE DNI LIKE '" + dni + "'";
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader registros = command.ExecuteReader();

            //Si lo ha leído es que el DNI existe por lo tanto devuelvo true 
            if (registros.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                //Si no existe devuelvo falso
                return false;
            }

        }

        public static void EditarCliente(string dni)
        {
            //primero miro si el dni existe en la BBDD
            //Si existe
            if (DNIExiste(dni))
            {
                //Le vuelvo a pedir el nombre y el apellido
                Console.WriteLine("Introduce el nombre nuevo");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduce el apellido nuevo");
                string apellido = Console.ReadLine();

                //y lo modifico
                connection.Open();
                string query = " UPDATE CLIENTES SET NOMBRE = '" + nombre + "', APELLIDO = '" + apellido + "' WHERE DNI LIKE'" + dni + "'";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Datos modificados con éxito.");
                //Le redirijo al menú
                Menu();
            }
            else
            {
                //Si el DNI no existe
                Console.WriteLine("El DNI no existe, debe estar registrado para modificar sus datos.");
                //Le redirijo al menú
                Menu();
            }
        }
        public static void CheckIn()
        {
            Console.WriteLine("Introduce tu DNI:");
            string dni = Console.ReadLine();

            //Vuelvo a comprobar que el dni está en la BBDD

            if (DNIExiste(dni))
            {
                PrintHabitaciones();
            }
            else
            {
                Console.WriteLine("Debes estar registrado para reservar.");
                //Le redirijo al menú
                Menu();
            }
        }

        public static void PrintHabitaciones()
        {
            Console.WriteLine("Habitaciones disponibles");
            string query = "SELECT * FROM HABITACIONES WHERE ESTADO LIKE 'Libre'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader registros = command.ExecuteReader();
            while (registros.Read())
            {
                Console.WriteLine(registros[0].ToString());
            }
        }
    }
}
