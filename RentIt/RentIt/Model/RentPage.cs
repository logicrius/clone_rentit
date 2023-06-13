using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Npgsql;
using RentIt.Model;
using NpgsqlTypes;

namespace RentIt.Models
{
    public class FileModel
    {
        public void SaveFileToDatabase(string filePath)
        {
            byte[] fileContent = File.ReadAllBytes(filePath);
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {
                string orderId = GenerateOrderId();
                string insertQuery = "INSERT INTO Orders (order_id, file_dokumen) VALUES (@OrderId, @FileContent)";
                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderId", orderId);
                    command.Parameters.AddWithValue("@FileContent", fileContent);
                    command.ExecuteNonQuery();
                }
            }
        }

        private string GenerateOrderId()
        {
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string uniqueNumber = GetUniqueNumber().ToString().PadLeft(5, '0');
            return $"{timestamp}{uniqueNumber}";
        }

        private int GetUniqueNumber()
        {
            // Dapatkan nomor urut unik dari database atau sumber lainnya
            // Misalnya, dapat menggunakan sequence atau penomoran berdasarkan jumlah pesanan sebelumnya
            // Di sini, kita menggunakan contoh sederhana dengan nilai acak
            Random random = new Random();
            return random.Next(1, 100000);
        }
    }
}