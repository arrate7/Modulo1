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
            List<Habitacion> habitaciones = new List<Habitacion>();

            connection.Open();
            string query = "SELECT * FROM Habitaciones";
            SqlCommand comando = new SqlCommand(query, connection);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                //Habitacion h1 = new Habitacion(Convert.ToInt32(registros[0].ToString()), registros[1].ToString());
                //Habitacion h1 = new Habitacion();
                //h1.ID = Convert.ToInt32(registros[0].ToString());
                //h1.Estado = registros[1].ToString();
                //habitaciones.Add(h1);

                habitaciones.Add(new Habitacion(Convert.ToInt32(registros[0].ToString()), registros[1].ToString()));
            }

            foreach(Habitacion habitacion in habitaciones)
            {
                Console.WriteLine(habitacion.ID + " " + habitacion.Estado);
            }

        }
    }
}
