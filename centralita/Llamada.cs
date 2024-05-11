using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Llamada
    {

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;


        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("N° Origen: " + this.nroOrigen);
            sb.AppendLine("N° Destino: " + this.nroDestino);

            return sb.ToString();
        }

        public static int OrdernarPorDuracion(Llamada llm1, Llamada llm2)
        {
            return (int)(llm1.duracion - llm2.duracion);
        }
    }
}
