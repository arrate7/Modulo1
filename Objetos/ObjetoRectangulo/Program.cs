using System;

namespace ObjetoRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec1 = new Rectangulo();
            Console.WriteLine("Anchura: " + rec1.GetAnchura());
            Console.WriteLine("Altura: " + rec1.GetAltura());

            if (rec1.EsAlargado())
            {
                Console.WriteLine("El rectángulo es alargado");
            }
            else
            {
                Console.WriteLine("El rectángulo no es alargado");

            }

            rec1.Dibuja();
        }
    }
}
