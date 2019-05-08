using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 6
            Console.WriteLine("Introduzca 1 numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //bool resultado;
            //resultado = Bool(num1, num2);

            if (Bool(num1, num2))
            {
                Console.WriteLine("El primer numero es más grande");
            }
            else
            {
                Console.WriteLine("El segundo numero es más grande");
            }
        }
        public static bool Bool(int num1, int num2)
        {
            if (num1 > num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }
