using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get => nombreClase; }
        public string NombreMetodo { get => nombreMetodo; }


        public CompetenciaNoDisponibleException(string mensaje, string NombreClase, string NombreMetodo)
        : base(mensaje)
        {
            this.nombreClase = NombreClase;
            this.nombreMetodo = NombreMetodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string NombreClase, string NombreMetodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = NombreClase;
            this.nombreMetodo = NombreMetodo;
        }

        public override string ToString()
        {
            string message = string.Format("Excepción en el método {0} de la clase {1}:\n{2}", NombreMetodo, NombreClase, Message);

            Exception innerException = InnerException;
            while (innerException != null)
            {
                message += $"\n\t{innerException.Message}";
                innerException = innerException.InnerException;
            }

            return message;
        }
    }
}
