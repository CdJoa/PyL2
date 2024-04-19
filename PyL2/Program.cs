using System;
using BibliotecaDeClases;
using Calculadora;
using Poo;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un bolígrafo de tinta azul con 100 de tinta inicial
        Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);

        // Crear un bolígrafo de tinta roja con 50 de tinta inicial
        Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

        // Mostrar información inicial
        Console.WriteLine($"Bolígrafo azul - Color: {boligrafoAzul.GetColor()}, Tinta: {boligrafoAzul.GetTinta()}");
        Console.WriteLine($"Bolígrafo rojo - Color: {boligrafoRojo.GetColor()}, Tinta: {boligrafoRojo.GetTinta()}");
        
        boligrafoRojo.GastarTinta(80);

        boligrafoRojo.CargarTinta(20);
        boligrafoRojo.Recargar();
        string dibujo = boligrafoRojo.Pintar(40);

        // Mostrar resultados después de las operaciones
        Console.WriteLine($"Bolígrafo azul - Tinta después de cargar: {boligrafoAzul.GetTinta()}");
        Console.WriteLine($"Bolígrafo rojo - Tinta después de gastar: {boligrafoRojo.GetTinta()}");
        Console.WriteLine($"Dibujo con el bolígrafo rojo: {dibujo}");

        // Esperar a que el usuario presione una tecla para salir
        Console.ReadKey();
    }
}
