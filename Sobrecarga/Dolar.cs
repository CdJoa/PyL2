using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        static Dolar()
        {
            cotizacionRespectoDolar = 1;
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

