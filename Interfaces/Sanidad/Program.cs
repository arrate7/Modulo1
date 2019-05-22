using System;
using System.Collections.Generic;

namespace Sanidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico m1 = new Medico("Rayos-x", 100, "12345678k", "María", 2000, 65);
            Medico m2 = new Medico("Pediatría", 150, "12345678h", "Juan", 2100, 43);
            Enfermero e1 = new Enfermero(1, "12345678k", "Jon", 1800, 39);
            Enfermero e2 = new Enfermero(0, "12345678k", "Iker", 1800, 66);
            Enfermero e3 = new Enfermero(1, "12345678k", "Arrate", 1900, 67);
            List<Sanitario> sanitarios = new List<Sanitario>()
            {
                m1,m2,e1,e2,e3
            };

            foreach (Sanitario sanitario in sanitarios)
            {
                //Muestro los datos iniciales
                sanitario.Mostrar();
                //Subo el salario base un 1%
                sanitario.SueldoBase = sanitario.SueldoBase * 1.01;
                //Muestro los datos con el salario modificado
                sanitario.Mostrar();
            }
            foreach (Sanitario sanitario in sanitarios)
            {
                //si se puede jubilar muestro los datos
                if (sanitario.Jubilable())
                {
                    sanitario.Mostrar();
                }
            }
        }
    }
}
