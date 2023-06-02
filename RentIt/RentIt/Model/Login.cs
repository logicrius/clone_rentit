using Npgsql;
using RentIt.View.Menu;
using System;
using System.Windows.Forms;

namespace RentIt.Model
{
    internal class Login
    {
        // Syntax untuk di PostgreSQL yang hitung username dan password yang sesuai dengan input.
        private static string query = "SELECT COUNT(*) FROM userLogin WHERE username = @username AND password = @password";
        public bool isLogged = true;
        public void PerformLogin(string username, string password)
        {
            // Menghubungkan program dengan database.
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {
                // Melaksanakan sytax pada 'query' di database yang terhubung 'connection'.
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Mencocokkan data username dan
                    command.Parameters.AddWithValue("@username", username);
                    // password pada database dengan input user.
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
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
