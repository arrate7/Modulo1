using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    class Contacto
    {
        //private string nombre;
        //public string GetNombre()
        //{
        //    return nombre;
        //}
        //public void SetNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}
        private const int LIMITE_EDAD = 121;
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Contacto()
        {

        }
        public Contacto(string nombre,
            string telefono, 
            DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Telefono = telefono;
            ComprobarFecha(fechaNacimiento);
        }

        public Contacto(string nombre,
                        DateTime fechaNacimiento)
        {
            Nombre = nombre;
            ComprobarFecha(fechaNacimiento);
        }

        private void ComprobarFecha(DateTime fechaNacimiento)
        {
            if (fechaNacimiento > DateTime.Today
                            && fechaNacimiento < DateTime.Today.AddYears(-LIMITE_EDAD))
            {
                FechaNacimiento = DateTime.Today;
            }
            else
            {
                FechaNacimiento = fechaNacimiento;
            }
        }

        public Contacto(string nombre, 
                        string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
            FechaNacimiento = DateTime.Today;
        }
    }


    }
}
