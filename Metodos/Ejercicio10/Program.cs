using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime una palabra");
            string p1 = Console.ReadLine();
            Console.WriteLine("Tu palabra contiene " + Computo(p1));
        }
        public static int Computo(string pal1)
        {
            int palabras = 0;
            for (int i = 0; i < pal1.Length; i++)
            {
                string letra = pal1.Substring(i, 1);
                //char caracter = pal1[i];
                if (letra == " ")
                {
                    palabras++;
                }
            }
            palabras++;
            return palabras;
        }
    }
}
