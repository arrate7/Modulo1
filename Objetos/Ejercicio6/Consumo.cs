using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Consumo
    {
        public double Kms { get; set; }
        public double Litros { get; set; }
        public double Vmed { get; set; }
        public string Tipo { get; set; }

        public string GetTiempo()
        {
            double horas = Kms / Vmed;

            int minutos = Convert.ToInt32((horas / 100) * 60);
            int segundos = Convert.ToInt32(minutos % 60);
            int h = Convert.ToInt32(Kms / Vmed);

            return h + ":" + minutos + ":" + segundos;
        }

        public double ConsumoMedio()
        {
            return (100 * Litros) / Kms;
        }

        public void PrintConsumo()
        {
            Console.WriteLine("Tiempo del viaje: " + GetTiempo());
            Console.WriteLine("Consumo medio del viaje: " + ConsumoMedio());
        }
    }
}
