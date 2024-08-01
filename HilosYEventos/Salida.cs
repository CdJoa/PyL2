using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilosYEventos
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public DateTime FechaFin
        {
            get
            {
                return fechaFin;
            }
            set
            {
                fechaFin = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }
            set
            {
                fechaInicio = value;
            }
        }

        public double TiempoTotal
        {
            get
            {
                return fechaInicio.CalcularDiferenciaEnSegundos(fechaFin);
            }
        }

        public Salida()
        {
            fechaInicio = DateTime.Now;
        }

        public void FinalizarSalida()
        {
            fechaFin = DateTime.Now;
        }
    }
}
