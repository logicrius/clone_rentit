using Npgsql;
using RentIt.Model;
using RentIt.View.Admin_HomePage;
using RentIt.View.Admin_LaporanKerusakan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Admin_Proposal
{
    public partial class Admin_ProposalView : Form
    {
        GetOrderFromDB OrderModel = new GetOrderFromDB();
        public Admin_ProposalView()
        {
            InitializeComponent();

            string connectionString ="Server=localhost; port=5432; user id=postgres; password=belajardatabase; database=RentIt";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM orders";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Proposal_Load(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_HomePageView homePage = new Admin_HomePageView();
            homePage.Show();
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

        private void SeeMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProposalView proposalView = new ProposalView();
            proposalView.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nim = row.Cells["nim"].Value.ToString();
                string idfasil = row.Cells["fasilitas_id"].Value.ToString();

                ProposalView proposalView = new ProposalView(nim, idfasil);
                proposalView.Show();
            }
        }
    }
}
