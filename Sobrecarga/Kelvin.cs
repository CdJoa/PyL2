using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Sobrecarga
{
    public class Kelvin
    {
        private double cantidad;
        private static double valorRespectoCelsius = 273.15;

        static Kelvin()
        {
            valorRespectoCelsius = 273.15;
        }

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Kelvin(double cantidad, double grados) : this(cantidad)
        {
            valorRespectoCelsius = grados;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(k.cantidad - 273.15);
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((k.cantidad - 273.15) * (9.0 / 5.0) + 32);
        }

        public static implicit operator Kelvin(double k)
        {
            return new Kelvin(k);
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetGrados()
        {
            return valorRespectoCelsius;
        }

        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return !(k1 == k2);
        }

        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.cantidad - ((Kelvin)c).cantidad);
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.cantidad - ((Kelvin)f).cantidad);
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.cantidad + ((Kelvin)c).cantidad);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.cantidad + ((Kelvin)f).cantidad);
        }

        public static bool operator ==(Kelvin k, Celsius c)
        {
            return k.cantidad == ((Kelvin)c).cantidad;
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return k.cantidad == ((Kelvin)f).cantidad;
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return k1.cantidad == k2.cantidad;
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperaturaKelvin = 300.0;

            Kelvin kelvin = new Kelvin(temperaturaKelvin);

            // Conversión de Kelvin a Celsius
            Celcius celsius = (Celcius)kelvin;
            Console.WriteLine($"{temperaturaKelvin} Kelvin son {celsius.GetCantidad()} Celsius.");

            // Conversión de Kelvin a Fahrenheit
            Fahrenheit fahrenheit = (Fahrenheit)kelvin;
            Console.WriteLine($"{temperaturaKelvin} Kelvin son {fahrenheit.GetCantidad()} Fahrenheit.");
        }
    }
}
*/