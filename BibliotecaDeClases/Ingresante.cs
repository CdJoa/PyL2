using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BibliotecaDeClases
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;


        public Ingresante(string direccion, int edad, string genero, string nombre, string pais, string[] cursos)
        {
            // Inicializar la lista de cursos en el constructor
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Edad: " + edad);
            sb.AppendLine("Género: " + genero);
            sb.AppendLine("Dirección: " + direccion);
            sb.AppendLine("País: " + pais);
            sb.AppendLine("Cursos:");

            foreach (string curso in cursos)
            {
                sb.AppendLine(curso);
            }

            // Devuelve la cadena construida en lugar de escribir en la consola
            return sb.ToString();
        }
    }
}


