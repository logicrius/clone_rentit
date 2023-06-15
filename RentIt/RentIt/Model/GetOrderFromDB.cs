using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentIt.Model
{
    internal class GetOrderFromDB
    {
        public string namaFasilitas = string.Empty;
        public string namaPeminjam = string.Empty;

        public void ProposalOrder(string nim)
        {
            string query = "SELECT f.nama_fasilitas, p.nama FROM Peminjam p JOIN Orders o ON p.nim = o.nim JOIN Fasilitas f ON o.fasilitas_id = f.fasilitas_id WHERE p.nim = @nim_peminjam;";

            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nim_peminjam", nim);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            namaFasilitas = reader.GetString(0);
                            namaPeminjam = reader.GetString(1);
      
                        }
                    }
                }
            }
        }
    }

}
