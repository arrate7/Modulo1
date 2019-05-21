using System;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(100);
            Automovil a1 = new Automovil(5,120);
            PalaMecanica p1 = new PalaMecanica(50,40);

            List<Vehiculo> garaje = new List<Vehiculo>()
            {
                v1,a1,p1
            };

            foreach (Vehiculo vehiculo in garaje)
            {
                vehiculo.MostrarDatos();
            }
                

        }
    }
}
