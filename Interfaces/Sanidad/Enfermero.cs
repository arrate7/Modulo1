using System;
using System.Collections.Generic;
using System.Text;

namespace Sanidad
{
    class Enfermero : Sanitario
    {
        public int Puesto { get; set; }

        public Enfermero(int puesto, string dni, string nombre, double sueldoBase, int edad)
                : base(dni, nombre, sueldoBase, edad)
        {
            Puesto = puesto;
        }

        public Enfermero()
        {
        }

        public override void Mostrar()
        {
            base.Mostrar();
            const int UCI = 0;
            if (Puesto == UCI)
            {
                Console.WriteLine("Puesto: UCI");

            }
            else
            {
                Console.WriteLine("Puesto: Planta");

            }
            Console.WriteLine("Sueldo final: " + CalculaSueldo());
        }
        public override double CalculaSueldo()
        {
            const int UCI = 0;

            if (Puesto == UCI)
            {
                return SueldoBase + 200;

            }
            else
            {
                return SueldoBase;
            }

        }
    }
}
