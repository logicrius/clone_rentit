using RentIt.View.Menu;
using RentIt.View.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace RentIt.View.LaporKerusakan
{
    public partial class laporKerusakan1View : Form
    {
        public laporKerusakan1View()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            otherView otherview = new otherView();
            otherview.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuView mainview = new MenuView();
            mainview.ShowDialog();
        }

        private void dragfile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dragfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                pictureBox2.Visible = false;
                Instruksi.Visible = false;
                
            }


            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (extension == ".jpg" || extension == ".png" || extension == ".pdf"
                        || extension == ".doc" || extension == ".docx" || extension == ".zip")
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Instruksi_Click(object sender, EventArgs e)
        {

        }

        private void dragfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!dragfile.Items.Contains(Path.GetFileName(file)))
                {
                    dragfile.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void laporKerusakan1View_Load(object sender, EventArgs e)
        {

        }

        private void Batal_Click(object sender, EventArgs e)
        {
            this.Hide();
            laporKerusakan2View laporKerusakan2View = new laporKerusakan2View();
            laporKerusakan2View.ShowDialog();

            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Uwang_Click(object sender, EventArgs e)
        {

        }

        private void GDku_Click(object sender, EventArgs e)
        {

        }

        private void GKU_Click(object sender, EventArgs e)
        {

        }
    }
}
