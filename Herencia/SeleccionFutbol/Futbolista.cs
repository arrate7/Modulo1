using System;
using System.Collections.Generic;
using System.Text;

namespace SeleccionFutbol
{
    class Futbolista : SeleccionFutbol
    {
        public int Dorsal { get; set; }
        public string Demarcacion { get; set; }

        public Futbolista(int dorsal, string demarcacion, int id,string nombre,string apellidos, int edad)
            :base(id,nombre,apellidos,edad)
        {
            Dorsal = dorsal;
            Demarcacion = demarcacion;
        }

        public Futbolista()
        {
        }
        
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Dorsal: " + Dorsal);
            Console.WriteLine("Demarcación: " + Demarcacion);

        }

        public override void Accion()
        {
            Console.WriteLine("Entrena."); 

        }
    }
}
