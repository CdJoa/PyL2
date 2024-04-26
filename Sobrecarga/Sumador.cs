using System;

namespace Sobrecarga
{
    public class Sumador
    {
        private int cantidadSumas;



        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0) { }

        public int GetCantidadDeSumas()
            { return cantidadSumas; }

        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            if (string.IsNullOrEmpty(a) && string.IsNullOrEmpty(b))
            {
                return string.Empty;
            }
            if (string.IsNullOrEmpty(a))
            {
                return b;
            }
            if (string.IsNullOrEmpty(b))
            {
                return a;
            }
            cantidadSumas+=1;

            return a + b;
        }
        public static explicit operator int(Sumador s)
        {
            return s.GetCantidadDeSumas();
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.GetCantidadDeSumas() + s2.GetCantidadDeSumas();
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.GetCantidadDeSumas() == s2.GetCantidadDeSumas();
        }

    }
}
/*using System;

using Sobrecarga;
class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de Sumador
        Sumador sumador1 = new Sumador();
        Console.WriteLine($"Cantidad de sumas del primer sumador: {(int)sumador1}");

        string resultadoString = sumador1.Sumar("Hola ", "mundo");

        // Probar el método Sumar con enteros
        long sumaEnteros = sumador1.Sumar(15, 20);

        Console.WriteLine($"Concatenación de cadenas: {resultadoString}");

        Console.WriteLine($"Cantidad de de sumas: {(int)sumador1}");

        Sumador sumador2 = new Sumador();
        long sumaEnteros2 = sumador2.Sumar(15, 20);
        string resultadoString2 = sumador2.Sumar("Adios ", "mundo");

        Console.WriteLine($"suma {sumaEnteros2}");

        Console.WriteLine($"Cantidad de de sumas: {(int)sumador2}");
        Console.WriteLine($"sumador de sumadores: {sumador1+ sumador2}");
        Console.WriteLine($"¿misma cantidad de sumas?  {sumador1 | sumador2}");


    }
}*/