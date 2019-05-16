using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorMillas c1 = new ConversorMillas()
            {
                Distancia = 20
            };

            Console.WriteLine(c1.Distancia + " millas son: " + c1.MillasAMetros() + " metros.");
            Console.WriteLine(c1.Distancia + " millas son: " + c1.MillasAKilometros() + " kilometros.");
        }
    }
}
