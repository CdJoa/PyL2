using BibliotecaCentralita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BibliotecaCentralita
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get => nombreClase; }
        public string NombreMetodo { get => nombreMetodo; }

        public CentralitaException(string mensaje, string NombreClase, string NombreMetodo)
            : base(mensaje)
        {
            this.nombreClase = NombreClase;
            this.nombreMetodo = NombreMetodo;
        }

        public CentralitaException(string mensaje, string NombreClase, string NombreMetodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = NombreClase;
            this.nombreMetodo = NombreMetodo;
        }
    }
}
