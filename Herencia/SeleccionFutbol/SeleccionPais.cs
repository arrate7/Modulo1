using System;
using System.Collections.Generic;
using System.Text;

namespace SeleccionFutbol
{
    class SeleccionPais
    {
        public string Nombre { get; set; }
        public List<SeleccionFutbol> Participantes { get; set; }
        public int NumParticipantes { get; set; }

        public SeleccionPais(string nombre, List<SeleccionFutbol> participantes, int numParticipantes)
        {
            Nombre = nombre;
            Participantes = participantes;
            NumParticipantes = numParticipantes;
        }

        public void MostrarDatosSeleccion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            foreach (SeleccionFutbol miembro in Participantes)
            {
                miembro.MostrarDatos();
            }
        }

        public bool AltaSeleccion()
        {

            if (Participantes.Count < NumParticipantes)
            {
                int contEntrenadores = 0;
                int contMasajistas = 0;

                foreach (SeleccionFutbol miembro in Participantes)
                {
                    if (miembro.GetType().Name == "Entrenador")
                    {
                        contEntrenadores++;
                    }
                    if (miembro.GetType().Name == "Masajista")
                    {
                        contMasajistas++;
                    }
                }

                Console.WriteLine("Elige el tipo de participante a inscribir:");

                if (contMasajistas < 4)
                {
                    Console.WriteLine("1.Masajista");

                }
                if (contEntrenadores < 2)
                {
                    Console.WriteLine("2.Entrenador");

                }
                Console.WriteLine("3.Futbolista");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Masajista m1 = new Masajista();
                        Participantes.Add(m1);
                        return true;
                  
                    case 2:
                        Entrenador e1 = new Entrenador();
                        Participantes.Add(e1);
                        return true;
         
                    default:
                        Futbolista f1 = new Futbolista();
                        Participantes.Add(f1);
                        return true;                 
                }
            }
            else
            {
                return false;
            }
        }

        public bool BajaSeleccion()
        {
            Console.WriteLine("Introduce el ID del participante a dar de baja:");
            int idAEliminar = Convert.ToInt32(Console.ReadLine());

            SeleccionFutbol participanteAEliminar = null;
            foreach(SeleccionFutbol participante in Participantes)
            {
                Participantes.Remove(participante);
                if(participante.ID == idAEliminar)
                {
                    participanteAEliminar = participante;
                }
            }
            if(participanteAEliminar == null)
            {
                return false;
            }
            else
            {
                Participantes.Remove(participanteAEliminar);
                return true;
            }
        }
    }
}
