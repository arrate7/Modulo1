using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1
            //Console.WriteLine("Introduce un número:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce otro número:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 == num2)
            //{
            //    Console.WriteLine("Los números son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Los números no son iguales");
            //}

            ////Ejercicio 2
            //Console.WriteLine("Introduce un número:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //if (num1 % 2 == 0)
            //{
            //    Console.WriteLine("El número es par");

            //}
            //else
            //{
            //    Console.WriteLine("El número es impar");

            //}


            //Ejercicio 3
            //Console.WriteLine("Introduce un numero del 1 al 7. A continuacion te dire a que dia de la semana corresponde.");
            //int dia = Convert.ToInt32(Console.ReadLine());

            //if (dia == 1)
            //{
            //    Console.WriteLine("El dia de la semana es Lunes.");

            //}
            //else if (dia == 2)
            //{
            //    Console.WriteLine("El dia de la semana es Martes.");
            //}
            //else if (dia == 3)
            //{
            //    Console.WriteLine("El dia de la semana es Miércoles.");
            //}
            //else if (dia == 4)
            //{
            //    Console.WriteLine("El dia de la semana es Jueves.");
            //}
            //else if (dia == 5)
            //{
            //    Console.WriteLine("El dia de la semana es Viernes.");
            //}
            //else if (dia == 6)
            //{
            //    Console.WriteLine("El dia de la semana es Sábado.");
            //}
            //else if (dia == 7)
            //{
            //    Console.WriteLine("El dia de la semana es Domingo.");
            //}
            //else
            //{
            //    Console.WriteLine("El numero introducido no corresponde a ningun dia de la semana.");
            //}


            ////Ejercicio 4
            //Console.WriteLine("Introduce un número entre el 1-12:");
            //int mes = Convert.ToInt32(Console.ReadLine());

            //switch (mes)
            //{
            //    case 1:
            //        Console.WriteLine("Enero");
            //        break;

            //    case 2:
            //        Console.WriteLine("Febrero");
            //        break;
            //    case 3:
            //        Console.WriteLine("Marzo");
            //        break;
            //    case 4:
            //        Console.WriteLine("Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayo");
            //        break;
            //    case 6:
            //        Console.WriteLine("Junio");
            //        break;
            //    case 7:
            //        Console.WriteLine("Julio");
            //        break;
            //    case 8:
            //        Console.WriteLine("Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("Septiembre");
            //        break;
            //    case 10:
            //        Console.WriteLine("Octubre");
            //        break;
            //    case 11:
            //        Console.WriteLine("Noviembre");
            //        break;
            //    case 12:
            //        Console.WriteLine("Diciembre");
            //        break;

            //    default:
            //        Console.WriteLine("El número introducido es incorrecto");
            //        break;
            //}



            //Ejercicio 2
            //Console.WriteLine("Introduce 3 numeros cualquiera");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //double num3 = Convert.ToDouble(Console.ReadLine());
            //double resultado = num1 + num2;
            //if (resultado == num3)
            //{
            //    Console.WriteLine("El resultado es " + num3); //si se cumple la variable if arrojará el resultado del num3
            //}
            //else
            //{
            //    Console.WriteLine("La suma de los dos primeros números es diferente del tercero");
            //}
            //ejercicio 3


            Console.WriteLine("introduce  tres numeros");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2 - 20)
            {
                Console.WriteLine("El numero" + num1 + " es 20 unidades menor que " + num2);
            }

            if (num1 == num3 - 20)
            {
                Console.WriteLine("El numero " + num1 + " es 20 unidades menor que " + num3);
            }

            if (num2 == num1 - 20)
            {
                Console.WriteLine("El numero " + num2 + " es 20 unidades menor que " + num1);
            }

            if (num2 == num3 - 20)
            {
                Console.WriteLine("El numero " + num2 + " es 20 unidades menor que " + num3);
            }

            if (num3 == num1 - 20)
            {
                Console.WriteLine("El numero " + num3 + " es 20 unidades menor que " + num1);
            }

            if (num3 == num2 - 20)
            {
                Console.WriteLine("El numero " + num3 + " es 20 unidades menor que " + num2);
            }
            if (num3 != num2 - 20 && num3 != num1 - 20 && num2 != num3 - 20 && num2 == num1 - 20 && num1 == num3 - 20 && num1 == num2 - 20)
            {
                Console.WriteLine("Ninguno de los numeros indicadoes es menor que otro en 20 unidades");
            }
            ////Ejercicio 6

            //Console.WriteLine("Dime un número");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Dime un segundo número");
            //int n2 = Convert.ToInt32(Console.ReadLine());

            //if (n1 == n2)
            //{
            //    Console.WriteLine("0");
            //}
            //else if (n1 % 6 == n2 % 6)
            //{
            //    if (n1 < n2)
            //    {
            //        Console.WriteLine("El número más bajo es: " + n1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número más bajo es: " + n2);
            //    }
            //}
            //else
            //{
            //    if (n1 > n2)
            //    {
            //        Console.WriteLine("El número más alto es: " + n1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número más alto es: " + n2);
            //    }
            //}

            ////Ejercicio 7

            ////Versión 1

            //string numero1, numero2;
            //Console.WriteLine("introduce el primer numero entre 25 y 75: ");
            //numero1 = Console.ReadLine();
            //Console.WriteLine("introduce el segundo numero entre 25 y 75: ");
            //numero2 = Console.ReadLine();

            //if (numero1.Contains(numero2.Substring(0, 1)) | numero1.Contains(numero2.Substring(1, 1)))
            //{
            //    Console.WriteLine("existe un digito en comun");
            //}

            ////Versión 2

            //int numero1, numero2;
            //Console.WriteLine("introduce el primer numero entre 25 y 75: ");
            //numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("introduce el segundo numero entre 25 y 75: ");
            //numero2 = Convert.ToInt32(Console.ReadLine());


            //if(numero1 >= 25 && numero1 <= 75 && numero2 >=25 && numero2 <= 75)
            //{
            //    if(numero1/10 == numero2 / 10 || numero1 % 10 == numero2 % 10 || numero1 / 10 == numero2 % 10 || numero1 % 10 == numero2 / 10)
            //    {
            //        Console.WriteLine("Si coinciden");

            //    }              
            //    else
            //    {
            //        Console.WriteLine("No coinciden");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Los número introducidos no están en el rango.");
            //}
            Console.WriteLine("Ejercicio 8");
            Console.WriteLine("Carrera A");
            Console.WriteLine("En que puesto de la carrera has terminado?");
            int puesto = Convert.ToInt32(Console.ReadLine());
            if (puesto == 1)
            {
                Console.WriteLine("Enhorabuena, has ganado la carrera!");
            }
            else
            {
                Console.WriteLine("Don't Worry, lo importante es participar. :D");
            }

            Console.WriteLine("Pulsa cualquier tecla para continuar.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Carrera B");
            Console.WriteLine("En que puesto de la carrera has terminado?");
            if (puesto == 1)
            {
                Console.WriteLine("MEDALLA DE ORO!");

            }
            else if (puesto == 2)
            {
                Console.WriteLine("Medalla de Plata.");

            }
            else if (puesto == 3)
            {
                Console.WriteLine("Medalla de Bronce.");

            }
            else
            {
                Console.WriteLine("Don't worry, lo importante es participar :D");

            }

            Console.WriteLine("Pulsa cualquier tecla para continuar.");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Carrera C");
            switch (puesto)
            {
                case 1:
                    Console.WriteLine("MEDALLA DE ORO!");
                    break;
                case 2:
                    Console.WriteLine("Medalla de Plata.");
                    break;
                case 3:
                    Console.WriteLine("Medalla de Bronce.");
                    break;
                default:
                    Console.WriteLine("Don't worry, lo importante es participar :D");
                    break;
            }

            if (puesto == 1 || puesto == 2 || puesto == 3)
            {
                Console.WriteLine("Sube al podium");
            }
            else
            {
                Console.WriteLine("Lo importante es participar");
            }

            switch (puesto)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Sube al podium");
                    break;
                default:
                    Console.WriteLine("Lo importante es participar");
                    break;
            }
            ////Ejercicio 11
            //Console.WriteLine("Escribe lo primero que te venga a la cabeza");
            //string frase = Console.ReadLine();

            //int fraseLength = frase.Length;

            //Console.WriteLine(fraseLength);

            //if (fraseLength % 2 == 0) //comprobación de que la largura de la frase es par
            //{
            //    Console.WriteLine(frase.Substring((fraseLength / 2 - 1), 2)); //meto el (-1) porque la orden length empieza a contar desde 1 y sin embargo la posicion la empieza a contar desde 0, es una simple correccion
            //}
            //else
            //{
            //    Console.WriteLine(frase.Substring((fraseLength / 2), 1)); // el 1 me está diciendo el numero de caracteres que quiero que me imprima en pantalla
            //}

        }
    }
}
