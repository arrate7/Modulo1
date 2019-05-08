using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero cualquiera");
            int num = Convert.ToInt32(Console.ReadLine());

            //if (ParImpar(num))
            //{
            //    Console.WriteLine("El numero es par");
            //}
            //else
            //{
            //    Console.WriteLine("El numero es impar");
            //}
            Console.WriteLine(ParImpar(num));
        }


        public static string ParImpar(int num)
        {
            if (num % 2 == 0)
            {
                return "Es par";
            }

            else
            {
                return "Es impar";
            }

        }
    }
}