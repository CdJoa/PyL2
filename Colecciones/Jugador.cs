using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colecciones
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int totalGoles;

        // Constructor privado para inicializar los datos estadísticos del jugador en 0
        private Jugador()
        {
            dni = 0;
            nombre = "";
            partidosJugados = 0;
            promedioDeGoles = 0.0f;
            totalGoles = 0;
        }

        public float GetPromedioGoles()
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

        // Constructor público con parámetros
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles,int partidosJugados) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = partidosJugados;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del jugador:");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total de goles: {totalGoles}");
            sb.AppendLine($"Promedio de goles: {GetPromedioGoles()}");

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
            return nombre;
        }
    }
}
