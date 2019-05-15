using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class Peso
    {
        private double kilos;

        public Peso(double peso)
        {
            this.kilos = peso;
        }

        public Peso(double peso, string medida)
        {
            if(medida == "G")
            {
                this.kilos = peso / 1000;
            }
            else if(medida == "K")
            {
                this.kilos = peso;
            }
            else if(medida == "Li")
            {
                this.kilos = peso * 0.453;
            }
            
        }

        public double GetPeso(string medida)
        {
            if(medida == "K")
            {
                return kilos;
            }
            else if(medida == "G")
            {
                return kilos * 1000;
            }
            else if(medida == "Li")
            {
                return GetLibras();
            }
            return 0;
        }

        public double GetLibras()
        {
            return kilos / 0.453;
        }
    }
}
