using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap
{
    public class PuestoDeAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        static PuestoDeAtencion()
        {
            PuestoDeAtencion.numeroActual = 0;
        }
        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }
        public bool Atender(ClienteE cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}



