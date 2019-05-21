using System;
using System.Collections.Generic;

namespace SeleccionFutbol
{
    class Program
    {
        static void Main(string[] args)
        {

            Futbolista f1 = new Futbolista(7,"Centrocampista",7,"Beñat","Etxebarria",28);
            Futbolista f2 = new Futbolista(10,"Delantero",10,"Iker","Muniain",26);
            Futbolista f3 = new Futbolista(13,"Portero",13,"Iago","Herrerin",30);
            Futbolista f4 = new Futbolista(4,"Defensa",4,"Iñigo","Martinez",27);
            Entrenador e1 = new Entrenador("ATH", 1, "Gaizka", "Garitano", 45);
            Masajista m1 = new Masajista("Fisioterapeuta", 10, 2, "Juanito", "Oyarzabal", 50); ;
            Masajista m2 = new Masajista("Fisioterapeuta", 10, 2, "Joseluis", "Korta", 50); ;

            List<SeleccionFutbol> miembros = new List<SeleccionFutbol>()
            {
                f1,f2,f3,f4,m1,m2,e1
            };

            //foreach (SeleccionFutbol miembro in miembros)
            //{
            //    miembro.MostrarDatos();
            //    miembro.Viajar();
            //    miembro.Concentrarse();
            //    miembro.Accion();
            //}

            SeleccionPais sp = new SeleccionPais("Euskadi",miembros,10);
            sp.MostrarDatosSeleccion();

            if (sp.AltaSeleccion())
            {
                Console.WriteLine("Participante dado de alta.");
            }
            else
            {
            }

            if(sp.BajaSeleccion())
            {
                Console.WriteLine("Participante dado de baja.");

            }
            else
            {
                Console.WriteLine("No se ha dado de baja al participante");

            }
        }
    }
}
