using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class ClienteE
    {
        int numero;
        string nombre;

        public ClienteE(int numero)
        {
            this.numero = numero;

        }
        public ClienteE(string nombre, int numero)
            : this(numero)
        {

            this.nombre = nombre;
        }

        public int Numero
        {
            get { return numero; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public static bool operator ==(ClienteE c1, ClienteE c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator !=(ClienteE c1, ClienteE c2)
        {
            return !(c1 == c2);
        }

    }
}
