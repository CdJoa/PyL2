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
class Program
{
    public delegate int DelegadoComparacion(string primerTexto, string segundoTexto);

    static void Main(string[] args)
    {
        CajaH.DelegadoClienteAtendido delegadoClienteAtendido = (caja, cliente) =>
        {
            Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja.");
        };

        CajaH caja1 = new CajaH("Caja 01", delegadoClienteAtendido);
        CajaH caja2 = new CajaH("Caja 02", delegadoClienteAtendido);

        List<CajaH> cajas = new List<CajaH>()
        {
            caja1,
            caja2
        };

        NegocioH negocio = new NegocioH(cajas);

        Console.WriteLine("Asignando cajas...");

        List<Task> hilos = negocio.ComenzarAtencion();
        Task.WaitAll(hilos.ToArray());
    }
}