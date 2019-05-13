using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que dé la vuelta a un 
            // string pasado por parámetro y lo devuelva.
            Console.WriteLine("Escribe una palabra:");
            string frase = Console.ReadLine();
            string invertido = Program.Invertir(frase);
            Console.WriteLine(invertido);
            //Console.WriteLine(Invertir(Console.ReadLine()));
        }

        //public static string Invertir(string frase)
        //{
        //    string total = "";
        //    for (int i = frase.Length - 1; i >= 0; i--)
        //    {
        //        string letra = frase.Substring(i, 1);
        //        //char letra = frase[i];
        //        total = total + letra;
        //    }
        //    return total;
        //}

        public static string Invertir(string frase)
        {
            string total = "";
            for (int i = 0; i < frase.Length; i++)
            {
                string letra = frase.Substring(i, 1);
                //char letra = frase[i];
                total = letra + total;
            }
            return total;

        }
    }
}
