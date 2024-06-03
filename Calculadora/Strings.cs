using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Strings
    {
        public int Add(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            string[] delimiters = new string[] { ",", "\n" };

            // Check for custom delimiter
            if (numeros.StartsWith("//"))
            {
                int delimiterEndIndex = numeros.IndexOf('\n');
                if (delimiterEndIndex != -1)
                {
                    string customDelimiter = numeros.Substring(2, delimiterEndIndex - 2);
                    delimiters = new string[] { customDelimiter };
                    numeros = numeros.Substring(delimiterEndIndex + 1);
                }
            }

            string[] numerosArray = numeros.Split(delimiters, StringSplitOptions.None);

            // Check for negatives
            var negativos = numerosArray.Where(n => int.TryParse(n, out int num) && num < 0).ToArray();
            if (negativos.Any())
            {
                throw new NegativoNoPermitidoException($"Negativos no permitidos: {string.Join(", ", negativos)}");
            }

            int sum = 0;
            foreach (string numero in numerosArray)
            {
                if (int.TryParse(numero, out int num))
                {
                    sum += num;
                }
            }

            return sum;
        }
    }

    public class NegativoNoPermitidoException : Exception
        {
            public NegativoNoPermitidoException(string message) : base(message)
            {
            }
        }

}
