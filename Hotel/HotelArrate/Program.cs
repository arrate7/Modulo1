using System;
using System.Data.SqlClient;

namespace HotelArrate
{
    class Program
    {
        static SqlConnection connection = new SqlConnection("Data source=DESKTOP-QEAKD04\\SQLEXPRESS;Initial Catalog=Hotel_Transilvania;Integrated Security=True");
        static void Main(string[] args)
        {

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
                //Le redirijo al menú
                Menu();

            }
        }

        
        public static bool DNIExiste(string dni)
        {
            string query = "SELECT * FROM CLIENTES WHERE DNI LIKE '" + dni + "'";
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader registros = command.ExecuteReader();

            //Si lo ha leído es que el DNI existe por lo tanto devuelvo true 
            if (registros.Read())
            {
                return true;
            }
            else
            {
                //Si no existe devuelvo falso
                return false;
            }

        }
    }
}
