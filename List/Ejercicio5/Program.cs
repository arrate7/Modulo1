using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Ejercicio5
{
    class Program
    {
        static SqlConnection connection = new SqlConnection("Data source=DESKTOP-QEAKD04\\SQLEXPRESS;Initial Catalog=Hotel_Transilvania;Integrated Security=True");
        static void Main(string[] args)
        {
            //List<Habitacion> habitaciones = new List<Habitacion>();

            //connection.Open();
            //string query = "SELECT * FROM Habitaciones";
            //SqlCommand comando = new SqlCommand(query, connection);
            //SqlDataReader registros = comando.ExecuteReader();

            //while (registros.Read())
            //{
            //    //Habitacion h1 = new Habitacion(Convert.ToInt32(registros[0].ToString()), registros[1].ToString());
            //    //Habitacion h1 = new Habitacion();
            //    //h1.ID = Convert.ToInt32(registros[0].ToString());
            //    //h1.Estado = registros[1].ToString();
            //    //habitaciones.Add(h1);

            //    habitaciones.Add(new Habitacion(Convert.ToInt32(registros[0].ToString()), registros[1].ToString()));
            //}

            //foreach(Habitacion habitacion in habitaciones)
            //{
            //    Console.WriteLine(habitacion.ID + " " + habitacion.Estado);
            //}

            bool error = false;
            do
            {
                error = false;
                try
                {
                    Console.WriteLine("Introduce un número:");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce otro número:");
                    int n2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(n1 / n2);
                }
                //catch (DivideByZeroException ex)
                //{
                //    Console.WriteLine("Un número entre 0 es infinito");
                //    Console.WriteLine(ex);
                //    error = true;

                //}
                //catch (FormatException ex)
                //{
                //    Console.WriteLine("Error. Introduce un número");
                //    Console.WriteLine(ex);
                //    error = true;

                //}
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Error");
                }
            } while(error);

          






        }
    }
}
