﻿using System;
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
                case 4:
                    CheckOut();
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
            SqlCommand command = new SqlCommand(query, connection);
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
                int idHabitacion = Convert.ToInt32(Console.ReadLine());

                //Si la habitación está disponible y existe
                if (HabitacionDisponible(idHabitacion))
                {
                    //Paso a Ocuparla
                    OcuparHabitacion(idHabitacion);
                    //Y hago la reserva
                    Reservar(dni, idHabitacion);
                }
                else
                {
                    Console.WriteLine("La habitación seleccionada no está disponible");
                    Menu();
                }

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
            connection.Open();
            SqlDataReader registros = command.ExecuteReader();
            while (registros.Read())
            {
                Console.WriteLine(registros[0].ToString() + "     " + registros[1].ToString());
            }
            connection.Close();
            Console.WriteLine("******************************************************");
            Console.WriteLine("Selecciona una habitación:  ");
            Console.WriteLine();

        }
        public static bool HabitacionDisponible(int idHabitacion)
        {
            string query = "SELECT * FROM HABITACIONES WHERE ESTADO LIKE 'Libre' And ID = " + idHabitacion;
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader registros = command.ExecuteReader();
            if (registros.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        public static void OcuparHabitacion(int idHabitacion)
        {
            connection.Open();
            string query = "UPDATE Habitaciones SET Estado = 'Ocupado'WHERE ID = " + idHabitacion;
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }
        public static void Reservar(string dni, int idHabitacion)
        {
            //No puedo hacer una reserva con el dni del cliente, necesito su id por lo tanto tengo que hacer una busqueda en la BBDD
            int idCliente = BuscarIdCliente(dni);
            //Una vez tenga los datos que necesito hago el insert
            connection.Open();
            string query = "INSERT INTO Reservas(IDCliente, IDHabitacion, FechaChecking)VALUES(" + idCliente + "," + idHabitacion + ", GETDATE())";
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Reserva realizada");
            Menu();

        }
        public static int BuscarIdCliente(string dni)
        {
            connection.Open();
            string query = " SELECT ID FROM Clientes WHERE Dni LIKE '" + dni + "'";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();
            registros.Read();
            int idCliente = Convert.ToInt32(registros[0].ToString());
            connection.Close();
            return idCliente;
        }
        public static void CheckOut()
        {
            Console.WriteLine("Introduce el dni:");
            string dni = Console.ReadLine();
            //Miro si el dni existe
            if (DNIExiste(dni))
            {

                //Llamo al método para buscar el id del cliente
                int idCliente = BuscarIdCliente(dni);
                //Llamo al método para buscar la reserva vinculada a ese cliente
                int idReserva = BuscarReserva(idCliente);
                //Modifico la reserva para añadirle la fecha de checkout

                //Con el id de la reserva busco el id de la habitación reservada
                int idHabitacion = BuscarHabitacion(idReserva);
                //Con el id de la habitación la libero
                LiberarHabitacion(idHabitacion);

            }
            else
            {
                Console.WriteLine("El DNI introducido no es correcto.");
                Menu();
            }





        }
        public static int BuscarReserva(int idCliente)
        {
            //Busco el id de la ultima reserva del cliente la cual todavia no tiene fecha de salida
            connection.Open();
            string query = "SELECT ID from Reservas where IDCliente = " + idCliente + " and FechaCheckOut IS NULL";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader registros = command.ExecuteReader();
            registros.Read();
            int idReserva = Convert.ToInt32(registros[0].ToString());
            connection.Close();
            return idReserva;

        }
        public static int BuscarHabitacion(int idReserva)
        {
            //Busco el id de la habitacion mediante la reserva para pasarla luego a libre
            connection.Open();
            string query = "SELECT IDHabitacion from Reservas where ID = " + idReserva;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader registros = command.ExecuteReader();
            registros.Read();
            int idHabitacion = Convert.ToInt32(registros[0].ToString());
            connection.Close();
            return idHabitacion;
        }
        public static void LiberarHabitacion(int idHabitacion)
        {
            connection.Open();
            string query = "UPDATE Habitaciones SET Estado = 'Libre'WHERE ID = " + idHabitacion;
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }
        public static void FechaCheckOut(int idReserva)
        {
            connection.Open();
            string query = "UPDATE Reservas SET FechaCheckOut = GETDATE() WHERE ID = " + idReserva;
            SqlCommand comando = new SqlCommand(query, connection);
            comando.ExecuteNonQuery();
            connection.Close();
        }

    }
}
