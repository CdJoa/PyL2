namespace BibliotecaDeClases
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            if (numeroEntero == 0)
            {
                return "0";
            }

            string binario = "";
            while (numeroEntero > 0)
            {
                int residuo = numeroEntero % 2;
                binario = residuo + binario;
                numeroEntero /= 2;
            }

            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroBinario)
        {
            int numeroDecimal = 0;
            int potencia = 0;

            while (numeroBinario != 0)
            {
                int digito = numeroBinario % 10;
                numeroDecimal += digito * (int)Math.Pow(2, potencia);
                numeroBinario /= 10;
                potencia++;
            }

            return numeroDecimal;
        }
    }
}
/*
using System;
using BibliotecaDeClases;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de conversión de decimal a binario
        int decimalEjemplo = 10;
        string binario = Conversor.ConvertirDecimalABinario(decimalEjemplo);
        Console.WriteLine($"El número {decimalEjemplo} en binario es: {binario}");

        // Ejemplo de conversión de binario a decimal
        int binarioEjemplo = 11101;
        int decimalResultado = Conversor.ConvertirBinarioADecimal(binarioEjemplo);
        Console.WriteLine($"El número binario {binarioEjemplo} en decimal es: {decimalResultado}");
    }
}

*/