using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string message) : base(message) { }
        public UnaExcepcion(string message, Exception inner) : base(message, inner) { }
    }
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) : base(message) { }
    }

    public class MiExcepcion : Exception
    {
        public MiExcepcion(string message) : base(message) { }
        public MiExcepcion(string message, Exception inner) : base(message, inner) { }
    }

    // Paso 2: Crear la clase MiClase con un método estático y dos constructores de instancia
    public class MiClase
    {
        public static void MetodoEstatico()
        {
            // Paso 3: Lanzar una excepción DivideByZeroException en el método estático
            throw new DivideByZeroException("División por cero en el método estático.");
        }

        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (DivideByZeroException ex)
            {
                // Paso 4: Capturar la excepción y relanzarla
                throw new DivideByZeroException("Excepción capturada y relanzada en el primer constructor.", ex);
            }
        }

        public MiClase(int dummyParameter)
        {
            try
            {
                // Paso 5: Instanciar otro objeto de MiClase y capturar la excepción
                new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                // Crear una excepción propia UnaExcepcion y almacenarla en InnerException
                throw new UnaExcepcion("Excepción en el segundo constructor de MiClase.", ex);
            }
        }
    }

    // Paso 6: Crear la clase OtraClase con un método de instancia
    public class OtraClase
    {
        public void MetodoDeInstancia()
        {
            try
            {
                // Instanciar un objeto de MiClase y capturar la excepción
                new MiClase(42);
            }
            catch (UnaExcepcion ex)
            {
                // Generar una excepción propia MiExcepcion y lanzarla
                throw new MiExcepcion("Excepción capturada en OtraClase.", ex);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Paso 7: Capturar MiExcepcion en el método Main
                OtraClase otraClase = new OtraClase();
                otraClase.MetodoDeInstancia();
            }
            catch (MiExcepcion ex)
            {
                // Mostrar el mensaje de error y los mensajes de las excepciones almacenadas en InnerException
                Console.WriteLine($"Error: {ex.Message}");
                Exception inner = ex.InnerException;
                while (inner != null)
                {
                    Console.WriteLine($"Inner Exception: {inner.Message}");
                    inner = inner.InnerException;
                }
            }
        }
    }


}
