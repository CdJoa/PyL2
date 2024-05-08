using Encapsulamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Negocio
    {
        private PuestoDeAtencion caja;
        private Queue<ClienteE> clientes;
        private string nombre;

        private Negocio()
        {
            this.clientes = new Queue<ClienteE>();
            this.caja = new PuestoDeAtencion(PuestoDeAtencion.Puesto.Caja1);
        }
        public Negocio(string nombre)
            : this()
        {
            this.nombre = nombre;
        }



        public ClienteE Cliente
        {
            get { return clientes.Dequeue(); }
            set { _ = this + value; }
        }

        public static bool operator ==(Negocio n, ClienteE c)
        {
            foreach (ClienteE item in n.clientes)
            {
                if (c == item)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio n, ClienteE c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, ClienteE c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }
        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }

    }
}


/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
using Encapsulamiento;


using System;


    class Program
{
    static void Main(string[] args)
    {
        ClienteE c1 = new ClienteE("Lautaro", 1);
        ClienteE c2 = new ClienteE("Mauricio", 2);
        ClienteE c3 = new ClienteE("Esteban", 3);
        Negocio n1 = new Negocio("Kiosco-24");
        if (n1 + c1)
        {
            Console.WriteLine("Se agrego c1 a la cola");
        }
        if (!(n1 + c1))
        {
            Console.WriteLine("Cliente c1 ya esta en la cola");
        }
        if (n1 + c2)
        {
            Console.WriteLine("Se agrego c2 a la cola");
        }
        if (n1 + c3)
        {
            Console.WriteLine("Se agrego c3 a la cola");
        }
        Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
        while (~n1) termina el programa
        {
            Console.WriteLine("Clientes pendientes: {0}", n1.ClientesPendientes);
        }
    }
}

*/