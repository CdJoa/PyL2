using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado(float longitudLado) : base(longitudLado, longitudLado)
        {

        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado...";
        }
    }
}
