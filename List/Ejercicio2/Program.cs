using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();

            double num;

            do
            {
                Console.WriteLine("Introduce un número");
                num = Convert.ToDouble(Console.ReadLine());

                //if (num % 1 == 0)
                //{
                //    ints.Add(Convert.ToInt32(num));
                //}
                //else
                //{
                //    doubles.Add(num);
                //}

                if (num >= 0)
                {

                    if (Convert.ToString(num).Contains(","))
                    {
                        doubles.Add(num);
                    }
                    else
                    {
                        ints.Add(Convert.ToInt32(num));
                    }
                }

            } while (num >= 0);

            Console.WriteLine("Cantidad de números decimales: " + doubles.Count);
            Console.WriteLine("Cantidad de números enteros: " + ints.Count);

            SumarEnteros(ints);
            SacarMedia(ints, doubles);
        }

        public static int SumarEnteros(List<int> ints)
        {
            int suma = 0;

            foreach (int entero in ints)
            {
                suma += entero;
            }
            Console.WriteLine("La suma de los números enteros es: " + suma);

            return suma;

        }

        public static void SacarMedia(List<int> ints, List<double> doubles)
        {
            int sumaEnteros = SumarEnteros(ints);
            double sumaDoubles = 0;
            double media;

            foreach (double deci in doubles)
            {
                sumaDoubles += deci;
            }

            media = (sumaEnteros + sumaDoubles) / (ints.Count + doubles.Count);
            Console.WriteLine("La media es: " + media);
        }
    }
}
