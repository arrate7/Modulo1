using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Suma(5, 9);
            Console.WriteLine(resultado);
        }

        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
