using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Herencia
{
    public class Puesto : ICompensacion
    {
        private string nombrePuesto;
        private float remuneraciónOfrecida;
        private Random rnd;

        private Puesto()
        {
            rnd = new Random();
            this.remuneraciónOfrecida = rnd.Next(100000, 300000);
        }

        public Puesto(string nombre) : this()
        {
            this.nombrePuesto = nombre;
        }

        public string Posicion { get => nombrePuesto; }

        public float CalcularHonorarios
        {
            get
            {
                return this.remuneraciónOfrecida;
            }
        }

        public override string ToString()
        {
            return "Se busca " + this.nombrePuesto + " - " + "Sueldo ofrecido: " + CalcularHonorarios.ToString();
        }
    }
}


