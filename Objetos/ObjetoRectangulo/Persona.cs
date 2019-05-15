using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetoRectangulo
{
    class Persona
    {
        public string nombre;
        public int edad;

        public Persona()
        {
            nombre = "Pepito";
            edad = 123;
        }

        public Persona(string nombreInicial, int edadInicial)
        {
            nombre = nombreInicial;
            edad = edadInicial;
        }

    }
}
