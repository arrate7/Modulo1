using System;

namespace ObjetoRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persona persona1 = new Persona("Iker", 39);

            //Persona persona2 = new Persona();
            //persona2.nombre = "Jon";
            //persona2.edad = 92;

            //Console.WriteLine(persona1.nombre);
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Rectangulo r = new Rectangulo(random.Next(), random.Next());
                if (r.EsAlargado())
                {
                    Console.WriteLine("Es alargado");
                }
                else
                {
                    Console.WriteLine("No es alargado");
                }
            }
            
            //Console.WriteLine(rectangulo2.anchura);
        }
    }
}
