using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Satelite satelite = new Satelite(20, 10, 53);
            satelite.PrintPosicion();

            while (satelite.EnOrbita())
            {
                satelite.VariaAltura(-5);
                satelite.PrintPosicion();
            }
        }
    }
}
