using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Fahrenheit
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        private Fahrenheit()
        {
            cotizRespectoDolar = 1;
        }

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /* hacer antes del primer parcial */
    }
}
