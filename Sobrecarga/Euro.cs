using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Euro
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        static Euro()
        {
            cotizacionRespectoDolar = 1.17;
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
