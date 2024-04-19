using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Estudiante
    {

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random = new Random();
        private int notaFinal;


        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        // Método setter para cambiar la nota del segundo parcial
        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }
        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2.0;
        }
        public void CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11); // Nota aleatoria entre 6 y 10
            }
            else
            {
                notaFinal = -1;
            }
        }
        public string Mostrar()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Nombre: {nombre}");
            info.AppendLine($"Apellido: {apellido}");
            info.AppendLine($"Legajo: {legajo}");
            info.AppendLine($"Nota del primer parcial: {notaPrimerParcial}");
            info.AppendLine($"Nota del segundo parcial: {notaSegundoParcial}");
            info.AppendLine($"Promedio: {(notaPrimerParcial + notaSegundoParcial) / 2.0}");

            if (notaFinal != -1)
            {
                info.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                info.AppendLine("Alumno desaprobado");
            }

            return info.ToString();
        }
    }
}
/*using System;
using BibliotecaDeClases;
using Calculadora;
using Poo;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancia de Estudiante
        Estudiante estudiante = new Estudiante("Juan", "Pérez", "12345");

        // Asignar notas a los parciales
        estudiante.SetNotaPrimerParcial(7);
        estudiante.SetNotaSegundoParcial(8);

        // Calcular nota final
        estudiante.CalcularNotaFinal();

        // Mostrar información del estudiante
        Console.WriteLine(estudiante.Mostrar());
    }
 
}*/