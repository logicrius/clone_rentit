using Npgsql;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.Model
{
    internal class FasilitasModel
    {
        static string query = "SELECT gambar_fasilitas, desc_fasilitas, nama_fasilitas FROM Fasilitas";


        public string desc_fasilitas = string.Empty;
        public string nama_fasilitas1 = string.Empty;
        public byte[] gambar_fasilitas;

        public void FasilitasTest()
        {
            // Retrieve the necessary data from the database
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nama_fasilitas", nama_fasilitas1);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long len = reader.GetBytes(0, 0, null, 0, 0);  // Get the length of the bytea data
                            byte[] buffer = new byte[len];
                            reader.GetBytes(0, 0, buffer, 0, (int)len);  // Read the bytea data into the buffer
                            gambar_fasilitas = buffer;
                            desc_fasilitas = reader.GetString(1);
                            nama_fasilitas1 = reader.GetString(2);
                        }
                    }
                }
            }
        }
    }
}
