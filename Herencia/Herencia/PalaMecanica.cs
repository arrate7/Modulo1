using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class PalaMecanica: Vehiculo
    {
        public int PML { get; set; }

        public PalaMecanica(int pML, int cf):base(cf)
        {
            PML = pML;
        }

        public void MoverPala(string direccion)
        {
            base.Arrancar();
            Console.WriteLine("Mueve la pala hacia " + direccion);
        }
    }
}
