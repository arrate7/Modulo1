using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Coche
    {
        /// ATRIBUTOS
        private string marca;
        private string modelo;
        private int puertas;
        private int caballos;
        private string tipo;

        //Constructor vacio
        public Coche()
        {

        }
        public Coche(string marca,string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public Coche(string marca, int puertas)
        {
            this.marca = marca;
            this.puertas = puertas;
        }

        public Coche(string marca, string modelo, int puertas, int caballos, string tipo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.puertas = puertas;
            this.caballos = caballos;
            this.tipo = tipo;
        }
        /// <summary>
        /// GETTERS Y SETTERS
        /// </summary>
        /// <returns></returns>
        /// 
        public string GetMarca()
        {
            return marca;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetModelo()
        {
            return modelo;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public int GetPuertas()
        {
            return puertas;
        }

        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;
        }

        public int GetCaballos()
        {
            return caballos;
        }

        public void SetCaballos(int caballos)
        {
            this.caballos = caballos;
        }
        public string GetTipo()
        {
            return tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void GirarDerecha()
        {
            Console.WriteLine("El coche: " + marca + " " + modelo + " gira a la derecha.");
        }







    }
}
