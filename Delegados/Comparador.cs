using System;
using System.Collections.Generic;

namespace Delegados
{
    public delegate int DelegadoComparacionTextos(string txt1, string txt2);

    public class Comparador
    {
        public static int ContarVocales(string texto)
        {
            List<char> vocales = new List<char>()
            {
                'a', 'á', 'A', 'Á', 'e', 'é', 'E', 'É',
                'i', 'í', 'I', 'Í', 'o', 'ó', 'O', 'Ó',
                'u', 'ú', 'U', 'Ú'
            };

            return ContarCaracteres(texto, vocales);
        }

        public static int ContarSignosPuntuacion(string texto)
        {
            List<char> signosPuntuacion = new List<char>()
            {
                '.', ';', ','
            };

            return ContarCaracteres(texto, signosPuntuacion);
        }

        public static int ContarCaracteres(string texto, List<char> caracteres)
        {
            int cantidadCaracteres = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    cantidadCaracteres++;
                }
            }

            return cantidadCaracteres;
        }

        public static void Comparar(string txt1, string txt2, DelegadoComparacionTextos delegado)
        {
            int resultado = delegado(txt1, txt2);

            if (resultado > 0)
            {
                Console.WriteLine("El primer texto es mayor al segundo.");
            }
            else if (resultado < 0)
            {
                Console.WriteLine("El primer texto es menor al segundo.");
            }
            else
            {
                Console.WriteLine("Los textos son iguales en cantidad.");
            }
        }

        public static int ContarPalabras(string texto)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }
    }
}
