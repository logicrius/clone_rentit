using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace RentIt.Model
{
    internal static class dbConnection
    {
        static string Connection = "Server=localhost; port=5432; user id=postgres; password=belajardatabase; database=RentIt";
        public static NpgsqlConnection GetConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(Connection);
            connection.Open();
            return connection;
        }
    }
}