using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class SobreSobreEscrito : SobreEscrito
    {
        public SobreSobreEscrito(): base()
        {

        }

        public override string MiPropiedad
        {
            get { return miAtributo; }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
using Encap;
using System;
using Herencia;
using BibliotecaCentralita;
using Polimorfismo;



class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Ejercicio Sobre-Sobrescrito";
        SobreEscrito objetoSobrescrito = new SobreSobreEscrito();

        Console.WriteLine(objetoSobrescrito.MiMetodo());

        string objeto = "¡Este es mi método ToString sobrescrito!";

        Console.WriteLine("----------------------------------------------");
        Console.Write("Comparación Sobrecargas con String: ");
        Console.WriteLine(objetoSobrescrito.Equals(objeto));

        Console.WriteLine("----------------------------------------------");
        Console.WriteLine(objetoSobrescrito.GetHashCode());

        Console.ReadKey();
    }
}

*/