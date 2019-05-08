using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que cuente las vocales de un string pasado por parámetro.
            Console.WriteLine("Introduce tu frase");
            string frase = Console.ReadLine();
            Console.WriteLine("Numero de vocales es: " + NumeroDeVocales(frase));
        }

        public static int NumeroDeVocales(string frase)
        {
            int numeroDeVocales = 0;
            //string[] vocales = { "a", "e", "i", "o", "u" };

            frase = frase.ToLower();

            for (int i = 0; i < frase.Length; i++)
            {
                //Sacar caracter específico de un string opción 1
                //char letra = frase[i];

                //Sacar caracter específico de un string opción 2
                string letra = frase.Substring(i,1);

                //Comparar chars
                //if(letra == 'a' ||letra == 'e' || letra =='i' || letra == 'o' || letra == 'u')
                
                //Comparar strings
                if(letra == "a" || letra == "e" || letra =="i" || letra == "o" || letra == "u")
                {
                    numeroDeVocales++;
                }

                //Versión con las letras en un array

                //for (int j = 0; j < vocales.Length; j++)
                //{
                //    if (frase.Substring(i, 1).Contains(vocales[j]))
                //    {
                //        numeroDeVocales++;
                //    }
                //}
            }
            return numeroDeVocales;
        }
    }
}