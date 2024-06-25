using static HilosYEventos.CajaH;

namespace HilosYEventos
{
    public class CajaH
    {
        private static Random random;
        private Queue<string> clientesALaEspera;
        private string nombreCaja;

        public int CantidadDeClientesALaEspera => clientesALaEspera.Count;

        public string NombreCaja => nombreCaja;

        static CajaH()
        {
            random = new Random();
        }
        public CajaH(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;

        }

        public delegate void DelegadoClienteAtendido(CajaH caja, string cliente);

        private DelegadoClienteAtendido delegadoClienteAtendido;


        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }
        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }
        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera.Any())
                {
                    string cliente = clientesALaEspera.Dequeue();
                    delegadoClienteAtendido.Invoke(this, cliente);
                    Thread.Sleep(random.Next(3000, 5000));
                }
            } while (true);
        }
    }
}
