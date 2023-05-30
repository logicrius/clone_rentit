using RentIt.View.Facility_Page;
using RentIt.View.Menu;
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
    public partial class Olahraga : UserControl
    {
        public Olahraga()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuView menuView = this.ParentForm as MenuView;

            if (menuView != null)
            {
                menuView.Hide();
            }

            FacilityPageView facilityPageView = new FacilityPageView();
            facilityPageView.ShowDialog();
        }
    }
}
