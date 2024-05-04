using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;


using System;


    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de autos
            AutoF1 a1 = new AutoF1(1, "escu 1");
            AutoF1 a2 = new AutoF1(4, "escu 2");
            AutoF1 a3 = new AutoF1(5, "escu 3");
            AutoF1 a4 = new AutoF1(1, "escu 1");
            AutoF1 a5 = new AutoF1(2, "escu 4");

            // Crear una competencia
            Competencia competencia = new Competencia(5, 10);

            // Agregar autos a la competencia
            Console.WriteLine("Agregando autos a la competencia:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Resultado: " + (competencia + a1)); // Debería agregar el auto a1
            Console.WriteLine("Resultado: " + (competencia + a2)); // Debería agregar el auto a2
            Console.WriteLine("Resultado: " + (competencia + a3)); // Debería agregar el auto a3
            Console.WriteLine("Resultado: " + (competencia + a4)); // Debería fallar porque a4 ya está en la competencia
            Console.WriteLine("Resultado: " + (competencia + a5)); // Debería agregar el auto a5
            Console.WriteLine("----------------------");

            // Mostrar datos de la competencia
            Console.WriteLine(competencia.MostrarDatos());

            // Quitar un auto de la competencia
            Console.WriteLine("Quitando un auto de la competencia:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Resultado: " + (competencia - a3)); // Debería quitar el auto a3
            Console.WriteLine("----------------------");

            // Mostrar datos de la competencia después de quitar el auto
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadLine();
        }
    }

