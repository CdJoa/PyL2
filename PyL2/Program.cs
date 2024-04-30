using System;
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


