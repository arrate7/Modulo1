using System;
using System.Data.SqlClient;

namespace Hotel
{
    class Program
    {
        static SqlConnection connection = new SqlConnection("Data source=DESKTOP-QEAKD04\\SQLEXPRESS;Initial Catalog=Hotel_Transilvania;Integrated Security=True");
        static void Main(string[] args)
        {

            bool seguirConectado = true;
            int menu;
            Console.WriteLine("¡Bienvenido al Hotel Transilvania!");
            do
            {
                PrintMenu();
                seguirConectado = Menu(Convert.ToInt32(Console.ReadLine()));//añadir try parse de esta entrada
            } while (seguirConectado);
        }
        private static void PrintMenu()
        {
            Console.WriteLine("Indique la operación que desea realizar: " +
                "\n" + "1. Registrar un cliente" +
                "\n" + "2. Editar los datos de algún cliente" +
                "\n" + "3. Check -in" +
                "\n" + "4. Check -out" +
                "\n" + "5. Lista de habitaciones" +
                "\n" + "6. Lista de habitaciones ocupadas" +
                "\n" + "7. Lista de habitaciones vacias" +
                "\n" + "8. Salir");
        }
        private static bool Menu(int caso)
        {
            string dni = "";
            bool seguirConectado = true;
            switch (caso)
            {
                case 1:
                    RegistrarCliente();
                    break;
                case 2:
                    //Implementado por Elena
                    Console.WriteLine("Introduce DNI:");
                    EditarCliente(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Introduce tu dni");
                    dni = Console.ReadLine();
                    EstaRegistrado(dni);
                    break;
                case 4:
                    Console.WriteLine("Introduce tu dni");
                    dni = Console.ReadLine();
                    CheckOut(dni);
                    break;
                case 5:
                    PrintAllRooms();
                    break;
                case 6:
                    PrintOccupiedRooms();
                    break;
                case 7:
                    PrintEmptyRooms();
                    break;
                case 8:
                    seguirConectado = false;
                    break;
                default:
                    Console.WriteLine("Introduce un numero del 1 al 5!");
                    break;
            }
            return seguirConectado;
        }
        public static bool ComprobacionRegistro(string dni)
        {
            connection.Open();
            string query = "SELECT DNI FROM CLIENTES WHERE DNI LIKE '" + dni + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();

            bool TrueFalse = registros.Read();
            connection.Close();
            return TrueFalse;
        }
        public static void EditarCliente(String dni)
        {
            if (!ComprobacionRegistro(dni))
            {
                Console.WriteLine("El dni introducido no se encuentra dentro de la base de datos, primero debe registrar los datos");
                RegistrarCliente();
            }
            //variables que va a introducir el usuario
            string nombre = "";
            string apellido = "";
            //menú que va a aparecer en pantalla
            Console.WriteLine("Indique que dato desea modificar: " +
                "\n" + "1. Nombre" +
                "\n" + "2.Apellido" +
                "\n" + "3.Ambos");
            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                Console.Write("Introduzca los datos del cliente" +
                "\n" + "Nombre: ");
                nombre = Console.ReadLine().ToUpper();
                connection.Open();
                string query = " UPDATE CLIENTES SET NOMBRE = '" + nombre + "'WHERE DNI LIKE'" + dni + "'";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }
            else if (answer == 2)
            {
                Console.Write("Introduzca los datos del cliente" +
                         "\n" + "Apellido: ");
                apellido = Console.ReadLine().ToUpper();
                connection.Open();
                string query = " UPDATE CLIENTES SET APELLIDO = '" + apellido + "'WHERE DNI LIKE'" + dni + "'";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }
            else if (answer == 3)
            {
                Console.Write("Introduzca los datos del cliente" +
                    "\n" + "Nombre: ");
                nombre = Console.ReadLine().ToUpper();
                Console.Write("Apellido: ");
                apellido = Console.ReadLine().ToUpper();
                connection.Open();
                string query = " UPDATE CLIENTES SET NOMBRE = '" + nombre + "', APELLIDO = '" + apellido + "' WHERE DNI LIKE'" + dni + "'";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.ExecuteNonQuery();
                connection.Close();
            }
            Console.WriteLine("La modificación se ha realizado satisfactoriamente," + "\n" +
                "si desea realizar otra operación, pulse 1 para acceder al menú principal" + "\n" +
                "pulse 2 para salir");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                PrintMenu();
            }
            else
            {
                Console.WriteLine("\n" + "¡Hasta Pronto!");
            }
        }
        private static void RegistrarCliente()
        {
            Console.WriteLine("Introduce tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Introduce tu dni");
            string dni = Console.ReadLine().ToLower();
            if (isValidDni(dni))
            {
                if (isValidName(nombre))
                {
                    if (isValidName(apellido))
                    {
                        connection.Open();
                        string query = "INSERT INTO Clientes (Nombre,Apellido,Dni)VALUES('" + nombre + "','" + apellido + "','" + dni + "') ";
                        SqlCommand comando = new SqlCommand(query, connection);
                        comando.ExecuteNonQuery();
                        connection.Close();
                    }
                    else
                    {
                        Console.WriteLine("El apellido tiene demasiados caracteres, introduce un apellido de menos de 20 caracteres");
                        RegistrarCliente();
                    }
                }
                else
                {
                    Console.WriteLine("El nombre tiene demasiados caracteres, introduce un nombre de menos de 20 caracteres");
                    RegistrarCliente();
                }
            }
            else
            {
                Console.WriteLine("Dni no valido");
                RegistrarCliente();
            }
        }
        private static void EstaRegistrado(string dni)
        {
            connection.Open();
            string query = " SELECT Dni FROM Clientes WHERE Dni LIKE '" + dni + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                connection.Close();
                ValidarHabitacion(dni);
            }
            else
            {
                Console.WriteLine("El usuario no existe, registrese para reservar");
                Menu(1);
            }
        }
        private static void ValidarHabitacion(string dni)
        {
            PrintHabitaciones();
            Console.WriteLine("Seleccione la habitacion que desea reservar");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            connection.Open();

            string query = " SELECT Estado FROM Habitaciones WHERE ID =" + seleccion;
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            if (registros.Read())
            {
                if (registros[0].ToString() == "Libre")
                {
                    connection.Close();
                    OcuparHabitacion(seleccion);
                    int idUsuario = ObtenerIDUsuario(dni);
                    Reservar(seleccion, idUsuario);
                }
            }
            else
            {
                Console.WriteLine("Introduce una habitacion correcta");
                connection.Close();
                ValidarHabitacion(dni);
            }
        }
        private static void OcuparHabitacion(int seleccion)
        {
            connection.Open();
            string query = "UPDATE Habitaciones SET Estado = 'Ocupado'WHERE ID = " + seleccion;
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }
        private static void Reservar(int seleccion, int idUsuario)
        {
            connection.Open();
            string query = "INSERT INTO Reservas(IDCliente, IDHabitacion, FechaChecking)VALUES(" + idUsuario + "," + seleccion + ", GETDATE())";
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }
        private static int ObtenerIDUsuario(string dni)
        {
            connection.Open();
            string query = " SELECT ID FROM Clientes WHERE Dni LIKE '" + dni + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            registros.Read();
            int result = Convert.ToInt32(registros[0].ToString());
            connection.Close();
            return result;
        }
        private static void PrintHabitaciones()
        {
            connection.Open();
            string query = " SELECT * FROM Habitaciones WHERE Estado LIKE 'Libre'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                Console.WriteLine(registros[0].ToString() + "\t" + registros[1].ToString());
            }
            connection.Close();
        }
        private static void CheckOut(String dni)
        {
            int idCliente = ObtenerIDUsuario(dni);
            int idHabitacion = ObtenerIDHabitacion(idCliente);
            LibrarHabitacion(idHabitacion);
            SetCheckOutDate(idCliente);
        }
        private static void LibrarHabitacion(int idHabitacion)
        {
            connection.Open();
            string query = "UPDATE Habitaciones SET Estado = 'Libre'WHERE ID = " + idHabitacion;
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }
        private static int ObtenerIDHabitacion(int idCliente)
        {
            connection.Open();
            string query = " SELECT IDHabitacion FROM Reservas WHERE IDCliente LIKE '" + idCliente + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            registros.Read();
            int result = Convert.ToInt32(registros[0].ToString());
            connection.Close();
            return result;
        }
        private static void SetCheckOutDate(int idCliente)
        {
            connection.Open();
            string query = "UPDATE Reservas SET FechaCheckOut = GETDATE() WHERE IDCliente = " + idCliente;
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }
        private static bool isValidDni(string dni)
        {
            int letters = 0;
            int numbers = 0;
            int length = dni.Length;
            if (length == 9)
            {
                for (int i = 0; i < length; i++)
                {
                    if (Char.IsDigit(Convert.ToChar(dni[i])))
                    {
                        numbers++;
                    }
                    else
                    {
                        letters++;
                    }
                }
                if (letters == 1 && numbers == 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private static bool isValidName(string name)
        {
            int nameLength = name.Length;
            if (nameLength > 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintAllRooms()
        {
            connection.Open();
            string query = "SELECT Habitaciones.ID, Habitaciones.Estado, Clientes.Nombre " +
                            "FROM Habitaciones " +
                            "FULL JOIN RESERVAS ON Habitaciones.ID = Reservas.IDHabitacion  " +
                            "FULL JOIN Clientes ON Clientes.ID = Reservas.IDCliente  " +
                            "WHERE FechaCheckOut IS NULL";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                Console.WriteLine(registros[0].ToString() + "\t" + registros[1].ToString() + "\t" + registros[2].ToString());
            }
            connection.Close();
        }
        private static void PrintOccupiedRooms()
        {
            connection.Open();
            string query = "SELECT Habitaciones.ID, Habitaciones.Estado, Clientes.Nombre " +
                             "FROM Habitaciones" +
                             " JOIN RESERVAS ON Habitaciones.ID = Reservas.IDHabitacion" +
                             " JOIN Clientes ON Clientes.ID = Reservas.IDCliente" +
                             " WHERE FechaCheckOut IS NULL";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                Console.WriteLine(registros[0].ToString() + "\t" + registros[1].ToString() + "\t" + registros[2].ToString());
            }
            connection.Close();
        }
        private static void PrintEmptyRooms()
        {
            connection.Open();
            string query = "SELECT* FROM Habitaciones WHERE Estado LIKE 'Libre'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                Console.WriteLine(registros[0].ToString() + "\t" + registros[1].ToString());
            }
            connection.Close();
        }
    }
}



