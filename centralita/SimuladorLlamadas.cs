using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class SimuladorLlamadas
    {
        private List<Llamada> llamadas;
        private Random random;
        private bool simulando;

        public SimuladorLlamadas(List<Llamada> llamadas)
        {
            this.llamadas = llamadas;
            this.random = new Random();
            this.simulando = false;
        }

        public async Task IniciarSimulacion()
        {
            simulando = true;
            while (simulando)
            {
                await Task.Delay(random.Next(1000, 5000)); // Intervalo aleatorio entre 1 y 5 segundos
                GenerarLlamada();
            }
        }

        public void DetenerSimulacion()
        {
            simulando = false;
        }

        private void GenerarLlamada()
        {
            int tipoLlamada = random.Next(0, 2); // 0 para Local, 1 para Provincial
            Llamada nuevaLlamada;

            if (tipoLlamada == 0)
            {
                nuevaLlamada = new Local(
                    origen: GenerarNumeroTelefono(),
                    duracion: random.Next(1, 60), // Duración entre 1 y 60 minutos
                    destino: GenerarNumeroTelefono(),
                    costo: (float)(random.NextDouble() * 10) // Costo entre 0 y 10
                );
            }
            else
            {
                nuevaLlamada = new Provincial(
                    origen: GenerarNumeroTelefono(),
                    miFranja: (Provincial.Franja)random.Next(0, 3), // Franja aleatoria
                    duracion: random.Next(1, 60), // Duración entre 1 y 60 minutos
                    destino: GenerarNumeroTelefono()

                );
            }

            llamadas.Add(nuevaLlamada);
            Console.WriteLine($"Nueva llamada agregada: {nuevaLlamada}");
        }

        private string GenerarNumeroTelefono()
        {
            return $"{random.Next(100, 1000)}-{random.Next(1000, 10000)}";
        }
    }
}
