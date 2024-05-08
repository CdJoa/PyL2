using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
using Encap;


using System;


class Program
{
    static void Main(string[] args)
    {
        // Crear un equipo
        Equipo equipo = new Equipo(8, "Equipo A");

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



