using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;
using BibliotecaCentralita;
namespace EntidadesDAO
{
    public class LocalDAO
    {
        private string connectionString = "Centralita"; // Reemplaza con tu cadena de conexión

        /*public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)*/

        public void Guardar(Local local)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Llamadas (Duracion, Origen, Destino, Costo, Tipo) VALUES (@Duracion, @Origen, @Destino, @Costo, @Tipo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Duracion", local.Duracion);
                command.Parameters.AddWithValue("@Origen", local.NroOrigen);
                command.Parameters.AddWithValue("@Destino", local.NroDestino);
                command.Parameters.AddWithValue("@Costo", local.CostoLlamada);
                command.Parameters.AddWithValue("@Tipo", 0); // 0 para llamadas locales

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Local Leer(int id)
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
                    Local local = new Local(
                        reader.GetString(reader.GetOrdinal("Origen")),
                        reader.GetInt32(reader.GetOrdinal("Duracion")),
                        reader.GetString(reader.GetOrdinal("Destino")),
                        reader.GetFloat(reader.GetOrdinal("Costo"))
                    );

                    return local;
                }
                else
                {
                    throw new Exception("No se encontró la llamada local con el ID especificado.");
                }
            }
        }
    }
}


