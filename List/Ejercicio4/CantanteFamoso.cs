using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4
{
    class CantanteFamoso
    {
        public string Nombre { get; set; }
        public string Disco { get; set; }

        public CantanteFamoso(string nombre, string disco)
        {
            Nombre = nombre;
            Disco = disco;
        }

        public CantanteFamoso()
        {
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre + " Disco con más ventas: " + Disco);
        }
    }
}
