using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Centralita
    {
        private List<Llamada> llamadas;
        private string razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.llamadas;
            }
        }

        public Centralita()
        { }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
            this.llamadas = new List<Llamada>();
        }

        // Propiedades para calcular las ganancias
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (var llamada in llamadas)
            {
                if (llamada is Local local)
                {
                    gananciaLocal += local.CostoLlamada;
                }
                else if (llamada is Provincial provincial)
                {
                    gananciaProvincial += provincial.CostoLlamada;
                }
            }

            return tipo switch
            {
                TipoLlamada.Local => gananciaLocal,
                TipoLlamada.Provincial => gananciaProvincial,
                TipoLlamada.Todas => gananciaLocal + gananciaProvincial,
                _ => 0
            };
        }

        public void OrdenarLlamadas()
        {
            llamadas.Sort(Llamada.OrdernarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("\n----------------------------------\n");
            sb.AppendFormat("Empresa: {0}\nGanancia total: {1:C}\nGanancia por llamados locales: {2:C}\nGanancia por llamados provinciales: {3:C}\n", this.razonSocial, GananciaPorTotal, GananciaPorLocal, GananciaPorProvincial);
            sb.AppendLine("\n|||Llamadas Realizadas|||\n");

            foreach (var llamada in Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            sb.AppendLine("\n|||Fin del historial de llamadas|||\n\n----------------------------------");

            return sb.ToString();
        }
    }
}
