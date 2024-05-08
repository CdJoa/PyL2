using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Colecciones
{
    public class Jugador
    {
        private int dni;
        private int partidosJugados;
        private int totalGoles;
        private string nombre;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PartidosJugados => partidosJugados; // Propiedad de sólo lectura


        public float PromedioDeGoles
        {
            get
            {
                if (partidosJugados == 0)
                {
                    return 0;
                }
                else
                {
                    return (float)totalGoles / partidosJugados;
                }
            }
        }

        public int TotalGoles => totalGoles; // Propiedad de sólo lectura


        private Jugador()
        {
            dni = 0;
            partidosJugados = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this()
        {
            this.dni = dni;
            this.Nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del jugador:");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total de goles: {totalGoles}");
            sb.AppendLine($"Promedio de goles: {PromedioDeGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
