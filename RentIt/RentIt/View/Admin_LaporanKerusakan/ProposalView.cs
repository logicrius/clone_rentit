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
        public ProposalView()
        {
            InitializeComponent();
        }

        public ProposalView(string nim, string idfasil)
        {
            InitializeComponent();
            this.nim = nim;
            this.idfasil = idfasil;
            nimMahasiswa.Text = nim;
            namaMahasiswa.Text= nim;
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
    }
}
