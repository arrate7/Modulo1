using System;
using System.Collections.Generic;
using System.Text;

namespace SeleccionFutbol
{
    class Entrenador : SeleccionFutbol
    {
        public string IDFederacion { get; set; }
        public Entrenador(string IdFederacion, int id, string nombre, string apellidos, int edad)
                        : base(id, nombre, apellidos, edad)
        {
            IDFederacion = IdFederacion;
        }

        public Entrenador()
        {
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("IdFederación: " + IDFederacion);
    
        }

        public override void Accion()
        {
            Console.WriteLine("Dirige el entrenamiento");
        }
    }
}
