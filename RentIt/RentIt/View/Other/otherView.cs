using RentIt.View.LaporKerusakan;
using RentIt.View.LaporKerusakanModel;
using RentIt.View.Menu;
using RentIt.View.Pembatalan_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Other
{
    public partial class otherView : Form
    {
        public otherView()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pembatalan1View pembatalan = new Pembatalan1View();
            pembatalan.ShowDialog();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            laporKerusakan1View kerusakan = new laporKerusakan1View();
            kerusakan.ShowDialog();
            
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuView mainview = new MenuView();
            mainview.ShowDialog();
        }

    }
}
