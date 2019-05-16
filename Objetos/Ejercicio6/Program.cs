using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructores
            Coche c1 = new Coche();
            Coche c2 = new Coche("Mini","Cooper");

            //No hace falta constructor
            Coche c3 = new Coche()
            {
                Marca = "Peugeot",
                Modelo = "308"
            };
            Coche c4 = new Coche()
            {
                Marca = "Ferrari",
                Modelo = "F40"
    
            };

            Consumo renault = new Consumo()
            {
                Kms = 368,
                Litros = 18,
                Vmed = 100,
                Tipo = "Diesel"

            };
            Consumo Mini = new Consumo()
            {
                Kms = 256,
                Litros = 12,
                Vmed = 110,
                Tipo = "Gasolina"

            };
            Consumo Peugeot = new Consumo()
            {
                Kms = 489,
                Litros = 23,
                Vmed = 115,
                Tipo = "Diesel"

            };
            Consumo ferrari = new Consumo()
            {
                Kms = 378,
                Litros = 25,
                Vmed = 128,
                Tipo = "Gasolina"

            };

            c1.PrintCoche();
            renault.PrintConsumo();
            c2.PrintCoche();
            Mini.PrintConsumo();
            c3.PrintCoche();
            Peugeot.PrintConsumo();
            c4.PrintCoche();
            ferrari.PrintConsumo();

        }
    }
}
