using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////EJERCICIO 1
            ///
            //int[] posiciones = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < posiciones.Length; i++)
            //{
            //    Console.WriteLine(posiciones[i]);
            //}

            //int[] pos = new int[11];
            //for (int i = 0; i < pos.Length; i++)
            //{
            //    pos[i] = i;
            //    Console.WriteLine(pos[i]);
            //}

            ///////////////////////EJERCICIO 2
            ///
            //Console.WriteLine("Ejercicio 2");
            //string[] palabras = new string[3];

            ////Console.WriteLine("Introduce tu nombre.");
            ////nombreApellidos[0] = Console.ReadLine();
            ////Console.WriteLine("Introduce tu primer apellido.");
            ////nombreApellidos[1] = Console.ReadLine();
            ////Console.WriteLine("Introduce tu segundo apellido.");
            ////nombreApellidos[2] = Console.ReadLine();

            //for (int i = 0; i < palabras.Length; i++)
            //{
            //    Console.WriteLine("Introduce una palabra:");
            //    palabras[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Palabras:" + palabras[1] + " " + 
            //    palabras[2] + ", " + palabras[0]);

            /////////////////////////EJERCICIO 3
            /////
            //int[] numeros = new int[10];

            //int j = 20;

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = j;
            //    j--;
            //}

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //Console.WriteLine(numeros[i]);

            ////EJERCICIO 4

            /* Crear un array de 3 ints. Usar un for para pedir al usuario que 
             * introduzca valores a cada una de las posiciones. Usar otro for 
             * para mostrarlos en pantalla.
             */
            // creado el array con 3 huecos
            //int[] numeros = new int[2];

            //// por cada valor en el array le pedimos un numero al usuario y guardarlo
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Introduce un número:");
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());
            //}


            //// por cada valor en el array mostralo en pantalla
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}


            ////EJERCICIO 5

            //int[] numbers = new int[3]; //new int because we dont know what the user is going to put


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int smallestNumber = numbers[0]; 

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < smallestNumber) // 
            //    {
            //        smallestNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine("The smallest number is " + smallestNumber);


            //////////////EJERCICIO 6

            //string[] meses = { "Enero", "Febrero", "Marzo", "Abril",
            //    "Mayo", "Junio", "Julio", "Agosto", "Septiembre",
            //    "Octubre", "Noviembre", "Diciembre" };

            //Console.WriteLine("introduce un numero de mes para ver " +
            //    "a que mes corresponde");

            //int numeroDeMes = Convert.ToInt32(Console.ReadLine());

            //if (numeroDeMes >= 1 && numeroDeMes <= 12)
            //{
            //    Console.WriteLine(meses[numeroDeMes - 1]);

            //}
            //else
            //{
            //    Console.WriteLine("El número introducido no es correcto");

            //}


            ///////////////////EJERCICIO 7
            int[] num = new int[10];
            double suma = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("introduce un valor");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                suma += num[i];
            }

            Console.WriteLine("La media de los valores: " + suma/num.Length);




        }
    }
}
