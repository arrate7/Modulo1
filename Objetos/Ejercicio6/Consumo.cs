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

            Console.WriteLine("Kms: " + Kms);
            Console.WriteLine("Velocidad Media: " + Vmed);
            Console.WriteLine("Litros: " + Litros);
            Console.WriteLine("Tipo gasolina: " + Tipo);
            Console.WriteLine("Tiempo del viaje: " + GetTiempo());
            Console.WriteLine("Consumo medio del viaje: " + ConsumoMedio());
            Console.WriteLine("Consumo en euros: " + ConsumoEuros());
        }

        public double ConsumoEuros()
        {
            const double GASOLINA95 = 1.14;
            const double GASOLINA98 = 1.25;
            const double DIESEL = 1.04;

            switch (Tipo.ToLower())
            {
                case "gasolina98":
                  return  ConsumoMedio() * GASOLINA98;
                case "gasolina95":
                    return ConsumoMedio() * GASOLINA95;
                default:
                    return ConsumoMedio() * DIESEL;
                               
            }
        }
    }
}
