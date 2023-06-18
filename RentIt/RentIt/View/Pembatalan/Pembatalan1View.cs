using RentIt.View.Facility_Page;
using RentIt.View.Menu;
using RentIt.View.Other;
using RentIt.View.Pembayaran_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.View.Pembatalan_1
{
    public partial class Pembatalan1View : Form
    {
        public Pembatalan1View()
        {
            InitializeComponent();
            dragfile.DoubleClick += dragfile_DoubleClick;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dash;

            Rectangle rect = new Rectangle(10, 10, 525, 175);
            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();
        }

        private void dragfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Visible = dragfile.Items.Count == 0;
            pictureBox2.Visible = dragfile.Items.Count == 0;
            Instruksi.Visible = dragfile.Items.Count == 0;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuView mainview = new MenuView();
            mainview.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacilityPageView mainview = new FacilityPageView();
            mainview.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            otherView otherview = new otherView();
            otherview.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GKU_Click(object sender, EventArgs e)
        {

        }

        private void Uwang_Click(object sender, EventArgs e)
        {

        }

        private void GDku_Click(object sender, EventArgs e)
        {

        }

        private void batalkan_Click(object sender, EventArgs e)
        {

        }

        private void Pembatalan_Click(object sender, EventArgs e)
        {

        }

        private void UPdok_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Instruksi_Click(object sender, EventArgs e)
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
    }
}