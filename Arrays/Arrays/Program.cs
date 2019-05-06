using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////EJERCICIO 1
            ///
            int[] posiciones = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < posiciones.Length; i++)
            {
                Console.WriteLine(posiciones[i]);
            }

            int[] pos = new int[11];
            for (int i = 0; i < pos.Length; i++)
            {
                pos[i] = i;
                Console.WriteLine(pos[i]);
            }

            ///////////////////////EJERCICIO 2
            ///
            Console.WriteLine("Ejercicio 2");
            string[] palabras = new string[3];

            //Console.WriteLine("Introduce tu nombre.");
            //nombreApellidos[0] = Console.ReadLine();
            //Console.WriteLine("Introduce tu primer apellido.");
            //nombreApellidos[1] = Console.ReadLine();
            //Console.WriteLine("Introduce tu segundo apellido.");
            //nombreApellidos[2] = Console.ReadLine();

            for (int i = 0; i < palabras.Length; i++)
            {
                Console.WriteLine("Introduce una palabra:");
                palabras[i] = Console.ReadLine();
            }

            Console.WriteLine("Palabras:" + palabras[1] + " " + 
                palabras[2] + ", " + palabras[0]);

        }
    }
}
