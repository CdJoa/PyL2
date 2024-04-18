using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDeClases
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor<=max)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        int contador = 0;
        int numMin = 0;
        int numMax = 0;
        int sumaTotal = 0;

        int[] numeros = new int[10]; // Array para almacenar los 10 números

        do
        {
            Console.Write("Introduce un número ({0}/10): ", contador + 1);
            int numeroIngresado = int.Parse(Console.ReadLine());
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
                sumaTotal +=numeroIngresado;
                contador++;
                }
            else
            {
                Console.WriteLine("¡Error! El número entero debe ser validado");
            }
        } while (contador < 10);
        Console.WriteLine("Validaste 10 numeros");

    }
}
*/