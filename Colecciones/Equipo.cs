using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            cantidadDeJugadores = 0;
            nombre = "";
            jugadores = new List<Jugador>();

        }
        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            // Verificar si el jugador ya está en la lista del equipo
            if (e.jugadores.Contains(j))
            {
                Console.WriteLine("El jugador ya está en el equipo.");
                return e;
            }

            // Verificar si la cantidad de jugadores no supera el límite
            if (e.jugadores.Count >= e.cantidadDeJugadores)
            {
                Console.WriteLine("El equipo ya tiene la cantidad máxima de jugadores.");
                return e;
            }

            // Agregar el jugador a la lista del equipo
            e.jugadores.Add(j);
            Console.WriteLine($"El jugador {j.ObtenerNombre()} ha sido agregado al equipo.");
            return e;
        }
        public string ObtenerNombre()
        {
            return nombre;
        }
        public IEnumerator<Jugador> GetEnumerator()
        {
            foreach (var jugador in jugadores)
            {
                yield return jugador;
            }
        }

    }

}
/*
class Program
    {
        static void Main(string[] args)
        {
            // Crear un equipo
            Equipo equipo = new Equipo(8,"Equipo A");

            // Crear jugadores
            Jugador jugador1 = new Jugador(1, "Jugador 1");
            Jugador jugador2 = new Jugador(2, "Jugador 2", 15, 7);
            Jugador jugador3 = new Jugador(3, "Jugador 3", 20, 10);

            // Agregar jugadores al equipo
            equipo = equipo + jugador1;
            equipo = equipo + jugador2;
            equipo = equipo + jugador3;

        // Mostrar datos del equipo y sus jugadores
        Console.WriteLine($"Nombre del equipo: {equipo.ObtenerNombre()}");
        Console.WriteLine("Jugadores del equipo:");
            foreach (Jugador jugador in equipo)
            {
                Console.WriteLine(jugador.MostrarDatos());
            }
        }
    }

*/