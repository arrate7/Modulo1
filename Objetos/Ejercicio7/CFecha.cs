using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class CFecha
    {
        private DateTime fecha;

        public CFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public int DevolverDia()
        {
            return fecha.Day;
        }
    }
}
