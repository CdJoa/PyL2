namespace Calculadora
{
    public class Decimal
    {
        public static float Sumar(float numeroUno, float numeroDos)
        {
            var suma = numeroUno + numeroDos;
            return suma;
        }
        public static float Restar(float numeroUno, float numeroDos)
        {
            var resta = numeroUno - numeroDos;

            return resta;
        }
        public static float Multiplicar(float numeroUno, float numeroDos)
        {
            var multiplicacion = numeroUno * numeroDos;
            return multiplicacion;
        }
        public static float Dividir(float numeroUno, float numeroDos)
        {
            if (Validar(numeroDos))
            {
                return numeroUno / numeroDos;
            }
            else
            {
                throw new ArgumentException("El segundo operando no puede ser cero.");
            }
        }
        private static bool Validar(float numero)
        {
            return numero != 0;
        }
    }

}




/*
 using System;
using BibliotecaDeClases;
using Calculadora;

using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        do
        {
            try
            {
                Console.Write("Ingrese el primer número: ");
                float num1 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                float num2 = float.Parse(Console.ReadLine());

                Console.Write("Ingrese la operación (+, -, *, /): ");
                char operacion = char.Parse(Console.ReadLine());

                float resultado = 0;

                switch (operacion)
                {
                    case '+':
                        resultado = Calculadora.@decimal.Sumar(num1, num2);
                        break;
                    case '-':
                        resultado = Calculadora.@decimal.Restar(num1, num2);
                        break;
                    case '*':
                        resultado = Calculadora.@decimal.Multiplicar(num1, num2);
                        break;
                    case '/':
                        resultado = Calculadora.@decimal.Dividir(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Operación no válida.");
                        continue; // Volver al inicio del bucle
                }

                Console.WriteLine("El resultado de la operación es: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debes ingresar un número válido.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            continuar = DeseaContinuar.Preguntar();
        } while (continuar);

        Console.WriteLine("Fin del programa.");
    }
}
*/
