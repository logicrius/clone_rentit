using Npgsql;
using RentIt.View.Menu;
using System;
using System.Windows.Forms;

namespace RentIt.Model
{
    internal class Login
    {
        // Syntax untuk di PostgreSQL yang hitung username dan password yang sesuai dengan input.
        private static string queryPeminjam = "SELECT COUNT(*) FROM Peminjam WHERE email = @email AND password = @password";
        private static string queryAdmin = "SELECT COUNT(*) FROM TableAdmin WHERE email = @email AND password = @password";
        public bool isLogged = true;
        public void PerformLogin(string email, string password)
        {
            // Menghubungkan program dengan database.
            using (NpgsqlConnection connection = dbConnection.GetConnection())
            {
                if (email.Contains("student"))
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(queryPeminjam, connection))
                    {
                        // Mencocokkan data username dan
                        command.Parameters.AddWithValue("@email", email);
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
                else
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(queryAdmin, connection))
                    {
                        // Mencocokkan data username dan
                        command.Parameters.AddWithValue("@email", email);
                        // password pada database dengan input user.
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            Admin_HomePageView menuView = new Admin_HomePageView();
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
}
