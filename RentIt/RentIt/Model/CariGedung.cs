/*using Npgsql;
using RentIt.View.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.Model
*//*{
*//*    internal class CariGedung
    {
        // Syntax untuk di PostgreSQL yang hitung username dan password yang sesuai dengan input.
        private static string query = "SELECT nama_fasilitas, avaible_date FROM Fasilitas";
        public bool isLogged = true;
        public void PerformGedung(string namaGdeung, string tanggal)
        {
            // Menghubungkan program dengan database.
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {
                // Melaksanakan sytax pada 'query' di database yang terhubung 'connection'.
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (command.rea)
                    {
                        MenuView menuView = new MenuView();
                        menuView.Show();
                        // Hide form LoginView.
                        Form loginForm = Application.OpenForms["LoginView"];
                        if (loginForm != null)
                        {
                            loginForm.Hide();
                        }
                    }
                    else
                    {
                        isLogged = false;
                    }
                }
            }
        }
    }
}
*/