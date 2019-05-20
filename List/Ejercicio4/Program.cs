using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPCION 1
            //List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>()
            //{
            //    new CantanteFamoso("Ed Sheeran","Happier"),
            //    new CantanteFamoso("Rihanna","Umbrella")
            //};

            //OPCION 2
            //List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>();
            //CantanteFamoso c1 = new CantanteFamoso("Ed Sheeran", "Happier");
            //CantanteFamoso c2 = new CantanteFamoso("Rihanna", "Umbrella");
            //listaCantantesFamosos.Add(c1);
            //listaCantantesFamosos.Add(c2);

            //OPCION 3
            CantanteFamoso c1 = new CantanteFamoso("Ed Sheeran", "Happier");
            CantanteFamoso c2 = new CantanteFamoso("Rihanna", "Umbrella");
            List<CantanteFamoso> listaCantantesFamosos = new List<CantanteFamoso>()
            {
                c1,c2
            };

            AnadirCantante(listaCantantesFamosos);
            MostrarLista(listaCantantesFamosos);

        }

        public static void AnadirCantante(List<CantanteFamoso> cantantes)
        {
            string respuesta;
            do
            {
                Console.WriteLine("Nombre del artista:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Disco del artista:");
                string disco = Console.ReadLine();

                CantanteFamoso c1 = new CantanteFamoso(nombre, disco);
                cantantes.Add(c1);

                MostrarLista(cantantes);

                Console.WriteLine("¿Quieres añadir otro (s/n)?");
                respuesta = Console.ReadLine().ToLower();


            } while (respuesta == "s");

        }

        public static void MostrarLista(List<CantanteFamoso> cantantes)
        {
            foreach (CantanteFamoso cantante in cantantes)
            {
                cantante.MostrarDatos();
            }
        }
    }
}
