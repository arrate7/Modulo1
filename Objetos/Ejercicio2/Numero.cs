using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Numero
    {
        //atributo
        private int valor;

        //constructor vacío
        public Numero()
        {

        }

        //constructor con parámetro
        public Numero(int valor)

        {
            this.valor = valor;
        }


        //GETTERS Y SETTERS

        public int GetValor()
        {
            return valor;
        }

        public void SetValor(int valor)
        {
            this.valor = valor;
        }

        //OTROS MÉTODOS

        public void Aniade()
        {
            valor++;
        }

        public void Resta()

        {
             valor--;

        }

        public int GetDoble()
        {

            return valor * 2;
        }

        public int GetTriple()
        {

            return valor * 3;
        }

        public void SetNumero()  //public void o public int¿?
        {
            valor = 0;
        }
    }
}