using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class CuentaBancaria
    {
        private string titular;
        private decimal cantidad;

        public CuentaBancaria(string razonSocial, decimal monto)
        {
            this.titular = razonSocial;
            this.cantidad = monto;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine($"Se ingresaron {monto:C} a la cuenta.");
                mensaje.AppendLine($"Nuevo saldo: {this.cantidad:C}");
                Console.WriteLine(mensaje.ToString());
            }
            else
            {
                Console.WriteLine("El monto a ingresar debe ser positivo");
            }
        }

        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
                StringBuilder mensaje = new StringBuilder();
                mensaje.AppendLine($"Se retiraron {monto:C} de la cuenta.");
                mensaje.AppendLine($"Nuevo saldo: {this.cantidad:C}");
                Console.WriteLine(mensaje.ToString());
            }
            else
            {
                Console.WriteLine("El monto a retirar debe ser positivo");
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.titular}");
            sb.AppendLine($"Saldo: {this.cantidad:C}");
            return sb.ToString();
        }
    }
}

/*class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta = new CuentaBancaria("John Doe", 1000);

        // Mostrar los datos iniciales de la cuenta
        Console.WriteLine("Datos iniciales de la cuenta:");
        Console.WriteLine(cuenta.Mostrar());

        // Realizar operaciones
        cuenta.Ingresar(500);
        cuenta.Retirar(200);

        // Mostrar saldo después de las operaciones
        Console.WriteLine("Saldo después de las operaciones:");
        Console.WriteLine(cuenta.Mostrar());

        Console.ReadLine();

    }
}
*/