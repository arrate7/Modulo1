using System;
using System.Collections.Generic;
using System.Text;

namespace Sanidad
{
    class Medico : Sanitario
    {
        public string Especialidad { get; set; }
        public int NumPacientes { get; set; }

        public Medico(string especialidad, int numPacientes, string dni,string nombre,double sueldoBase,int edad)
                        :base(dni,nombre,sueldoBase,edad)
        {
            Especialidad = especialidad;
            NumPacientes = numPacientes;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Especialidad: " + Especialidad);
            Console.WriteLine("Número de pacientes: " + NumPacientes);
            Console.WriteLine("Sueldo final: " + CalculaSueldo());
        }

        public override double CalculaSueldo()
        {
            return SueldoBase + (NumPacientes * 1.2);    
        }
    }
}
