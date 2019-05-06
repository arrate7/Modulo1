using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {




            //int numOperacion;
            //do
            //{
            //    Console.WriteLine("*****************");
            //    Console.WriteLine("   Calculadora");
            //    Console.WriteLine("*****************");
            //    Console.WriteLine("1. Suma");
            //    Console.WriteLine("2. Resta");
            //    Console.WriteLine("3. Multiplicación");
            //    Console.WriteLine("4. Potencia");
            //    Console.WriteLine("5. División");
            //    Console.WriteLine("6. Raíz");
            //    Console.WriteLine("7. Salir" + "\n");
            //    Console.WriteLine("Introduce la opción deseada:");
            //    numOperacion = Convert.ToInt32(Console.ReadLine());

            //    double numero1 = 0;
            //    double numero2 = 0;

            //    if (numOperacion > 0 && numOperacion < 6)
            //    {
            //        Console.WriteLine("Introduce el primer número:");
            //        numero1 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Introduce el segundo número:");
            //        numero2 = Convert.ToDouble(Console.ReadLine());
            //    }

            //    switch (numOperacion)
            //    {
            //        case 1:
            //            Console.WriteLine("Operación seleccionada: Suma");
            //            Console.WriteLine(numero1 + "+" + numero2 + "=" + (numero1 + numero2));
            //            break;
            //        case 2:
            //            Console.WriteLine("Operación seleccionada: Resta");
            //            Console.WriteLine(numero1 + "-" + numero2 + "=" + (numero1 - numero2));
            //            break;
            //        case 3:

            //            Console.WriteLine("Operación seleccionada: Multiplicación");
            //            Console.WriteLine(numero1 + "*" + numero2 + "=" + (numero1 * numero2));
            //            break;
            //        case 4:

            //            Console.WriteLine("Operación seleccionada: Potencia");
            //            Console.WriteLine(numero1 + " ^ " + numero2 + " = " + (Math.Pow(numero1, numero2)));
            //            break;
            //        case 5:

            //            Console.WriteLine("Operación seleccionada: División");
            //            Console.WriteLine(numero1 + "/" + numero2 + "=" + (numero1 / numero2));
            //            break;
            //        case 6:
            //            Console.WriteLine("Introduce el número:");
            //            numero1 = Convert.ToDouble(Console.ReadLine());
            //            Console.WriteLine("Operación seleccionada: Raíz");
            //            Console.WriteLine("|" + numero1 + "=" + (Math.Sqrt(numero1)));
            //            break;
            //        case 7:
            //            Console.WriteLine("Hasta luego!");
            //            break;
            //        default:
            //            Console.WriteLine("Opción " + numOperacion + " no disponible, vuelva a intentarlo");
            //            break;
            //    }
            //} while (numOperacion != 7);



            ///////PARTE 2: SOLO NÚMEROS POSITIVOS
            //bool salir = false;
            //do
            //{
            //    Console.WriteLine("Introduce una operación matemática:");
            //    string operacion = Console.ReadLine(); //300+200
            //    string simbolo = "";
            //    int posicionSimbolo;

            //    if (operacion.ToLower() == "q")
            //    {
            //        salir = true;
            //    }
            //    else
            //    {

            //        for (int i = 0; i < operacion.Length; i++)
            //        {

            //            if (!Char.IsDigit(Convert.ToChar(operacion.Substring(i, 1))))
            //            {
            //                simbolo = operacion.Substring(i, 1);
            //            }

            //        }

            //        posicionSimbolo = operacion.IndexOf(simbolo);
            //        double num1 = Convert.ToDouble(operacion.Substring(0, posicionSimbolo));
            //        double num2 = Convert.ToDouble(operacion.Substring(posicionSimbolo + 1));
            //        double resultado;
            //        switch (simbolo)
            //        {

            //            case "+":
            //                resultado = num1 + num2;
            //                Console.WriteLine(resultado);
            //                break;

            //            case "-":
            //                resultado = num1 - num2;
            //                Console.WriteLine(resultado);
            //                break;

            //            case "*":
            //                resultado = num1 * num2;
            //                Console.WriteLine(resultado);
            //                break;

            //            case "/":
            //                resultado = num1 / num2;
            //                Console.WriteLine(resultado);
            //                break;

            //            default:
            //                Console.WriteLine("Debes introducir una operación matemática: +, -, * o /.");
            //                break;
            //        }

            //    }

            //} while (!salir);

            ///////////////////////////////VERSIÓN ARRATE PARTE 2
            ///
            //    double valor1 = 0, valor2 = 0;
            //    string operacion = "";
            //    string simbolo = "";
            //    bool simboloEncontrado = false;
            //    int contSimbolos = 0;
            //    int contOperaciones = 0;
            //    double resultado = 0;

            //    while (operacion.ToUpper() != "Q")
            //    {
            //        simboloEncontrado = false;
            //        contSimbolos = 0;

            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("*********************************************************");
            //        Console.WriteLine("\t\tCALCULADORA");
            //        Console.WriteLine("*********************************************************");
            //        Console.ResetColor();
            //        Console.WriteLine("Introduzca la operación:");
            //        operacion = Console.ReadLine().ToUpper();

            //        for (int i = 0; i < operacion.Length; i++)
            //        {
            //            if (!char.IsDigit(Convert.ToChar(operacion.Substring(i, 1))) && i != 0)
            //            {
            //                if (contSimbolos == 0)
            //                {
            //                    if (operacion.Contains("M") && contOperaciones > 0)
            //                    {
            //                        valor1 = resultado;
            //                        simbolo = operacion.Substring(operacion.IndexOf("M") + 1, 1);

            //                        valor2 = Convert.ToDouble(operacion.Substring(operacion.IndexOf(simbolo) + 1));
            //                        simboloEncontrado = true;
            //                    }
            //                    else if (operacion.Substring(0, 1) == "M" && contOperaciones == 0)
            //                    {
            //                        Console.WriteLine("No hay datos en la memoria");
            //                    }

            //                    else if (operacion.Substring(i, 1) == "S")
            //                    {
            //                        simbolo = operacion.Substring(i, 4);
            //                        valor1 = Convert.ToDouble(operacion.Substring(0, operacion.IndexOf(simbolo)));
            //                        valor2 = Convert.ToDouble(operacion.Substring(operacion.IndexOf(simbolo) + 4));
            //                        simboloEncontrado = true;
            //                    }

            //                    else
            //                    {
            //                        simbolo = operacion.Substring(i, 1).ToUpper();
            //                        valor1 = Convert.ToDouble(operacion.Substring(0, operacion.IndexOf(simbolo)));
            //                        valor2 = Convert.ToDouble(operacion.Substring(operacion.IndexOf(simbolo) + 1));

            //                        simboloEncontrado = true;
            //                    }
            //                    contSimbolos++;
            //                }
            //            }

            //        }
            //        if (simboloEncontrado)
            //        {

            //            switch (simbolo)
            //            {
            //                case "+":
            //                    resultado = valor1 + valor2;
            //                    break;
            //                case "-":
            //                    resultado = valor1 - valor2;
            //                    break;
            //                case "*":
            //                    resultado = valor1 * valor2;
            //                    break;
            //                case "/":
            //                    resultado = valor1 / valor2;
            //                    break;
            //                case "^":
            //                    resultado = Math.Pow(valor1, valor2);
            //                    break;
            //                case "SQRT":
            //                    resultado = Math.Sqrt(valor1);
            //                    break;
            //            }

            //            Console.WriteLine(valor1 + " " + simbolo + " " + valor2 + " = " + resultado);
            //            contOperaciones++;

            //        }
            //        else if (operacion.ToUpper().Contains("Q"))
            //        {
            //            Console.WriteLine("Agur");
            //        }
            //        else
            //        {
            //            Console.WriteLine("La operación introducida no es correcta.");
            //        }

            //        Console.ReadLine();
            //    }

        }

    }
}
