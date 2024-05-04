namespace Colecciones
{
    /* collecciones, ejercicio 2, numeros locos*/


    class Program2
    {
        static void Main(string[] args)
        {
            // Declaración de las estructuras de datos
            List<int> lista = new List<int>(); // Lista para almacenar los números enteros
            Queue<int> colaPos = new Queue<int>(); // Cola para almacenar los números positivos
            Stack<int> pilaPos = new Stack<int>(); // Pila para almacenar los números positivos
            Queue<int> colaNeg = new Queue<int>(); // Cola para almacenar los números negativos
            Stack<int> pilaNeg = new Stack<int>(); // Pila para almacenar los números negativos

            // Generación aleatoria de 20 números enteros distintos de cero
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                int numero = r.Next(-100, 101); // Genera un número aleatorio entre -100 y 100 (incluidos)
                if (numero != 0 && !lista.Contains(numero)) // Verifica que el número no sea cero y no esté duplicado
                {
                    lista.Add(numero); // Agrega el número a la lista
                }
                else
                {
                    i--; // Intenta generar otro número válido
                }
            }

            // Muestra la lista original
            Console.WriteLine("Lista Original");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            // Ordena la lista en forma ascendente y la muestra
            lista.Sort();
            Console.WriteLine("Lista Ordenada Ascendente");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            // Ordena la lista en forma decreciente y muestra los números positivos
            lista.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("Lista Positivos Ordenados en Forma Decreciente");
            foreach (int num in lista)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                    colaPos.Enqueue(num); // Agrega el número positivo a la cola de positivos
                }
                else if (num < 0)
                {
                    pilaNeg.Push(num); // Agrega el número negativo a la pila de negativos
                }
            }

            // Muestra los números negativos ordenados en forma creciente
            Console.WriteLine("Lista Negativos Ordenados en Forma Creciente");
            foreach (int num in lista)
            {
                if (num < 0)
                {
                    Console.WriteLine(num);
                    colaNeg.Enqueue(num); // Agrega el número negativo a la cola de negativos
                }
                else if (num > 0)
                {
                    pilaPos.Push(num); // Agrega el número positivo a la pila de positivos
                }
            }

            // Muestra los números almacenados en la cola de positivos
            Console.WriteLine("Cola Positivos");
            foreach (int num in colaPos)
            {
                Console.WriteLine(num);
            }

            // Muestra los números almacenados en la pila de positivos
            Console.WriteLine("Pila Positivos");
            foreach (int num in pilaPos)
            {
                Console.WriteLine(num);
            }

            // Muestra los números almacenados en la cola de negativos
            Console.WriteLine("Cola Negativos");
            foreach (int num in colaNeg)
            {
                Console.WriteLine(num);
            }

            // Muestra los números almacenados en la pila de negativos
            Console.WriteLine("Pila Negativos");
            foreach (int num in pilaNeg)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey(); // Espera a que se presione una tecla antes de salir
        }
    }
}
