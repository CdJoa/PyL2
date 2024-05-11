using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;


namespace Colecciones
{
    public class AutoF1 : VehiculoCarrera
    {
        private short caballosFuerza;

        public short CaballosFuerza
        {
            get { return caballosFuerza; }
            set { caballosFuerza = value; }
        }

        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia) 
        {
            this.CaballosFuerza = 0; 
        }

        public AutoF1(short numero, string escuderia, short caballosFuerza)
            : base(numero, escuderia) 
        {
            this.CaballosFuerza = caballosFuerza;
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2); // Reutiliza el operador == para definir el operador !=
        }

    }
}
