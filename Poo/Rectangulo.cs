using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Rectangulo
    {
        private float? area; // Usamos Nullable<float> para permitir el valor nulo
        private float? perimetro; // Usamos Nullable<float> para permitir el valor nulo
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;

            // Calcular los vértices 2 y 4
            // Vértice 2: Misma coordenada Y que vertice1, misma coordenada X que vertice3
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            // Vértice 4: Misma coordenada Y que vertice3, misma coordenada X que vertice1
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }

        public float ObtenerArea()
        {
            if (this.area == null)
            {
                CalcularArea();
            }
            return this.area ?? 0; 
        }

        public float ObtenerPerimetro()
        {
            if (this.perimetro == null)
            {
                CalcularPerimetro();
            }
            return this.perimetro ?? 0;
        }


        private void CalcularArea()
        {
            float ancho = Math.Abs(vertice2.GetX() - vertice1.GetX());
            float largo = Math.Abs(vertice4.GetY() - vertice1.GetY());
            area = ancho * largo;
        }

        private void CalcularPerimetro()
        {
            float ancho = Math.Abs(vertice2.GetX() - vertice1.GetX());
            float largo = Math.Abs(vertice4.GetY() - vertice1.GetY());
            perimetro = 2 * (ancho + largo);
        }
    }
}
/*
 using System;
using BibliotecaDeClases;
using Calculadora;
using Poo;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar un nuevo Punto
        Punto punto1 = new Punto(1, 3);
        Punto punto2 = new Punto(5, 8);

        // Instanciar un nuevo Rectangulo
        Rectangulo rectangulo = new Rectangulo(punto1, punto2);

        // Imprimir área y perímetro del rectángulo
        Console.WriteLine("Área del rectángulo: " + rectangulo.ObtenerArea());
        Console.WriteLine("Perímetro del rectángulo: " + rectangulo.ObtenerPerimetro());


    }



}*/