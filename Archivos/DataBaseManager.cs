using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;

namespace Archivos
{
    public static class DataBaseManager
    {
        private static string connectionString;     //
        private static SqlConnection connection;    // Puente.

        static DataBaseManager()
        {

            connectionString = @"Server = .\; Database = 20220804EX; Trusted_Connection = True";
            connection = new SqlConnection(connectionString);

        }

        public static string ObtenerPaciente(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text; //System.Data;
                command.Connection = connection;
                string query = $"SELECT nombre, apellido FROM Pacientes where id = @id";
                command.CommandText = query;
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return $"{reader.GetString(0)} - {reader.GetString(1)}";
                }
                throw new DataBaseManagerException("No existe el ID");
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException($"Error al Leer en la BBDD", ex);
            }
            finally
            {
                if (connection is not null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
