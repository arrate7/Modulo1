using System;
using System.Data.SqlClient;

namespace PruebaConexion
{
    class Program
    {
        static void Main(string[] args)
        {
            // MOSTRAR DATOS DE LA BASE DE DATOS
            // Ponemos la información para conectar a la base de datos
            SqlConnection connection = new SqlConnection("Data source=DESKTOP-QEAKD04\\SQLEXPRESS;Initial Catalog=VARIOS;Integrated Security=True");
            // El string que pediremos a SQL
            string query = "SELECT apellido, oficio FROM emple where dept_no=20;";
            // abrimos la conexión
            connection.Open();
            // Creamos el comando en base a la petición y conexión
            SqlCommand comando = new SqlCommand(query, connection);
            //ejecutamos la petición y creamos un reader para ver los registros
            SqlDataReader registros = comando.ExecuteReader();
            // mientras el reader nos indique que hemos obtenido datos
            // seguimos pedindo más datos
            while (registros.Read())
            {
                // por cada datos que tenemos en el reader, lo mostramos en pantalla
                Console.WriteLine(registros["apellido"].ToString() + " con oficio: " + registros["oficio"].ToString());

            }
            // cerramos la conexión
            connection.Close();

            // CAMBIAR DATOS en la BASE DE DATOS(en este ejemplo pasamos un UPDATE, pero
            // podiamos haber pasado una query con DELETE o INSERT INTO del mismo modo
            //pedimos al usuario un nombre
            Console.WriteLine("Introduce un nombre");
            string nombre = Console.ReadLine();

            // actualizamos el valor de query (ya que ya está 
            // declarado arriba, e introducimos el valor
            // de la variable nombre en el lugar del valor del
            // apellido
            query = "update emple set apellido='" + nombre + "' where emp_no=7369;";
            // volvemos a abrir la conexión a la base de datos
            connection.Open();
            // actualizamos comando con un nuevo comando
            // ya que hemos cambiado el valor de query
            comando = new SqlCommand(query, connection);
            // como no queremos ver datos sino solo mandar
            // un comando al servidor de sql, basta con un
            // execute non query. Ver la base de datos para
            // ver que se ha cambiado el nombre (o volver a
            // ejecutar el programa)
            comando.ExecuteNonQuery();
            // cerramos la conexión para finalizar
            connection.Close();
        }
    }

}
