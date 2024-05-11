using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;


namespace Colecciones
{
    public class Motocross : VehiculoCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public Motocross(short numero, string escuderia)
            : base(numero, escuderia) 
        {
            this.Cilindrada = 0; 
        }

        public Motocross(short numero, string escuderia, short caballosFuerza)
            : base(numero, escuderia) 
        {
            this.Cilindrada = caballosFuerza;
        }
        public static bool operator ==(Motocross m1, Motocross m2)
        {
            return (m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia);
        }

        public static bool operator !=(Motocross m1, Motocross m2)
        {
            return !(m1 == m2); 
        }

    }
}
