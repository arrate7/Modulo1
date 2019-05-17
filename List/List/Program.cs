using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREO LOS COCHES
            Coche c1 = new Coche
            {
                Marca = "Peugeot",
                Modelo = "308"
            };

            Coche c2 = new Coche("Seat", "Ibiza");
            Coche c3 = new Coche("Toyota", "Yaris");

            //INICIAR LA LISTA (ESTÁ VACIA)
            List<Coche> coches = new List<Coche>();

            //AÑADIR EN LA LISTA
            coches.Add(c1);
            coches.Add(c2);
            coches.Add(c3);

            //INICIAR LA LISTA CON VALORES
            List<Coche> coches2 = new List<Coche>()
            {
                c1,c2,c3
            };

            //Imprimir lista con foreach
            foreach (Coche coche in coches)
            {
                Console.WriteLine(coche.Marca + " " + coche.Modelo);
            }

            //Imprimir lista con for
            for(int i = 0; i < coches.Count; i++)
            {

                Console.WriteLine(coches.ElementAt(i).Modelo);
            }

        }
    }
}
