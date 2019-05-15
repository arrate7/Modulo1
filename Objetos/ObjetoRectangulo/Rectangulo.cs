using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetoRectangulo
{
    class Rectangulo
    {
        public int altura;
        private int anchura;

        public Rectangulo() {}

        public Rectangulo(int altura, int anchura)
        {
            this.altura = altura;
            this.anchura = anchura;
        }

        public void SetAnchura(int anchura)
        {
            if(anchura > 0)
            {
                this.anchura = anchura;
            }
            else
            {
                Console.WriteLine("La anchura debe ser mayor que 0");
            }
        }

        public bool EsAlargado()
        {
            Console.Write("La altura es " + this.altura + " y la anchura: " + this.anchura + " ... ");
            if(this.anchura >= this.altura * 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
