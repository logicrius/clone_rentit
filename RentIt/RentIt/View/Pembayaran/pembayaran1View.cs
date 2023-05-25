using RentIt.View.Menu;
using RentIt.View.Pembayaran_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Pembayaran_1
{
    public partial class pembayaran1View : Form
    {
        public pembayaran1View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pembayaran2View pembayaran2View = new pembayaran2View();
            pembayaran2View.ShowDialog(); 
        }

        private void home_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void facility_Click(object sender, EventArgs e)
        {

        }
    }
}
