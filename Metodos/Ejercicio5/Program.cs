using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            //////VERSIÓN 1

            //do
            //{
            //    Console.WriteLine("Introduce un número:");
            //    num1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Introduce otro número:");
            //    num2 = Convert.ToDouble(Console.ReadLine());

            //    if (num2 != 0)
            //    {
            //        double resultado = Division(num1, num2);
            //        Console.WriteLine(resultado);
            //    }

            //} while (num2 != 0);

            //////VERSIÓN 2

            Console.WriteLine("Introduce un número:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            while (num2!=0)
            {
                double resultado = Division(num1, num2);
                Console.WriteLine(resultado);

                Console.WriteLine("Introduce un número:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce otro número:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }


        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
