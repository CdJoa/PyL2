namespace Poo
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return this.fechaDeNacimiento; }
            set { this.fechaDeNacimiento = value; }
        }

        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            // Si aún no ha pasado su cumpleaños este año, se resta 1 año
            if (fechaDeNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            int edad = CalcularEdad();
            return $"Nombre: {nombre}, Fecha de nacimiento: {fechaDeNacimiento.ToShortDateString()}, DNI: {dni}, Edad: {edad}";
        }

        // Método para determinar si la persona es mayor de edad
        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            return edad >= 18 ? "Es mayor de edad" : "Es menor de edad";
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
        { 
            // Crear una instancia de Persona
            Persona persona1 = new Persona("Juan", new DateTime(2220, 5, 15), "12345678");

            // Mostrar los datos de la persona
            Console.WriteLine("Datos de la persona:");
            Console.WriteLine(persona1.Mostrar());

            // Determinar si la persona es mayor de edad
            Console.WriteLine("\nEstado de la persona:");
            Console.WriteLine(persona1.EsMayorDeEdad());

            // Modificar el nombre de la persona
            persona1.Nombre = "Pedro";

            // Mostrar los datos actualizados de la persona
            Console.WriteLine("\nDatos actualizados de la persona:");
            Console.WriteLine(persona1.Mostrar());
        }
    }
}
*/