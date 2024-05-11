using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class VehiculoCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return escuderia; }
            set { escuderia = value; }
        }

        public short Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Número: " + this.numero);
            sb.AppendLine("Escudería: " + this.escuderia);
            sb.AppendLine("Cantidad de Combustible: " + this.cantidadCombustible);
            sb.AppendLine("En Competencia: " + this.enCompetencia);
            sb.AppendLine("Vueltas Restantes: " + this.vueltasRestantes);
            return sb.ToString();
        }

        public VehiculoCarrera(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.vueltasRestantes = 0;
        }
    }
}
