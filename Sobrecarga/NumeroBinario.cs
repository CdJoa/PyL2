using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class NumeroBinario
    {
        private string _numero;

        private NumeroBinario(string numero)
        {
            _numero = numero;
        }

        public string Numero
        {
            get { return _numero; }
        }

        public static implicit operator NumeroBinario(string numBinario)
        {
            return new NumeroBinario(numBinario);
        }

        public static explicit operator string(NumeroBinario nb)
        {
            return nb.Numero.ToString();
        }

        public static explicit operator NumeroBinario(NumeroDecimal nd)
        {
            return new NumeroBinario(Conversor.DecimalABinario(nd.Numero));
        }


        // Sobrecarga de operador + y - entre NumeroBinario y NumeroDecimal
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            return Conversor.DecimalABinario(((NumeroDecimal)nb).Numero + nd.Numero);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double numDecimal = ((NumeroDecimal)nb).Numero - nd.Numero;
            return Conversor.DecimalABinario(numDecimal);
        }


        // Sobrecarga de operador == y != entre NumeroBinario y NumeroDecimal
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            return nb.Numero == ((NumeroBinario)nd).Numero;
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }
    }
}
/*using System;
using Sobrecarga;

using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create NumeroBinario and NumeroDecimal objects
            NumeroBinario numeroBinario1 = "1110";
            NumeroDecimal numeroDecimal1 = 33;

            // Conversion (explicit operator overload)
            NumeroDecimal convertedDecimal = (NumeroDecimal)numeroBinario1; // 10 (decimal)
            Console.WriteLine("Binario a decimal: {0}", convertedDecimal.Numero);

            NumeroBinario convertedBinary = (NumeroBinario)numeroDecimal1; // 1010 (binary)
            Console.WriteLine("Decimal a Binario: {0}", convertedBinary.Numero);

            double suma = numeroDecimal1 + numeroBinario1; // Suma decimal y binario
            Console.WriteLine("Suma de Decimal y Binario: {0}", suma);

            double resta = numeroDecimal1 - numeroBinario1; // Resta decimal y binario
            Console.WriteLine("Resta de Decimal y Binario: {0}", resta);

            bool sonIguales = numeroDecimal1 == numeroBinario1;
            Console.WriteLine($"¿Son iguales? {sonIguales}"); // Debería imprimir 'True' si la conversión y comparación son correctas

            // Probar el operador !=
            bool noSonIguales = numeroDecimal1 != numeroBinario1;
            Console.WriteLine($"¿No son iguales? {noSonIguales}"); // Debería imprimir 'False' si la conversión y comparación son correctas

        }
    }
}


*/