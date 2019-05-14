using System;
using System.Data.SqlClient;

namespace EjercicioSqlClase
{
    class Program
    {
        static SqlConnection connection = new SqlConnection("Data source=DESKTOP-QEAKD04\\SQLEXPRESS;Initial Catalog=VARIOS;Integrated Security=True");

        static void Main(string[] args)
        {
            //Console.WriteLine("Introduce el apellido:");
            //string apellido = Console.ReadLine();
            //Console.WriteLine("Introduce el oficio:");
            //string oficio = Console.ReadLine();
            //Console.WriteLine("Introduce el dir:");
            //int dir = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce el salario:");
            //int salario = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce la comisión:");
            //int comision = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce el departamento:");
            //int dep = Convert.ToInt32(Console.ReadLine());
            //int numEmpleado = 8500;

            ////FECHA HOY
            //DateTime fechaHoy = DateTime.Now;
            //string fecha = fechaHoy.ToString("dd/MM/yyyy");

            ////string query = "INSERT INTO EMPLE VALUES (" + numEmpleado + ",'" +
            ////    apellido + "','" + oficio + "'," + dir + ",'" + fecha + "'," +
            ////    salario + "," + comision + "," + dep + ")";

            //string query = "INSERT INTO EMPLE VALUES (" + numEmpleado + ",'" +
            //    apellido + "','" + oficio + "'," + dir + ",GETDATE()," +
            //    salario + "," + comision + "," + dep + ")";

            //SqlCommand comando = new SqlCommand(query, connection);
            //connection.Open();
            //comando.ExecuteNonQuery();
            //Console.WriteLine("Empleado insertado");
            //connection.Close();

            //Console.WriteLine("Introduce tu nuevo salario:");
            //int nuevoSalario = Convert.ToInt32(Console.ReadLine());

            //string query = "UPDATE EMPLE SET SALARIO = " + nuevoSalario + 
            //    " WHERE EMP_NO = 8500";

            //SqlCommand comando = new SqlCommand(query, connection);
            //connection.Open();
            //comando.ExecuteNonQuery();
            //Console.WriteLine("Salario modificado");
            //connection.Close();

            string query = "SELECT  * FROM EMPLE WHERE EMP_NO = 8500";
            SqlCommand comando = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader registros = comando.ExecuteReader();
            registros.Read();

            Console.WriteLine(registros[0].ToString() + " " + registros[1].ToString() + " " + registros[2].ToString() + " " + registros[3].ToString() + " " + registros[4].ToString());

        }

        public static void Algo()
        {
            connection
        }
    }
}
