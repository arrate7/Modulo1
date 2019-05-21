using System;
using System.Collections.Generic;
using System.Text;

namespace SeleccionFutbol
{
    class SeleccionFutbol
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public SeleccionFutbol()
        {
        }

        public SeleccionFutbol(int iD, string nombre, string apellidos, int edad)
        {
            ID = iD;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public virtual void MostrarDatos()
        {

            Console.WriteLine("*********************************");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("ID: " + ID);
        }

        public void Viajar()
        {
            Console.WriteLine(Nombre + " " + Apellidos + " ha viajado.");
        }
        public void Concentrarse()
        {
            Console.WriteLine(Nombre + " " + Apellidos + " se ha concentrado.");
        }

        public virtual void Accion()
        {

        }
    }
}
