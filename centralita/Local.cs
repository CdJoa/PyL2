using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BibliotecaCentralita
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return (float)(base.Duracion * this.costo);
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false; // Manejar el caso nulo

            if (ReferenceEquals(this, obj)) return true;  // Objeto comparado a sí mismo

            // Verificar si obj es del tipo Local usando el operador 'is' para eficiencia
            if (obj is Local local)
            {
                // Comparar propiedades para igualdad (incluyendo propiedades heredadas)
                return base.Equals(local) && NroDestino == local.NroDestino && NroOrigen == local.NroOrigen;
            }

            return false; 
        }


        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Costo de la llamada: " + CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }
    }
}
/*centralita i
 ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Local : Llamada
    {
        protected float costo;


        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return (float)(base.Duracion * this.costo);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"llamada-local.costo = {costo}");
            return sb.ToString();
        }
    }
}*/