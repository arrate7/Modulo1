using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int years;

            do
            {
                Console.WriteLine("Escribe un año");
                years = Convert.ToInt32(Console.ReadLine());

                //bool bisiesto = Year(years);

                if (Year(years))
                {
                    Console.WriteLine("El año es bisiesto");
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto");
                }

            } while (years != 0);
        }
        public static bool Year(int num1)
        {
            //if (DateTime.IsLeapYear(num1))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return DateTime.IsLeapYear(num1);
        }
    }
}