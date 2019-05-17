using System;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaCompra = new List<string>();
            listaCompra = CrearLista(listaCompra);

            MostrarLista(listaCompra);
            OrdenarLista(listaCompra);
            BorrarDeLista(listaCompra,"Pera");
            Console.WriteLine("Cantidad de elementos: " + ContarElementos(listaCompra));
        }

        public static List<string> CrearLista(List<string> listaCompra)
        {
            listaCompra.Add("Peras");
            listaCompra.Add("Manzanas");
            listaCompra.Add("Arroz");
           


            return listaCompra;
        }

        public static void MostrarLista(List<string> lista)
        {
            foreach (string producto in lista)
            {
                Console.WriteLine(producto);
            }
        }

        public static void OrdenarLista(List<string> lista)
        {
            lista.Sort();
            MostrarLista(lista);
        }

        public static void BorrarDeLista(List<string>lista,string producto)
        {
            
            if(lista.Remove(producto))
            {
                Console.WriteLine(producto + " se ha borrado.");
            }
            else
            {

                Console.WriteLine(producto + " no se encuentra en la lista");
            }

            MostrarLista(lista);
        }

        public static int ContarElementos(List<string> lista)
        {
            return lista.Count;
        }
    }
}

