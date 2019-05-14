using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Finanzas euros = new Finanzas(40);
            Finanzas dolares = new Finanzas(120);
             
            Console.WriteLine(euros.GetDinero() + " euros son " +  euros.EurosToDolares() + " dolares");
            Console.WriteLine(dolares.GetDinero() + " dolares son " +  dolares.DolaresToEuros() + " euros");
        }
    }
}
