﻿using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO 1

            //for (int i = 10; i <= 20; i++)
            //{
            //    Console.WriteLine(i + "\n");
            //    //Console.WriteLine();
            //}

            //EJERCICIO 2

            //VERSIÓN 1

            //int numero = 20;
            //while (numero >= 10)
            //{
            //    Console.WriteLine(numero);
            //    Console.WriteLine();
            //    numero--;
            //}

            //VERSIÓN 2

            //for(int i = 20; i >= 10; i--)
            //{
            //    Console.WriteLine(i + "\n");

            //}

            ////Ejercicio 3

            //double suma = 0;
            //double num;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Introduzca otro numero:");
            //    num = Convert.ToDouble(Console.ReadLine());
            //    suma = suma + num;
            //}
            //Console.WriteLine("La media de los numeros introducido es: " + suma / 10.0);

            //Ejercicio 4
            int total = 0;
            int numero;
            do
            {
                Console.WriteLine("introduce un numero");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0)
                {
                    Console.WriteLine("Se ignoran los valores negativos");
                }
                else
                {
                    total += numero;
                }
            }
            while (numero != 0);

            Console.WriteLine(total);
        }
    }
}
