using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCentralita
{
    public static class DataBaseCentralita
    {
        private static string connectionString = @"Server=.\;Database=Centralita;Trusted_Connection=True;TrustServerCertificate=True";

        public static SqlConnection GetOpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
