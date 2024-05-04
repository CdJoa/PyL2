namespace Colecciones
{
    /* collecciones, ejercicio 1, numeros locos*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random rdn = new Random();

            for (int i = 0; i < arrayNumeros.Length; i++) // Itera sobre el arrayNumeros
            { // Inicio del bloque del ciclo for
                arrayNumeros[i] = rdn.Next(-100, 100); // Llena arrayNumeros con números aleatorios en el rango de -100 a 99
            }
            Console.WriteLine("Array original");
            for (int i = 0; i < arrayNumeros.Length; i++) // Itera sobre el arrayNumeros
            {
                Console.WriteLine("{0} : {1}", i, arrayNumeros[i]);
            }

            Console.WriteLine("positivos ordenados en forma decreciente.");
            Array.Sort(arrayNumeros, (n1, n2) => n2.CompareTo(n1)); // Ordena los números positivos en arrayNumeros en orden descendente utilizando una función lambda
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > 0) // Verifica si el número en la posición i es positivo
                    Console.WriteLine("{0} : {1}", i, arrayNumeros[i]); // Imprime el número positivo
            } // Fin del bloque del ciclo for

            Console.WriteLine("negativos ordenados en forma creciente.");
            Array.Sort(arrayNumeros); // Ordena los números negativos en arrayNumeros en orden ascendente (por defecto)
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < 0)
                    Console.WriteLine("{0} : {1}", i, arrayNumeros[i]); // Imprime el número negativo
            }
        }
    }

}
