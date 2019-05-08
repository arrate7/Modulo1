using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Suma(num1, num2);

            Console.WriteLine(resultado);
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
