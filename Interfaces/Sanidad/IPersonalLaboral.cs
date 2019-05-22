using System;
using System.Collections.Generic;
using System.Text;

namespace Sanidad
{
    interface IPersonalLaboral
    {
        void Mostrar();
        bool Jubilable();
        double CalculaSueldo();
    }
}
