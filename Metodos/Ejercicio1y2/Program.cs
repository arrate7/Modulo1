using System;

namespace Ejercicio1y2
{
    class Program
    {
        static void Main(string[] args)
        {
            //RepeatHola();
            //Console.WriteLine(" Introduce los  numeros 5 y 3 ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            EscribeHola(3);
            Console.WriteLine("");
            EscribeHola(5);

        }
        public static void RepeatHola()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hola");
            }
        }
        public static void EscribeHola(int veces)
        {

            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine("Hola");
            }
        }
    }
}
