using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Automovil : Vehiculo
    {
        public int Puertas { get; set; }

        public Automovil(int puertas, int cf):base(cf)
        {
            Puertas = puertas;
        }

        public void Acelerar(int cuanto)
        {
            base.Arrancar();
            Console.WriteLine("Acelera " + cuanto + " km/h");
        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Puertas: " + Puertas);
            Console.WriteLine("***********************************");
        }



    }
}
