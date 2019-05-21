using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo(100);
            Automovil a1 = new Automovil(5,120);
            PalaMecanica p1 = new PalaMecanica(50,40);

            a1.Acelerar(80);
            a1.Detener();
            p1.MoverPala("derecha");
        }
    }
}
