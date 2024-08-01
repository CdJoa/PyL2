using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public class ProvincialDAO
    {
        public void Guardar(Provincial provincial)
        {
            using (SqlConnection connection = DataBaseCentralita.GetOpenConnection())
            {
                string query = "INSERT INTO Llamadas (Duracion, Origen, Destino, Costo, Tipo) VALUES (@Duracion, @Origen, @Destino, @Costo, @Tipo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Duracion", provincial.Duracion);
                command.Parameters.AddWithValue("@Origen", provincial.NroOrigen);
                command.Parameters.AddWithValue("@Destino", provincial.NroDestino);
                command.Parameters.AddWithValue("@Costo", provincial.CostoLlamada);
                command.Parameters.AddWithValue("@Tipo", 1); // 1 para llamadas provinciales

                command.ExecuteNonQuery();
            }
        }

        public Provincial Leer(int id)
        {
            using (SqlConnection connection = DataBaseCentralita.GetOpenConnection())
            {
                string query = "SELECT * FROM Llamadas WHERE ID = @ID AND Tipo = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Provincial provincial = new Provincial(
                        origen: reader.GetString(reader.GetOrdinal("Origen")),
                        miFranja: (Provincial.Franja)reader.GetInt32(reader.GetOrdinal("Franja")),
                        duracion: reader.GetInt32(reader.GetOrdinal("Duracion")),
                        destino: reader.GetString(reader.GetOrdinal("Destino"))
                    );

                    return provincial;
                }
                else
                {
                    throw new Exception("No se encontró la llamada provincial con el ID especificado.");
                }
            }
        }
    }
}


