using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino; }
        public string NroOrigen { get => nroOrigen; }

        public abstract float CostoLlamada { get; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: " + this.duracion);
            sb.AppendLine("N° Origen: " + this.nroOrigen);
            sb.AppendLine("N° Destino: " + this.nroDestino);

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Llamada llamada = (Llamada)obj;
            return this.duracion == llamada.duracion &&
                   this.nroDestino == llamada.nroDestino &&
                   this.nroOrigen == llamada.nroOrigen;
        }

        public override int GetHashCode()
        {
            return this.duracion.GetHashCode() ^
                   (this.nroDestino != null ? this.nroDestino.GetHashCode() : 0) ^
                   (this.nroOrigen != null ? this.nroOrigen.GetHashCode() : 0);
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (ReferenceEquals(llamada1, null) && ReferenceEquals(llamada2, null))
                return true;
            if (ReferenceEquals(llamada1, null) || ReferenceEquals(llamada2, null))
                return false;

            return llamada1.Equals(llamada2);
        }

        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

        public static int OrdernarPorDuracion(Llamada llm1, Llamada llm2)
        {
            return (int)(llm1.Duracion - llm2.Duracion);
        }
    }
}


/*centralita I
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
}*/