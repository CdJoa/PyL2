using System;
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
using tiposGenericos;
using Delegados;
using HilosYEventos;
using System;

class Program
{
    static async Task Main(string[] args)
    {
        List<Llamada> llamadas = new List<Llamada>();
        SimuladorLlamadas simulador = new SimuladorLlamadas(llamadas);

        Console.WriteLine("Iniciando simulación de llamadas...");
        Task simulacion = simulador.IniciarSimulacion();

        Console.WriteLine("Presiona cualquier tecla para detener la simulación...");
        Console.ReadKey();

        simulador.DetenerSimulacion();
        await simulacion;

        Console.WriteLine("Simulación detenida. Llamadas generadas:");
        foreach (var llamada in llamadas)
        {
            Console.WriteLine(llamada.MostrarDatos());
        }
    }
}
