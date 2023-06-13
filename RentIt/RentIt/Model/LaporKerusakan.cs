using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.Model
{
    internal class LaporKerusakan
    {
        static string query = @"
                        SELECT o.order_id, o.fasilitas_id, f.harga_fasilitas, f.nama_fasilitas, f.gambar_fasilitas
                        FROM Orders o
                        JOIN Fasilitas f ON o.fasilitas_id = f.fasilitas_id";
        static string insertQuery = "INSERT INTO Kerusakan (kerusakan_id, order_id, fasilitas_id, dokumen_kerusakan) " +
                     "VALUES (@kerusakan_id, @order_id, @fasilitas_id, @dokumen_kerusakan)";
        public static int i = 0;
        public string orderID = string.Empty;
        public string facilityID = string.Empty;
        public decimal facilityPrice = 0;
        public string facilityName = string.Empty;
        public string kerusakanID = "000000000" + i;
        public void InputKerusakan(byte[] file)
        {
            // Retrieve the necessary data from the database
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fasilitas_id", facilityID);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderID = reader.GetString(0);
                            facilityID = reader.GetString(1);
                            facilityPrice = reader.GetDecimal(2);
                            facilityName = reader.GetString(3);
                        }
                    }
                }

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@kerusakan_id", kerusakanID);
                    command.Parameters.AddWithValue("@order_id", orderID);
                    command.Parameters.AddWithValue("@fasilitas_id", facilityID);
                    command.Parameters.AddWithValue("@dokumen_kerusakan", file);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to insert data.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                i++;
            }
        }
        public void GetDataFromDatabase()
        {
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fasilitas_id", facilityID);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            orderID = reader.GetString(0);
                            facilityID = reader.GetString(1);
                            facilityPrice = reader.GetDecimal(2);
                            facilityName = reader.GetString(3);
                        }
                    }
                }
            }
        }
    }
}
