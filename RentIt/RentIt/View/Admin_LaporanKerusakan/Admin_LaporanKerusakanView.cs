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
    public partial class Admin_LaporanKerusakanView : Form
    {
        public Admin_LaporanKerusakanView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_LaporanKerusakanView viewPage = new Admin_LaporanKerusakanView();
            viewPage.Show();
        }

        private void redBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void facility_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_ProposalView propview = new Admin_ProposalView();
            propview.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_HomePageView homePage = new Admin_HomePageView();
            homePage.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GDku_Click(object sender, EventArgs e)
        {

        }

        private void Uwang_Click(object sender, EventArgs e)
        {

        }
    }
}
