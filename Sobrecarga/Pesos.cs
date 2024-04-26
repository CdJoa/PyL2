using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        static Pesos()
        {
            cotizacionRespectoDolar = 102.65;
        }

        public static double GetCotizacion()
        {
            return cotizacionRespectoDolar;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

    }
}
