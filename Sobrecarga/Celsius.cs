using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Sobrecarga
{
    public class Celsius
    {
        private double cantidad;
        private static double valorRespectoCelsius = 1;

        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Celsius(double cantidad, double grados) : this(cantidad)
        {
            valorRespectoCelsius = grados;
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((c.cantidad * 9 / 5) + 32);
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(c.cantidad + 273.15);
        }

        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetGrados()
        {
            return valorRespectoCelsius;
        }

        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
        }

        public static bool operator !=(Celsius c, Celsius c2)
        {
            return !(c == c2);
        }

        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(c.cantidad - ((Celsius)k).cantidad);
        }

        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad - ((Celsius)f).cantidad);
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(c.cantidad + ((Celsius)k).cantidad);
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.cantidad + ((Celsius)f).cantidad);
        }

        public static bool operator ==(Celsius c, Kelvin k)
        {
            return c.cantidad == k.GetCantidad();
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return c.cantidad == ((Celsius)f).cantidad;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.cantidad == c2.cantidad;
        }
    }
}


/*using System;
using Sobrecarga;

using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelsius = 25.0;

            Celcius celsius = new Celcius(temperaturaCelsius);

            // Conversión de Celsius a Fahrenheit
            Fahrenheit fahrenheit = (Fahrenheit)celsius;
            Console.WriteLine($"{temperaturaCelsius} Celsius son {fahrenheit.GetCantidad()} Fahrenheit.");

            // Conversión de Celsius a Kelvin
            Kelvin kelvin = (Kelvin)celsius;
            Console.WriteLine($"{temperaturaCelsius} Celsius son {kelvin.GetCantidad()} Kelvin.");
        }
    }
}

*/