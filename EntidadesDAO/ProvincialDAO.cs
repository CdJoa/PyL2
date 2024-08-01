using BibliotecaCentralita;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDAO
{
    public class ProvincialDAO
    {
 
        private string connectionString = "Centralita"; // Reemplaza con tu cadena de conexión

        /*public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)*/

        public void Guardar(Provincial provincial)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Llamadas (Duracion, Origen, Destino, Costo, Tipo) VALUES (@Duracion, @Origen, @Destino, @Costo, @Tipo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Duracion", provincial.Duracion);
                command.Parameters.AddWithValue("@Origen", provincial.NroOrigen);
                command.Parameters.AddWithValue("@Destino", provincial.NroDestino);
                command.Parameters.AddWithValue("@Costo", provincial.CostoLlamada);
                command.Parameters.AddWithValue("@Tipo", 0); // 0 para llamadas locales

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Provincial Leer(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Llamadas WHERE ID = @ID AND Tipo = 0";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Provincial provincial = new Provincial(
                        origen: reader.GetString(reader.GetOrdinal("Origen")),
                        miFranja: (Provincial.Franja)reader.GetInt32(reader.GetOrdinal("Franja")),
                        duracion: reader.GetFloat(reader.GetOrdinal("Duracion")),
                        destino: reader.GetString(reader.GetOrdinal("Destino"))
                    );

                    return provincial;
                }
                else
                {
                    throw new Exception("No se encontró la llamada local con el ID especificado.");
                }
            }
        }
    }
}


