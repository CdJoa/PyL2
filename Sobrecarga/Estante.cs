using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Estante
    {
        private Producto[] productos; // Arreglo para almacenar los productos en el estante
        private int ubicacion; // Ubicación del estante

        // Constructor privado que inicializa el arreglo de productos con una capacidad dada
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        // Constructor público que inicializa el arreglo de productos con una capacidad dada y asigna la ubicación del estante
        public Estante(int capacidad, int ubicacion)
            : this(capacidad) // Llama al constructor privado para inicializar el arreglo de productos
        {
            this.ubicacion = ubicacion; // Asigna la ubicación del estante
        }

        // Método para obtener los productos del estante
        public Producto[] GetProductos()
        {
            return productos;
        }

        // Sobrecarga del operador de igualdad (==) para verificar si un producto está en el estante
        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    return true; // Retorna verdadero si el producto está en el estante
                }
            }
            return false; // Retorna falso si el producto no está en el estante
        }

        // Sobrecarga del operador de desigualdad (!=) para verificar si un producto no está en el estante
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p); // Retorna el inverso del resultado de la sobrecarga del operador de igualdad
        }

        // Sobrecarga del operador + para agregar un producto al estante
        public static bool operator +(Estante e, Producto p)
        {
            if (e != p) // Verifica si el producto no está en el estante
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], null)) // Verifica si la posición del arreglo está vacía
                    {
                        e.productos[i] = p; // Agrega el producto al estante
                        return true; // Retorna verdadero si se agregó el producto al estante
                    }
                }
            }
            return false; // Retorna falso si no se pudo agregar el producto al estante
        }

        // Sobrecarga del operador - para quitar un producto del estante
        public static bool operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p) // Verifica si el producto está en el estante
                {
                    e.productos[i] = null; // Quita el producto del estante
                    return true; // Retorna verdadero si se quitó el producto del estante
                }
            }
            return false; // Retorna falso si no se pudo quitar el producto del estante
        }

        // Método estático para mostrar el contenido del estante
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{e.ubicacion}"); // Agrega la ubicación del estante al resultado final
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!(e.productos[i] is null)) // Verifica si la posición del arreglo contiene un producto
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i])); // Agrega la representación del producto al resultado final
                }
            }
            return sb.ToString(); // Retorna el contenido completo del estante
        }
    }
}

/*using System;
using Sobrecarga;
class Program
{
    static void Main(string[] args)
    {
        Estante estante = new Estante(3, 1);

        // Creo 4 productos
        Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
        Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
        Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
        Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);

        // Agrego los productos al estante
        if (estante + p1)
        {
            Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
        }
        else
        {
            Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
        }

        if (estante + p1)
        {
            Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
        }
        else
        {
            Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
        }

        if (estante + p2)
        {
            Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
        }
        else
        {
            Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
        }

        if (estante + p3)
        {
            Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
        }
        else
        {
            Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
        }

        if (estante + p4)
        {
            Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
        }
        else
        {
            Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
        }

        // Muestro todo el estante
        Console.WriteLine();
        Console.WriteLine("<------------------------------------------------->");
        Console.WriteLine(Estante.MostrarEstante(estante));


    }
}*/