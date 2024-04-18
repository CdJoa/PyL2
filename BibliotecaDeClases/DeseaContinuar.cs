using System;

namespace BibliotecaDeClases
{
    public static class DeseaContinuar
    {
        public static bool Preguntar()
        {
            while (true)
            {
                Console.Write("¿Desea continuar? (S/N): ");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta == "N")
                {
                    return false;
                }
                else if (respuesta == "S")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Respuesta inválida. Por favor, ingrese 'S' para continuar o 'N' para detenerse.");
                }
            }
        }
    }
}

/*<#@ template debug="false" hostspecific="using System;

using BibliotecaDeClases;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            int contador = 0;
            int numMin = 0;
            int numMax = 0;
            int sumaTotal = 0;

            int[] numeros = new int[10]; // Array para almacenar los 10 números

            do
            {
                Console.Write("Introduce un número ({0}/10): ", contador + 1);
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    if (Validador.Validar(numeroIngresado, -100, 100))
                    {
                        if (contador == 0)
                        {
                            numMin = numeroIngresado;
                            numMax = numeroIngresado;
                        }
                        else
                        {
                            if (numeroIngresado > numMax)
                            {
                                numMax = numeroIngresado;
                            }
                            if (numeroIngresado < numMin)
                            {
                                numMin = numeroIngresado;
                            }
                        }
                        sumaTotal += numeroIngresado;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("¡Error! El número entero debe estar dentro del rango de -100 a 100.");
                    }
                }
                else
                {
                    Console.WriteLine("¡Error! Debes ingresar un número entero.");
                }
            } while (contador < 10);

            Console.WriteLine("El número mínimo es: " + numMin);
            Console.WriteLine("El número máximo es: " + numMax);
            Console.WriteLine("La suma total de los números es: " + sumaTotal);

        } while (DeseaContinuar.Preguntar());

        Console.WriteLine("Fin del programa.");
    }
}
*/