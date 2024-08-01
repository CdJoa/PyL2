using ArchivosManejadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;
using System.Xml.Serialization;

namespace BibliotecaCentralita
{
    public class Provincial : Llamada, IGuardar<Provincial>
    {
        private Franja franjaHoraria;
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
            float resultado = 0f;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    resultado =2 * Duracion;
                    break;
                case Franja.Franja_2:
                    resultado = 3 * Duracion;
                    break;
                case Franja.Franja_3:
                    resultado = 6 * Duracion;
                    break;
            }
            return resultado;
        }

        public override bool Equals(object? obj) // Cambiar a object?
        {
            if (ReferenceEquals(null, obj)) return false;

            if (ReferenceEquals(this, obj)) return true;

            if (obj is Provincial provincial)
            {
                return base.Equals(provincial) && NroDestino == provincial.NroDestino && NroOrigen == provincial.NroOrigen && franjaHoraria == provincial.franjaHoraria;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetHashCode();
            hashCode = hashCode * 397 ^ (int)franjaHoraria;
            return hashCode;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"franja-horaria={franjaHoraria}");
            sb.AppendLine($"costo-llamada={CostoLlamada}");
            return sb.ToString();
        }

        public Provincial(Franja franja, Llamada llamada) : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public bool Guardar()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
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

        public Provincial Leer()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Provincial));
                using (StreamReader reader = new StreamReader(RutaArchivo))
                {
                    object obj = serializer.Deserialize(reader);
                    if (obj is Provincial provincial)
                    {
                        return provincial;
                    }
                    else
                    {
                        throw new InvalidCastException("El objeto deserializado no es del tipo Provincial.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FallaLogException("Error al leer el archivo de log.", ex);
            }
        }
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}

/* centralita I
 ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        private const float FRJ_1_COSTO = 0.99f;
        private const float FRJ_2_COSTO = 1.25f;
        private const float FRJ_3_COSTO = 0.66f;

        private Franja franjaHoraria;

        public Provincial(Franja franja, Llamada llamada) : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = miFranja;
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
            float resultado = 0f;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    resultado = FRJ_1_COSTO * Duracion;
                    break;
                case Franja.Franja_2:
                    resultado = FRJ_2_COSTO * Duracion;
                    break;
                case Franja.Franja_3:
                    resultado = FRJ_3_COSTO * Duracion;
                    break;
            }
            return resultado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"llamada-provincial.franja-horaria={franjaHoraria}");
            return sb.ToString();
        }
    }
}*/