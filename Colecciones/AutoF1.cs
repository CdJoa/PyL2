using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Colecciones
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        // Constructor
        public AutoF1(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto " + this.numero);
            sb.AppendLine("Escuderia " + this.escuderia);
            sb.AppendLine("Vueltas restantes " + this.vueltasRestantes);
            return sb.ToString();

        }
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

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
    }
}
