using System;
using System.Collections.Generic;
using System.Text;

namespace Hogueras
{
    class Hoguera
    {
        private string nombre;
        private Hoguera siguiente;

        public Hoguera(string nombre, Hoguera siguiente)
        {
            this.nombre = nombre;
            this.siguiente = siguiente;
        }

        public void Encender()
        {
            Console.WriteLine("Encendida hoguera de " + this.nombre);
            if(siguiente != null)
            {
                siguiente.Encender();
            }
        }
    }
}
