using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetoRectangulo
{
    class Rectangulo
    {
        private int altura;
        private int anchura;

        public Rectangulo()
        {
            Console.WriteLine("Introduce la altura:");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la anchura:");
            anchura = Convert.ToInt32(Console.ReadLine());
        }

        public Rectangulo(int altura, int anchura)
        {
            this.altura = altura;
            this.anchura = anchura;
        }


        public int GetAltura()
        {
            return altura;
        }

        public void SetAltura(int altura)
        {
            this.altura = altura;
        }


        public int GetAnchura()
        {
            return anchura;
        }

        public void SetAnchura(int altura)
        {
            this.altura = altura;
        }

        public bool EsAlargado()
        {
            if(altura >= (anchura * 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dibuja()
        {
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < anchura; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }




        //public void SetAnchura(int anchura)
        //{
        //    if(anchura > 0)
        //    {
        //        this.anchura = anchura;
        //    }
        //    else
        //    {
        //        Console.WriteLine("La anchura debe ser mayor que 0");
        //    }
        //}

        //public bool EsAlargado()
        //{
        //    Console.Write("La altura es " + this.altura + " y la anchura: " + this.anchura + " ... ");
        //    if(this.anchura >= this.altura * 2)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
