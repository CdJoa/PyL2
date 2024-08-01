using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BibliotecaCentralita
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float costo;

        public string RutaArchivo { get; set; } // Implementación de la propiedad RutaArchivo

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }

        public override bool Equals(object? obj)
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

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), NroDestino, NroOrigen);
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());
            sb.AppendLine("Costo: " + this.CostoLlamada);

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        // Implementación de la interfaz IGuardar<Local>
        public bool Guardar()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                using (StreamWriter writer = new StreamWriter(RutaArchivo))
                {
                    serializer.Serialize(writer, this);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Error al guardar el archivo de log.", ex);
            }
        }

        public Local Leer()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Local));
                using (StreamReader reader = new StreamReader(RutaArchivo))
                {
                    object obj = serializer.Deserialize(reader);
                    if (obj is Local local)
                    {
                        return local;
                    }
                    else
                    {
                        throw new InvalidCastException("El objeto deserializado no es del tipo Local.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Error al leer el archivo de log.", ex);
            }
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