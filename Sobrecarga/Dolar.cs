using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Sobrecarga
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        private Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion() * d.cantidad);
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(Peso.GetCotizacion() * d.cantidad);
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Dolar d2)
        {
            return new Dolar(d.cantidad + d2.cantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == p.GetCantidad();
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == (Dolar)e;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

    }
}
/*            Euro e = new Euro(10, 0.809f);
            Dolar d = new Dolar(10);
            Peso p = new Peso(10, 20.1655f);

            Peso p2 = 10;
            Peso p3 = new Peso(10);

            Euro aux_e = e + d;
            Console.WriteLine(@"Euro + Dólar : {0}", aux_e.GetCantidad());
            aux_e = e + p;
            Console.WriteLine("Euro + Pesos : {0}", aux_e.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro : {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos : {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Peso aux_p = p + e;
            Console.WriteLine("Pesos + Euro : {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar : {0}", aux_p.GetCantidad());
*/