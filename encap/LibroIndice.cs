using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap
{
    public class LibroIndice
    {
        private List<string> paginas;

        public LibroIndice()
        {
            this.paginas = new List<string>();
        }

        public string this[int i] // Define un indexador para la clase que toma un índice entero y devuelve una cadena.
        {
            get
            {
                if (i >= 0 && i < this.paginas.Count) // Comprueba si el índice está dentro del rango válido.
                {
                    return paginas[i];
                }
                return "Pagina no valida";
            }

            set
            {
                if (i > this.paginas.Count) // Comprueba si el índice es mayor que el número de páginas existentes.
                {
                    this.paginas.Add(value); // Agrega una nueva página con el contenido especificado.
                }
                else if (i >= 0) // Comprueba si el índice es mayor o igual a cero.
                {
                    this.paginas.Insert(i, value); // Inserta una página en el índice especificado con el contenido especificado.
                }
            }
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
using Encapsulamiento;


using System;


class Program
{
    static void Main(string[] args)
    {
        LibroIndice libro = new LibroIndice();
        libro[0] = "Jon I";
        libro[1] = "Daenerys II";
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(libro[i]);
        }

        libro[2] = "Tyrion III";
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(libro[i]);
        }
    }

}

*/