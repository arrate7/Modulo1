using System;

namespace ArraysOperaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Arrate", "Iker", "Jon" };
            // Mostrar elementos del array del principio al fin
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            // Mostrar elementos del fin al principio
            for(int i = nombres.Length -1; i >= 0; i--)
            {
                Console.WriteLine(nombres[i]);
            }
            // Ver si un elemento no cumple una condición
            bool todosLongitudMayorQue4 = true;
            for(int i = 0; i < nombres.Length; i++)
            {
                if(nombres[i].Length < 4)
                {
                    todosLongitudMayorQue4 = false;
                }
            }
            if(todosLongitudMayorQue4)
            {
                Console.WriteLine("Todos los strings tienen más de 4 elementos");
            }
            else
            {
                Console.WriteLine("No todos los strings tienen más de 4 elementos");
            }

            // Sumar todos los elementos
            string resultado = "";
            for(int i = 0; i < nombres.Length; i++)
            {
                resultado += nombres[i];
            }
            Console.WriteLine("Todos los nombres unidos son: " + resultado);
        }
    }
}
