using RentIt.View.Menu;
using RentIt.View.Other;
using RentIt.View.Pembayaran_1;
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
            dragfile.DoubleClick += dragfile_DoubleClick;
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
                button4.Visible = false;
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
            if (dragfile.Items.Count == 0)
            {
                MessageBox.Show("Masukkan file dukungan terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            otherView form = new otherView();
            form.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog.FileNames;
                    foreach (string file in files)
                    {
                        if (!dragfile.Items.Contains(Path.GetFileName(file)))
                        {
                            dragfile.Items.Add(Path.GetFileName(file));
                        }
                    }
                }
            }

            button4.Visible = false;
            pictureBox2.Visible = false;
            Instruksi.Visible = false;
        }

        private void dragfile_DoubleClick(object sender, EventArgs e)
        {
            if (dragfile.SelectedItem != null)
            {
                string selectedFile = dragfile.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Hapus File?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dragfile.Items.Remove(selectedFile);
                }
            }
        }
    }
}