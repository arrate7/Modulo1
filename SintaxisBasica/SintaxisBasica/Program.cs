using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1

            //string miNombre = "Iciar";
            //Console.WriteLine("Hola " + miNombre);


            ////Ejercicio 2
            //int primerNumero = 3;
            //int segundoNumero = 2;

            //int num1 = 3, num2 = 2;

            //Console.WriteLine(primerNumero + " + " + segundoNumero + " = " + (primerNumero + segundoNumero));

            ////Ejercicio 3
            //double numeroDividido = 17;
            //double numeroDivisor = 2;

            //Console.WriteLine(numeroDividido / numeroDivisor);
            ////Ejercicio 4
            //int resultadoA = -5 + 8 * 6;
            //int resultadoB = (55 + 9) % 6;
            //double resultadoC = 20 + -3 * 5 / 8.0;
            //int resultadoD = 5 + 15 / 3 * 2 - 8 % 3;
            //Console.WriteLine("El resultado de la operacion - 5 + 8 * 6 es: " + resultadoA);
            //Console.WriteLine("Presiona una tecla para continuar.");

            //Console.WriteLine("El resultado de la operacion (55 + 9) % 6 es:" + resultadoB);
            //Console.WriteLine("Presiona una tecla para continuar.");

            //Console.WriteLine("El resultado de la operacion 20 + -3*5 / 8 es: " + resultadoC);
            //Console.WriteLine("Presiona una tecla para continuar.");

            //Console.WriteLine("El resultado de la operacion 5 + 15 / 3 * 2 - 8 % 3 es: " + resultadoD);
            //Console.WriteLine("Presione una tecla para salir.");

            //Console.WriteLine("Introduce un número: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(numero);
            //////Ejercicio 5
            ////Console.WriteLine("Por favor inserte 2 numeros para su multiplicación: ");// ejercicio 5
            ////int numero;
            ////numero =Convert.ToInt32(Console.ReadLine());          //int multiplicador;
            ////multiplicador = Convert.ToInt32(Console.ReadLine());
            ////int resultado;
            ////resultado = numero * multiplicador;
            ////Console.WriteLine("El resultado es: " + resultado);
            ////Console.ReadKey();

            ////Ejercicio 6

            //Console.WriteLine("Dame un numero");
            //double primerNumero = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Dame otro numero");
            //double segundoNumero = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(
            //    "Tus numeros sumados: " + (primerNumero + segundoNumero) + "\n"
            //    +
            //    "Tus numeros multiplicados: " + (primerNumero * segundoNumero) + "\n"
            //    +
            //    "Restados: " + (primerNumero - segundoNumero) + "\n"
            //    +
            //    "Divididos: " + (primerNumero / segundoNumero) + "\n"
            //    +
            //    "Y el resto: " + (primerNumero % segundoNumero)
            //    );

            ////Ejercicio 7

            //Console.WriteLine("Escoge un número al azar");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num3 + " * 1" + "=" + (num3 * 1));
            //Console.WriteLine(num3 + " * 2" + "=" + (num3 * 2));
            //Console.WriteLine(num3 + " * 3" + "=" + (num3 * 3));
            //Console.WriteLine(num3 + " * 4" + "=" + (num3 * 4));
            //Console.WriteLine(num3 + " * 5" + "=" + (num3 * 5));
            //Console.WriteLine(num3 + " * 6" + "=" + (num3 * 6));
            //Console.WriteLine(num3 + " * 7" + "=" + (num3 * 7));
            //Console.WriteLine(num3 + " * 8" + "=" + (num3 * 8));
            //Console.WriteLine(num3 + " * 9" + "=" + (num3 * 9));
            //Console.WriteLine(num3 + " * 10" + "=" + (num3 * 10));
            ////Ejercicio 8
            //Console.WriteLine((25.5 * 3.5) - (3.5 * 3.5) / (40.5 - 4.5));
            ////Ejercicio 9
            //Console.WriteLine((4.0 * (1 - (1.0 / 3)) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 1)));


            ////Funciones String 

            ////EJERCICIO 1

            ////OPCIÓN 1
            //Console.WriteLine("Dime tu nombre!");
            //string nombre = Console.ReadLine();
            //int tamano = nombre.Length;
            //Console.WriteLine("La largura de tu nombre es: " + tamano);

            ////OPCIÓN 2
            //Console.WriteLine("Dime tu nombre!");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("La largura de tu nombre es: " + nombre.Length);

            ////EJERCICIO 2

            //Console.WriteLine("introduce una frase en mayusculas");
            //string texto = Console.ReadLine();
            //string textoMinus = texto.ToLower();
            //Console.WriteLine("el texto en minusculas es: " + texto.ToLower());

            //EJERCICIO 3
            //string name = "bbk bootcamp";
            //Console.WriteLine(name.ToUpper());

            //Ejercicio 5 Cambiar una palabra o nombre por otro

            //string cadena = "Mañana va a llover 4343";
            //string cambio = cadena.Replace(cadena, "nevar");
            //Console.WriteLine(cambio);

            //Ejercicio 6

            //Console.WriteLine("tres tristes tigres comian trigo en un trigal");
            //string frase = "tres tristes tigres comian trigo en un trigal";
            //string subfrase = frase.Substring(5,10);
            //Console.WriteLine(subfrase);

        }
    }
}
