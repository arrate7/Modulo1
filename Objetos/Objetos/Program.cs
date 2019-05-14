using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Seat", "Ibiza",5,98,"Gasolina");
            Coche coche2 = new Coche("Seat", "Ibiza");
            Coche coche3 = new Coche();


            coche1.SetModelo("León");
            coche1.GirarDerecha();

            coche3.SetMarca("Ferrari");
            coche3.SetModelo("F40");
            coche3.SetPuertas(2);
            coche3.SetCaballos(300);
            coche3.SetTipo("Gasolina");
            coche2 = coche3;

            Console.WriteLine("Coche: " + coche1.GetMarca() + " " + coche1.GetModelo());
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Puertas: " + coche1.GetPuertas());
            Console.WriteLine("Caballos: " + coche1.GetCaballos());
            Console.WriteLine("Tipo: " + coche1.GetTipo());

            Console.WriteLine("Coche: " + coche3.GetMarca() + " " + coche3.GetModelo());
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Puertas: " + coche3.GetPuertas());
            Console.WriteLine("Caballos: " + coche3.GetCaballos());
            Console.WriteLine("Tipo: " + coche3.GetTipo());
        }
    }
}
