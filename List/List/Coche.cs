using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Coche(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public Coche()
        {
        }

    }
}
