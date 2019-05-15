using System;

namespace Hogueras
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoguera septima = new Hoguera("Amon Anwar", null);
            Hoguera sexta = new Hoguera("Calenhad", septima);
            Hoguera quinta = new Hoguera("Min-Rimmon", sexta);
            Hoguera cuarta = new Hoguera("Erelas", quinta);
            Hoguera tercera = new Hoguera("Nardol", cuarta);
            Hoguera segunda = new Hoguera("Eilenach", tercera);
            Hoguera primera = new Hoguera("Amon Dîn", segunda);

            primera.Encender();
        }
    }
}
