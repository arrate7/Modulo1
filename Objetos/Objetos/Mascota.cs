using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Mascota
    {
        public string Raza { get; set; }
        public string Nombre { get; set; }

        public Mascota(string raza, string nombre)
        {
            Raza = raza;
            Nombre = nombre;
        }

        public Mascota()
        {
        }

        public Mascota(string raza)
        {
            Raza = raza;
        }

        public void PrintMascota()
        {
            Console.WriteLine(Raza + " " + Nombre);
        }
    }
}
