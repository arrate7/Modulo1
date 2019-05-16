using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio5
{
    class ConversorMillas
    {
        public double Distancia { get; set; }

        public double MillasAMetros()
        {
            return Distancia * 1852;
        }

        public double MillasAKilometros()
        {
            return Distancia * 1.852;
        }

    }
}
