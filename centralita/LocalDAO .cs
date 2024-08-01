using Microsoft.Data.SqlClient;
using Microsoft.SqlServer;
using BibliotecaCentralita;

namespace BibliotecaCentralita

{
    public class LocalDAO
    {
        public void Guardar(Local local)
        {
            using (SqlConnection connection = DataBaseCentralita.GetOpenConnection())
            {
                string query = "INSERT INTO Llamadas (Duracion, Origen, Destino, Costo, Tipo) VALUES (@Duracion, @Origen, @Destino, @Costo, @Tipo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Duracion", local.Duracion);
                command.Parameters.AddWithValue("@Origen", local.NroOrigen);
                command.Parameters.AddWithValue("@Destino", local.NroDestino);
                command.Parameters.AddWithValue("@Costo", local.CostoLlamada);
                command.Parameters.AddWithValue("@Tipo", 0); // 0 para llamadas locales

                command.ExecuteNonQuery();
            }
        }

        public Local Leer(int id)
        {
            using (SqlConnection connection = DataBaseCentralita.GetOpenConnection())
            {
                string query = "SELECT * FROM Llamadas WHERE ID = @ID AND Tipo = 0";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Local local = new Local(
                        origen: reader.GetString(reader.GetOrdinal("Origen")),
                        duracion: reader.GetInt32(reader.GetOrdinal("Duracion")),
                        destino: reader.GetString(reader.GetOrdinal("Destino")),
                        costo: reader.GetFloat(reader.GetOrdinal("Costo"))
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


