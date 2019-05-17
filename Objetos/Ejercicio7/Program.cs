using System;
using Agenda;
using Ejercicio6;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto c1 = new Contacto("Iker", DateTime.Now);
            //c1.SetNombre("Iker");
            c1.Nombre = "Iker";

            //Console.WriteLine(c1.GetNombre());
            Console.WriteLine(c1.Nombre);

        }
    }
}
