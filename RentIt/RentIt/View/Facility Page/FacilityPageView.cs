using RentIt.View.RentPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Facility_Page
{
    public partial class FacilityPageView : Form
    {
        public FacilityPageView()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_TUCH_Click(object sender, EventArgs e)
        {

        }

        private void textBox_GKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_GKU_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentPageView rentPageView = new RentPageView();
            rentPageView.ShowDialog();
        }

        private void buttonTUCH_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacilityPageView facilityPageView = new FacilityPageView();
            facilityPageView.ShowDialog();
        }

        private void button_Auditorium_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {

        }
    }
}
