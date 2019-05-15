using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero();
            Numero n2 = new Numero(4);

            n1.Aniade();
            Console.WriteLine(n1.GetValor());
            Console.WriteLine(n2.GetTriple());

            

        }
    }
}
