using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;
              
        }  
        
        public string GetMarca() {  return marca; }
        public float GetPrecio() { return precio; }

        public static explicit operator string(Producto p) 
        { return p.codigoDeBarra; }

        public static bool operator ==(Producto p1 , Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;

            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return p1!= p2;
        }
        public static bool operator ==(Producto p1, string marca)
        {
            return p1.marca == marca;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }
        public static string MostrarProducto(Producto p)
        {
            return $"Codigo: {p.codigoDeBarra} Marca: {p.marca}  Precio: {p.precio.ToString("0.00")} ";
        }
    }
}
