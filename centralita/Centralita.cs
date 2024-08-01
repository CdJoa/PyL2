using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
namespace BibliotecaCentralita
{
    public class Centralita : IGuardar<Centralita>
    {
        private List<Llamada> llamadas;
        private string razonSocial;

        public string RutaArchivo { get; set; }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.llamadas;
            }
        }

        // Propiedades para calcular las ganancias
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        private void AgregarLlamada(Llamada? nuevallamada)
        {
            if (nuevallamada != null)
            {
                this.llamadas.Add(nuevallamada);
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (var llamada in llamadas)
            {
                if (llamada is Local local)
                {
                    gananciaLocal += local.CostoLlamada;
                }
                else if (llamada is Provincial provincial)
                {
                    gananciaProvincial += provincial.CostoLlamada;
                }
            }

            return tipo switch
            {
                TipoLlamada.Local => gananciaLocal,
                TipoLlamada.Provincial => gananciaProvincial,
                TipoLlamada.Todas => gananciaLocal + gananciaProvincial,
                _ => 0
            };
        }

        public Centralita()
        {
            this.llamadas = new List<Llamada>();
            this.razonSocial = string.Empty;
        }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
            this.llamadas = new List<Llamada>();
        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n----------------------------------\n");
            sb.AppendFormat("Empresa: {0}\nGanancia total: {1:C}\nGanancia por llamados locales: {2:C}\nGanancia por llamados provinciales: {3:C}\n", this.razonSocial, GananciaPorTotal, GananciaPorLocal, GananciaPorProvincial);
            sb.AppendLine("\n|||Llamadas Realizadas|||\n");

            foreach (var llamada in Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            sb.AppendLine("\n|||Fin del historial de llamadas|||\n\n----------------------------------");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Centralita centralita = (Centralita)obj;
            return this.razonSocial == centralita.razonSocial && this.llamadas.SequenceEqual(centralita.llamadas);
        }

        public override int GetHashCode()
        {
            return this.razonSocial.GetHashCode() ^ this.llamadas.GetHashCode();
        }

        public static bool operator ==(Centralita? centralita, Llamada? llamada)
        {
            if (ReferenceEquals(centralita, null) || ReferenceEquals(llamada, null))
            {
                return false;
            }

            // Verificar si alguna llamada en la lista coincide con la nueva llamada
            foreach (Llamada l in centralita.Llamadas)
            {
                if (l == llamada)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita? centralita, Llamada? llamada)
        {
            return !(centralita == llamada);
        }

        public static Centralita operator +(Centralita centralita, Llamada llamada)
        {
            // Verificar si la llamada ya existe en la lista
            if (centralita == llamada)
            {
                // Lanzar excepción si ya existe
                throw new CentralitaException("La llamada ya está registrada en la centralita.", nameof(Centralita), "operator +");
            }

            try
            {
                centralita.Guardar();
            }
            catch (FallaLogException)
            {
                // Manejar la excepción si es necesario, pero continuar agregando la llamada
            }

            // Agregar la llamada si no existe
            centralita.AgregarLlamada(llamada);
            return centralita;
        }

        public void OrdenarLlamadas()
        {
            llamadas.Sort(Llamada.OrdernarPorDuracion);
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public bool Guardar()
        {
            try
            {
                string logEntry = $"{DateTime.Now:dddd dd MMMM yyyy HH:mm}hs – Se realizó una llamada";
                File.AppendAllText(RutaArchivo, logEntry + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Error al guardar en el archivo de log.", ex);
            }
        }

        public Centralita Leer()
        {
            try
            {
                string contenido = File.ReadAllText(RutaArchivo);

                return new Centralita(RutaArchivo);
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Error al leer el archivo de log.", ex);
            }
        }
    }
}


/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
using Encap;
using System;
using Herencia;
using BibliotecaCentralita;
using Polimorfismo;



class Program
{
    static void Main(string[] args)
    {
        // Mi central
        Centralita c = new Centralita("Fede Center");

        // Mis 4 llamadas
        Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
        Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
        Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
        Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

        // Las llamadas se irán registrando en la Centralita.
        // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
        c += l1;
        c += l2;
        c += l3;
        c += l4;

        // Ordenar llamadas
        c.OrdenarLlamadas();

        // Mostrar datos de Centralita una vez ordenadas
        Console.WriteLine(c.ToString());

        Console.ReadKey();
    }

}

-------------------centralita 1-----------------------------

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Centralita
    {
        private List<Llamada> llamadas;
        private string razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.llamadas;
            }
        }

        public Centralita()
        { }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
            this.llamadas = new List<Llamada>();
        }

        // Propiedades para calcular las ganancias
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (var llamada in llamadas)
            {
                if (llamada is Local local)
                {
                    gananciaLocal += local.CostoLlamada;
                }
                else if (llamada is Provincial provincial)
                {
                    gananciaProvincial += provincial.CostoLlamada;
                }
            }

            return tipo switch
            {
                TipoLlamada.Local => gananciaLocal,
                TipoLlamada.Provincial => gananciaProvincial,
                TipoLlamada.Todas => gananciaLocal + gananciaProvincial,
                _ => 0
            };
        }

        public void OrdenarLlamadas()
        {
            llamadas.Sort(Llamada.OrdernarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n----------------------------------\n");
            sb.AppendFormat("Empresa: {0}\nGanancia total: {1:C}\nGanancia por llamados locales: {2:C}\nGanancia por llamados provinciales: {3:C}\n", this.razonSocial, GananciaPorTotal, GananciaPorLocal, GananciaPorProvincial);
            sb.AppendLine("\n|||Llamadas Realizadas|||\n");

            foreach (var llamada in Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            sb.AppendLine("\n|||Fin del historial de llamadas|||\n\n----------------------------------");

            return sb.ToString();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Mi central
        Centralita c = new Centralita("Fede Center");

        // Mis 4 llamadas
        Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
        Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
        Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
        Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

        // Las llamadas se irán registrando en la Centralita.
        // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
        c.Llamadas.Add(l1);
        Console.WriteLine(c.Mostrar());
        c.Llamadas.Add(l2);
        Console.WriteLine(c.Mostrar());
        c.Llamadas.Add(l3);
        Console.WriteLine(c.Mostrar());
        c.Llamadas.Add(l4);
        Console.WriteLine(c.Mostrar());

        c.OrdenarLlamadas();
        Console.WriteLine(c.Mostrar());

        Console.ReadKey();
    }
}
*/