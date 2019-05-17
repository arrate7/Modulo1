using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio6
{
    class Coche
    {

        public string Marca{ get; set; }
        public string Modelo { get; set; }

        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public Coche()
        {
            Marca = "Renault";
            Modelo = "Laguna";
        }

        public void PrintCoche()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine(Marca + " " + Modelo);
            Console.WriteLine("********************************************");
          
        }
    }
}
