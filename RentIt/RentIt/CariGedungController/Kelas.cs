using RentIt.View.Facility_Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.CariGedungController
{
    public partial class Kelas : UserControl
    {
        public Kelas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacilityPageView facilityPageView = new FacilityPageView();
            facilityPageView.ShowDialog();
        }
    }
}
