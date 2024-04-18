using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{
    public class Factorial
    {
        // Método para calcular el factorial de un número entero
        public static long CalcularFactorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentOutOfRangeException("El número debe ser no negativo.");
            }

            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i; // Multiplicación sucesiva para calcular el factorial
            }
            return resultado;
        }
    }
}
