namespace Calculadora
{
    public class Factorial
    {
        public static long CalcularFactorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentOutOfRangeException("El número debe ser no negativo.");
            }

            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
