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
        private static double valorRespectoCelsius;

        static Fahrenheit()
        {
            valorRespectoCelsius = (9.0 / 5.0); // 9/5 = 1 en C#
        }

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Fahrenheit(double cantidad, double grados) : this(cantidad)
        {
            valorRespectoCelsius = grados;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.cantidad - 32) * (5.0 / 9.0));
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin(((f.cantidad - 32) * (5.0 / 9.0)) + 273.15);
        }

        public static implicit operator Fahrenheit(double f)
        {
            return new Fahrenheit(f);
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetGrados()
        {
            return valorRespectoCelsius;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1 == f2);
        }

        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.cantidad - ((Fahrenheit)c).cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.cantidad - ((Fahrenheit)k).cantidad);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.cantidad + ((Fahrenheit)c).cantidad);
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.cantidad + ((Fahrenheit)k).cantidad);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f.cantidad == ((Fahrenheit)c).cantidad;
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return f.cantidad == ((Fahrenheit)k).cantidad;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.cantidad == f2.cantidad;
        }
    }
}
/*using System;
using Sobrecarga;


namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperaturaFahrenheit = 0;

            Fahrenheit fahrenheit = new Fahrenheit(temperaturaFahrenheit);


            Celcius celsius = (Celcius)fahrenheit;

            Console.WriteLine($"{temperaturaFahrenheit} Fahrenheit son {celsius.GetCantidad()} Celsius.");

            // Conversión de Celsius a Kelvin
            Kelvin kelvin = (Kelvin)fahrenheit;
            Console.WriteLine($"{temperaturaFahrenheit} Celsius son {kelvin.GetCantidad()} Kelvin.");
        }
    }
}


*/