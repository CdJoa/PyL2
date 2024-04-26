using System.Text;

namespace BibliotecaDeClases
{
    public static class TablaMultiplicar
    {
        public static string Generar(int numero)
        {
            StringBuilder tabla = new StringBuilder();

            tabla.AppendLine($"Tabla de multiplicar del {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                tabla.AppendLine($"{numero} x {i} = {numero * i}");
            }

            return tabla.ToString();
        }
    }
}

/*
using System;
using Calculadora;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            string tabla = TablaMultiplicar.Generar(numero);
            Console.WriteLine(tabla);
        }
        else
        {
            Console.WriteLine("Error: Debes ingresar un número entero válido.");
        }
    }
}
*/