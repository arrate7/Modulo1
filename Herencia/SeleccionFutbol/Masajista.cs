using System;
using System.Collections.Generic;
using System.Text;

namespace SeleccionFutbol
{
    class Masajista : SeleccionFutbol
    {
        public string Titulacion { get; set; }
        public int AniosExp { get; set; }

        public Masajista(string titulacion, int aniosExp, int id, string nombre, string apellidos, int edad)
                    : base(id, nombre, apellidos, edad)
        {
            Titulacion = titulacion;
            AniosExp = aniosExp;
        }

        public Masajista()
        {
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Titulación: " + Titulacion);
            Console.WriteLine("Años Experiencia: " + AniosExp);
        }

        public override void Accion()
        {
            Console.WriteLine("Da masajes.");
        }
    }
}
