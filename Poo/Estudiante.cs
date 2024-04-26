using System.Text;

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
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaPrimerParcial = nota;

            }
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;

            }
        }
        private float CalcularPromedio()
        {
            return ((float)(this.notaPrimerParcial + this.notaSegundoParcial)) / 2;
        }
        public void CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                this.notaFinal = random.Next(6, 11);
            }
            else
            {
                this.notaFinal = -1;
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