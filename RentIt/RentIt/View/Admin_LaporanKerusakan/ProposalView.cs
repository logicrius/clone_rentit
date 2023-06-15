using Npgsql;
using RentIt.View.Admin_HomePage;
using RentIt.View.Admin_Proposal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Admin_LaporanKerusakan
{
    public partial class ProposalView : Form
    {
        String nim;
        String idfasil;
        String orderId;
        public ProposalView()
        {
            InitializeComponent();
        }

        public ProposalView(string nim, string idfasil, string orderId)
        {
            InitializeComponent();
            this.Hide();
            this.nim = nim;
            this.idfasil = idfasil;
            this.orderId = orderId;
            nimMahasiswa.Text = nim;

            // Retrieve data from the database based on nim
            string connectionString = "Server=localhost; port=5432; user id=postgres; password=belajardatabase; database=RentIt";
            string query = "SELECT nama, jurusan, nomor_tlp FROM Peminjam WHERE nim = @nim";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nim", nim);
                    connection.Open();
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nama = reader.GetString(0);
                            string jurusan = reader.GetString(1);
                            string nomorTelp = reader.GetString(2);
                            namaMahasiswa.Text = nama;
                            jurusanMahasiswa.Text = jurusan;
                            nomortelfonMahasiswa.Text = nomorTelp;
                        }
                        else
                        {
                            // Handle the case when no data is found for the given nim
                            namaMahasiswa.Text = "Data not found";
                            jurusanMahasiswa.Text = "Data not found";
                            nomortelfonMahasiswa.Text = "Data not found";
                        }
                    }
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_HomePageView homepageview = new Admin_HomePageView();
            homepageview.Show();
        }

        private void facility_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_ProposalView proposalView = new Admin_ProposalView();
            proposalView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_LaporanKerusakanView viewPage = new Admin_LaporanKerusakanView();
            viewPage.Show();
        }

        private void home_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_HomePageView homePage = new Admin_HomePageView();
            homePage.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_LaporanKerusakanView viewPage = new Admin_LaporanKerusakanView();
            viewPage.Show();
        }

        private void facility_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Admin_ProposalView proposalView = new Admin_ProposalView();
            proposalView.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Approve_Click(object sender, EventArgs e)
        {
            // Menghapus data dari tabel "Orders" berdasarkan order_id
            string connectionString = "Server=localhost; port=5432; user id=postgres; password=belajardatabase; database=RentIt";
            string query = "DELETE FROM Orders WHERE order_id = @orderId";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proposal Diterima");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data dari tabel Orders.");
                    }
                }
            }
            this.Hide();
            Admin_ProposalView viewPage = new Admin_ProposalView();
            viewPage.Show();
        }


        private void Decline_Click(object sender, EventArgs e)
        {
            // Menghapus data dari tabel "Orders" berdasarkan order_id
            string connectionString = "Server=localhost; port=5432; user id=postgres; password=belajardatabase; database=RentIt";
            string query = "DELETE FROM Orders WHERE order_id = @orderId";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderId", orderId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Proposal Ditolak");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data dari tabel Orders.");
                    }
                }
            }
            this.Hide();
            Admin_ProposalView viewPage = new Admin_ProposalView();
            viewPage.Show();
        }
    }
}
