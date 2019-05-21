using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Vehiculo
    {
        public int CaballosFuerza { get; set; }

        public Vehiculo(int caballosFuerza)
        {
            CaballosFuerza = caballosFuerza;
        }

        public void Arrancar()
        {
            Console.WriteLine("Vehículo arranca.");
        }
        public void Detener()
        {
            Console.WriteLine("Vehículo se detiene.");
        }
    }
}
