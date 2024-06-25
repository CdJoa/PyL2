using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HilosYEventos
{
    public class NegocioH
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<CajaH> cajas;

        static NegocioH()
        {
            realNameGenerator = new RealNameGenerator();
        }

        public NegocioH(List<CajaH> cajas)
        {
            this.cajas = cajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();
            hilos.AddRange(AbrirCajas());


            hilos.Add(Task.Run(GenerarClientes));
            hilos.Add(Task.Run(AsignarCajas));

            return hilos;
        }

        private List<Task> AbrirCajas()
        {
            List<Task> hilos = new List<Task>();

            foreach (CajaH caja in cajas)
            {
                hilos.Add(caja.IniciarAtencion());
            }

            return hilos;
        }

        private void GenerarClientes()
        {
            do
            {
                clientes.Enqueue(realNameGenerator.Generate());
                Thread.Sleep(1000);
            } while (true);
        }

        private void AsignarCajas()
        {
            do
            {
                CajaH caja = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);
                }
            } while (true);
        }
    }
}
