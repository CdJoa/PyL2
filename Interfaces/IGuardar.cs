using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IGuardar<T>
    {
        string RutaArchivo { get; set; }
        public bool Guardar()
        {
            // Consultar todos los datos del objeto y guardarlos
            Console.WriteLine("Guardando datos del objeto...");
            // Código para guardar los datos del objeto
            Console.WriteLine("Datos guardados exitosamente.");
            return true;
        }
        T Leer();
    }
}


