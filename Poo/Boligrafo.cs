namespace Poo
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private bool ValidarTinta(short cantidad)
        {
            return cantidad >= 0 && cantidad <= cantidadTintaMaxima;
        }

        private void SetTinta(short cantidad)
        {
            if (ValidarTinta(cantidad))
            {
                tinta = cantidad;
            }
        }

        public void CargarTinta(short cantidad)
        {
            SetTinta((short)(tinta + cantidad));
        }

        public void GastarTinta(short cantidad)
        {
            SetTinta((short)(tinta - cantidad));
        }

        public void Recargar()
        {
            CargarTinta((short)(cantidadTintaMaxima - tinta));
        }

        public string Pintar(short gasto)
        {
            if (tinta <= 0)
            {
                return ""; // Retorna cadena vacía si no hay tinta disponible
            }

            short tintaGastada = Math.Min(gasto, tinta); // Utiliza la menor cantidad entre el gasto y la tinta disponible
            GastarTinta(tintaGastada); // Gastar la tinta utilizada

            return new string('*', tintaGastada); // Retorna una cadena de asteriscos representando la tinta gastada
        }
    }
}

/*using System;
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
*/