namespace BibliotecaDeClases
{
    public static class Conversor
    {

        public static string DecimalABinario(double numeroEntero)
        {
            if (numeroEntero == 0)
            {
                return "0";
            }

            string binario = "";
            int parteEntera = Math.Abs((int)numeroEntero);
            int resto;

            while (parteEntera != 0)
            {
                resto = parteEntera % 2;
                parteEntera = parteEntera / 2;
                binario = resto.ToString() + binario;
            }

            if (numeroEntero < 0)
            {
                binario = "-" + binario;
            }

            return binario;
        }



        public static double BinarioADecimal(string numeroString)
        {
            double enteroConvertido = 0;
            double exponente = 0;
            double signo;

            if (numeroString[0] == '-')
            {
                numeroString = numeroString.Substring(1);
                signo = -1;
            }
            else
            {
                signo = 1;
            }

            for (int i = numeroString.Length - 1; i >= 0; i--)
            {
                char digitoChar = numeroString[i];
                double digito = double.Parse(digitoChar.ToString());
                enteroConvertido += digito * (double)Math.Pow(2, exponente);
                exponente++;
            }
            return enteroConvertido * signo;
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