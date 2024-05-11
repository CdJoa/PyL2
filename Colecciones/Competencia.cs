using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;
namespace Colecciones
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { cantidadVueltas = value; }
        }
        public VehiculoCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        private Competencia()
        {
            this.competidores = new List<VehiculoCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public static bool operator +(Competencia c, VehiculoCarrera v)
        {
            Random combustibleRandom = new Random();
            bool returnAux = false;
            if (c.competidores.Count < c.cantidadCompetidores && c != v)
            {                
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                v.CantidadCombustible = (short)combustibleRandom.Next(15, 100);
                c.competidores.Add(v);
                returnAux = true;

                return true;
            }
            return returnAux;
        }
        public static bool operator -(Competencia c, VehiculoCarrera v)
        {
            bool returnAux = false;

            if (c == v)
            {
                c.competidores.Remove(v);
                return true;
            }
            return returnAux;
        }
        public static bool operator ==(Competencia c, VehiculoCarrera v)
        {
            bool returnAux = false;

            if((c.Tipo == Competencia.TipoCompetencia.F1 && v.GetType()== typeof(AutoF1))|| (c.Tipo == Competencia.TipoCompetencia.MotoCross && v.GetType() == typeof(Motocross)))
                {
                if (c.competidores.Count !=0 ) 
                { 
                    foreach (VehiculoCarrera vehiculo in c.competidores)
                    {
                        if (vehiculo == v)
                        {
                            returnAux = true;
                            break;
                        }
                    }
                }
            }
            return returnAux;

        }
        public static bool operator !=(Competencia c, VehiculoCarrera v)
        {
            return !(c == v);

        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------COMPETENCIA------");
            sb.AppendLine($"Tipo de Competencia: {this.tipo}");
            sb.AppendLine($"Cantidad de Competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de Vueltas: {this.cantidadVueltas}");

            foreach (VehiculoCarrera vehiculo in this.competidores)
            {
                sb.AppendLine("----------------------");
                // Aquí se verifica el tipo de vehículo y se muestra la información correspondiente
                if (this.tipo == TipoCompetencia.F1 && vehiculo is AutoF1 autoF1)
                {
                    sb.AppendLine(autoF1.MostrarDatos());
                }
                else if (this.tipo == TipoCompetencia.MotoCross && vehiculo is Motocross motocross)
                {
                    sb.AppendLine(motocross.MostrarDatos());
                }
                sb.AppendLine("----------------------");
            }

            return sb.ToString();
        }

    }
}

/*
 nuevo de herencia
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
using Encap;
using System;
using Herencia;


class Program
{
    static void Main(string[] args)
    {
        // Crear una nueva competencia de F1 con 5 competidores y 10 vueltas
        Competencia competenciaF1 = new Competencia(5, 10, Competencia.TipoCompetencia.F1);

        // Crear algunos vehículos de carrera
        AutoF1 auto1 = new AutoF1(1, "Escudería 1");
        AutoF1 auto2 = new AutoF1(2, "Escudería 2");
        Motocross moto1 = new Motocross(1, "Equipo A");
        Motocross moto2 = new Motocross(2, "Equipo B");

        // Agregar vehículos a la competencia
        // Agregar vehículos a la competencia
        if (competenciaF1 + auto1) { }
        if (competenciaF1 + auto2) { }
        // Intentar agregar un vehículo de tipo incorrecto
        if (competenciaF1 + moto1) { } // Esto no debería agregar el vehículo ya que es de tipo Motocross

        // Mostrar los datos de la competencia
        Console.WriteLine(competenciaF1.MostrarDatos());

        // Crear una nueva competencia de MotoCross con 5 competidores y 5 vueltas
        Competencia competenciaMotoCross = new Competencia(5, 5, Competencia.TipoCompetencia.MotoCross);

        // Agregar vehículos a la competencia de MotoCross
        if (competenciaMotoCross + moto1) { }
        if (competenciaMotoCross + moto2) { }
        // Intentar agregar un vehículo de tipo incorrecto
        if (competenciaMotoCross + auto1) { } // Esto no debería agregar el vehículo ya que es de tipo F1

        // Mostrar los datos de la competencia de MotoCross
        Console.WriteLine(competenciaMotoCross.MostrarDatos());

        // Mostrar los datos de la competencia de MotoCross
    }
}

*/



/* viejo de colecciones
 * class Program 
    {
        static void Main(string[] args)
        {
            // Crear instancias de autos
            AutoF1 a1 = new AutoF1(1, "escu 1");
            AutoF1 a2 = new AutoF1(4, "escu 2");
            AutoF1 a3 = new AutoF1(5, "escu 3");
            AutoF1 a4 = new AutoF1(1, "escu 1");
            AutoF1 a5 = new AutoF1(2, "escu 4");

            // Crear una competencia
            Competencia competencia = new Competencia(5, 10);

            // Agregar autos a la competencia
            Console.WriteLine("Agregando autos a la competencia:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Resultado: " + (competencia + a1)); // Debería agregar el auto a1
            Console.WriteLine("Resultado: " + (competencia + a2)); // Debería agregar el auto a2
            Console.WriteLine("Resultado: " + (competencia + a3)); // Debería agregar el auto a3
            Console.WriteLine("Resultado: " + (competencia + a4)); // Debería fallar porque a4 ya está en la competencia
            Console.WriteLine("Resultado: " + (competencia + a5)); // Debería agregar el auto a5
            Console.WriteLine("----------------------");

            // Mostrar datos de la competencia
            Console.WriteLine(competencia.MostrarDatos());

            // Quitar un auto de la competencia
            Console.WriteLine("Quitando un auto de la competencia:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Resultado: " + (competencia - a3)); // Debería quitar el auto a3
            Console.WriteLine("----------------------");

            // Mostrar datos de la competencia después de quitar el auto
            Console.WriteLine(competencia.MostrarDatos());

            Console.ReadLine();
        }
    }*/

