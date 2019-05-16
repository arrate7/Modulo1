using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo el coche con todos los atributos
            Coche coche1 = new Coche("Seat", "Ibiza",5,98,"Gasolina");
            //Creo otro coche con 2 atributos
            Coche coche2 = new Coche("Seat", "Ibiza");
            //Creo otro coche vacio
            Coche coche3 = new Coche();

            //Cambio el modelo del coche1
            coche1.SetModelo("León");
            //Hago que el coche1 gire a la derecha
            coche1.GirarDerecha();

            //Establezco el valor de los atributos del coche3 uno a uno
            coche3.SetMarca("Ferrari");
            coche3.SetModelo("F40");
            coche3.SetPuertas(2);
            coche3.SetCaballos(300);
            coche3.SetTipo("Gasolina");

            //Copio en coche2 los datos del coche3  
            coche2 = coche3;

            //Imprimo todos los datos del coche1
            Console.WriteLine("Coche: " + coche1.GetMarca() + " " + coche1.GetModelo());
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Puertas: " + coche1.GetPuertas());
            Console.WriteLine("Caballos: " + coche1.GetCaballos());
            Console.WriteLine("Tipo: " + coche1.GetTipo());

            //Imprimo todos los datos del coche2
            Console.WriteLine("Coche: " + coche3.GetMarca() + " " + coche3.GetModelo());
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Puertas: " + coche3.GetPuertas());
            Console.WriteLine("Caballos: " + coche3.GetCaballos());
            Console.WriteLine("Tipo: " + coche3.GetTipo());



            Mascota m1 = new Mascota()
            {
                Raza = "Perro",
                Nombre = "Nala"
            };

            Mascota m2 = new Mascota("Hamster","Gustavo");
            //SET
            m2.Nombre = "Milu";
            m2.Raza = "Gato";
            //GET
            string raza = m2.Raza;
            Console.WriteLine(m2.Raza + " " + m2.Nombre);
        }
    }
}
