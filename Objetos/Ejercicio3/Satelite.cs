using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;

        public Satelite(double meridiano, double p, double d)
        {
            this.meridiano = meridiano;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            //meridiano = paralelo = distancia_tierra = 0;
            meridiano = 0;
            paralelo = 0;
            distancia_tierra = 0;
        }


        public void SetPosicion(double m, double p, double d)
        {
            this.meridiano = m;
            this.paralelo = p;
            this.distancia_tierra = d;
        }

        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo
                + "Meridiano " + this.meridiano + " a una distancia de la tierra de " + distancia_tierra
                + "Kilómetros");
            //Console.ReadLine();
        }

        public void VariaAltura(double desplazamiento)
        {
            //this.distancia_tierra = this.distancia_tierra + desplazamiento;
            //this.distancia_tierra += desplazamiento;
            distancia_tierra += desplazamiento;
            if(distancia_tierra < 0)
            {
                Console.WriteLine("No puede bajar tanto");
                distancia_tierra = 0;
            }
        }

        public bool EnOrbita()
        {
            if (distancia_tierra > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return distancia_tierra > 0;
        }

        public void VariaPosicion(double variap, double variam)
        {
            this.paralelo += variap;
            this.meridiano += variam;
        }

    }
}
