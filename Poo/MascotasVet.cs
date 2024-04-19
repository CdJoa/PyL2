using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Poo
{
    public class MascotasVet
    {
        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private List<string> historialVacunacion;

        public MascotasVet(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.historialVacunacion = new List<string>(); 
        }

        public void AgregarVacuna(string vacuna)
        {
            historialVacunacion.Add(vacuna);
        }

        public string ObtenerEspecie()
        {
            return especie;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public DateTime ObtenerFechaDeNacimiento()
        {
            return fechaDeNacimiento;
        }

        public List<string> ObtenerHistorialVacunacion()
        {
            return historialVacunacion;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Especie: {especie}");
            sb.AppendLine($"Fecha de Nacimiento: {fechaDeNacimiento.ToShortDateString()}");
            sb.Append("Vacunas: ");
            if (historialVacunacion.Count > 0)
            {
                sb.Append(string.Join(", ", historialVacunacion));
            }
            else
            {
                sb.Append("Sin vacunar");
            }
            return sb.ToString();
        }
    }
}
