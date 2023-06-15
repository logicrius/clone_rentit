using RentIt.View.Facility_Page;
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
using System.Drawing.Drawing2D;

namespace RentIt.View.RentPage
{
    public partial class RentPageView : Form
    {
        public RentPageView()
        {
            InitializeComponent();
            dragfile.DoubleClick += dragfile_DoubleClick;

            //fileModel = new FileModel();
        }
        private void dragfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = dragfile.Items.Count == 0;
            pictureBox4.Visible = dragfile.Items.Count == 0;
            label10.Visible = dragfile.Items.Count == 0;
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


        private void dragfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                pictureBox4.Visible = false;
                label10.Visible = false;
                button2.Visible = false;
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

        private void dragfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!dragfile.Items.Contains(Path.GetFileName(file)))
                {
                    dragfile.Items.Add(Path.GetFileName(file));
                    //fileModel.SaveFileToDatabase(file);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dragfile.Items.Count == 0)
            {
                MessageBox.Show("Masukkan file dukungan terlebih dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            pembayaran1View form = new pembayaran1View();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuView mainview = new MenuView();
            mainview.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            otherView otherview = new otherView();
            otherview.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void RentPageView_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
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
                            //fileModel.SaveFileToDatabase(file);
                        }
                    }
                }
            }

            button2.Visible = false;
            pictureBox4.Visible = false;
            label10.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacilityPageView mainview = new FacilityPageView();
            mainview.ShowDialog();
        }
    }
}