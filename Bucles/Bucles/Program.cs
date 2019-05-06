using System;

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
            //int total = 0;
            //int numero;
            //do
            //{
            //    Console.WriteLine("introduce un numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero < 0)
            //    {
            //        Console.WriteLine("Se ignoran los valores negativos");
            //    }
            //    else
            //    {
            //        total += numero;
            //    }
            //}
            //while (numero != 0);

            //Console.WriteLine(total);

            //Ejercicio 5

            //string answer;
            //do
            //{
            //    Console.WriteLine("Pulse la tecla ``P´´ para explorar los valores pares del 1 al 100, e ``I´´ para los impares");
            //    answer = Console.ReadLine().ToUpper();

            //} while (answer != "P" && answer != "I");

            //if (answer == "P")
            //{
            //    for (int i = 0; i <= 100; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //if (answer == "I")
            //{
            //    for (int i = 1; i <= 100; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Ejercicio 6

            //Console.WriteLine("Introduce tu edad:");
            //int edad = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= edad; i++)
            //{
            //    Console.WriteLine("Zorionak");
            //}

            //Ejercicio 7
            //Console.WriteLine("Introduce la cantidad de líneas:");
            //int cantidad = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= cantidad; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //string asterisco = "*";

            //for (int i = 0; i < cantidad; i++)
            //{
            //    Console.WriteLine(asterisco);
            //    asterisco = asterisco + "*";
            //}

            //for (string asterisco = "*"; asterisco.Length <= cantidad; asterisco += "*")
            //{
            //    Console.WriteLine(asterisco);
            //}

            ///////////////////////Ejercicio 12
            ///VERSIÓN ELENA
            //int x;
            //int number = 0;
            //do
            //{
            //    Console.WriteLine("Introduzca la contraseña");
            //    x = 0;
            //    string password = Console.ReadLine();

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("La contraseña debe tener más de 8 dígitos" + "\n");
            //        x++;

            //    }
            //    else 
            //    {
            //        if (!char.IsUpper(Convert.ToChar(password.Substring(0, 1))))
            //        {
            //            Console.WriteLine("La contraseña debe contener una mayúscula en primera posición" + "\n");
            //            x++;
            //        }
            //        else 
            //        {
            //            for (int i = 0; i < password.Length; i++)
            //            {
            //                if (char.IsDigit(Convert.ToChar(password.Substring(i, 1))))
            //                {
            //                    number += 1;
            //                }
            //            }
            //            if (number == 0)
            //            {
            //                Console.WriteLine("La contraseña debe tener al menos un número " + "\n");
            //                x = (x + 1);
            //            }
            //        }
            //    }

            //} while (x != 0);
            //Console.WriteLine("Enhorabuena, la contraseña es adecuada");


            ///////////////////////Ejercicio 12
            ///VERSIÓN ARRATE
            //bool correcto = false;
            //bool numeroEncontrado = false;

            //do
            //{

            //    Console.WriteLine("Introduce una contraseña:");
            //    string pass = Console.ReadLine();

            //    if (pass.Length < 8)
            //    {
            //        Console.WriteLine("La contraseña tiene que contener al menos 8 caracteres ");
            //    }
            //    else
            //    {
            //        for(int i = 1; i < pass.Length; i++)
            //        {
            //            if (char.IsDigit(Convert.ToChar(pass.Substring(i, 1))))
            //            {
            //                numeroEncontrado = true;
            //            }
            //        }

            //        if (numeroEncontrado)
            //        {

            //            if (char.IsUpper(Convert.ToChar(pass.Substring(0, 1))))
            //            {
            //                correcto = true;

            //            }
            //            else
            //            {
            //                Console.WriteLine("La primera letra de la contraseña debe estar en mayúsculas");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine("La contraseña necesita un número");
            //        }


            //    }
            //} while (!correcto);

            //Console.WriteLine("Contraseña correcta");
        }
    }
}
