using System;
using System.Collections.Generic;
using System.Text;

namespace Sanidad
{
    class Sanitario : IPersonalLaboral
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public double SueldoBase { get; set; }
        public int Edad { get; set; }

        public Sanitario(string dNI, string nombre, double sueldoBase, int edad)
        {
            DNI = dNI;
            Nombre = nombre;
            SueldoBase = sueldoBase;
            Edad = edad;
        }

        public Sanitario()
        {
        }


        public virtual double CalculaSueldo()
        {
            return SueldoBase;
        }

        public bool Jubilable()
        {
            if (Edad >= 65)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Edad: " + Edad);
            
        }
    }
}
