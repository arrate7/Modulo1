using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    class Finanzas
    {
        private double dinero;

        public Finanzas()
        {

        }
        public Finanzas(double dinero)
        {
            this.dinero = dinero;
        }

        public double GetDinero()
        {
            return dinero;
        }

        public void SetDinero(double dinero)
        {
            this.dinero = dinero;
        }

        public double DolaresToEuros()
        {
            return dinero * 0.92;
        }
        public double EurosToDolares()
        {
            return dinero * 1.08;
        }
    }
}
