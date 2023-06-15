using RentIt.Model;
using RentIt.View.Menu;
using RentIt.View.Other;
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
        FasilitasModel fm = new FasilitasModel();
        public FacilityPageView()
        {
            InitializeComponent();
            fm.FasilitasTest("Gedung Kuliah Umum (GKU)");
            if (fm.nama_fasilitas1 == "Gedung Kuliah Umum (GKU)")
            {
                label_JudulGKU.Text = fm.nama_fasilitas1;
                label_Desc_GKU.Text = fm.desc_fasilitas;


            }

            fm.FasilitasTest("Telkom University Convention Hall");
            if (fm.nama_fasilitas1 == "Telkom University Convention Hall")
            {
                label_Judul_TUCH.Text = fm.nama_fasilitas1;
                label_Desc_TUCH.Text = fm.desc_fasilitas;

            }

            fm.FasilitasTest("Auditorium");
            if (fm.nama_fasilitas1 == "Auditorium")
            {
                label_Judul_auditorium.Text = fm.nama_fasilitas1;
                label_Desc_Auditorium.Text = fm.desc_fasilitas;

            }

            fm.FasilitasTest("Student Center");
            if (fm.nama_fasilitas1 == "Student Center")
            {
                label_Judul_StudentCenter.Text = fm.nama_fasilitas1;
                label_Desc_StudentCenter.Text = fm.desc_fasilitas;
            }
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
            rentPageView.FacilityDesc = "GKU Telkom University memiliki nama lain Gedung Tokong Nanas yang diambil dari salah satu laut di Nata, pulau terluar di Indonesia.";
            rentPageView.FacilityImage = pictureBox_glku.Image;
            rentPageView.ShowDialog();

            
        }

        private void buttonTUCH_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentPageView rentPageView = new RentPageView();
            rentPageView.FacilityDesc = "Telkom University Convention Hall atau biasa disebut dengan TUCH dengan kapasitas sebesar 800 orang";
            rentPageView.FacilityImage = pictureBox_TUCH.Image;
            rentPageView.ShowDialog();
        }

        private void button_Auditorium_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentPageView rentPageView = new RentPageView();
            rentPageView.FacilityDesc = "Auditorium Damar berdiri di atas lahan seluas 1000 meter persegi, kawasan lahan hijau, dikelilingi hutan lindung dalam universitas.";
            rentPageView.FacilityImage = pictureBox_Auditorium.Image;
            rentPageView.ShowDialog();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuView mainview = new MenuView();
            mainview.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            otherView otherview = new otherView();
            otherview.ShowDialog();
        }

        private void textBox_jUDULgku_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacilityPageView_Load(object sender, EventArgs e)
        {

        }

        private void buttonStudentCenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            RentPageView rentPageView = new RentPageView();
            rentPageView.FacilityDesc = "Student Center tempat kesekretariatan yang memiiliki fungsi administrasi, konsolidasi, latihan dan penyimpanan barang.";
            rentPageView.FacilityImage = pictureBoxStudentCenter.Image;
            rentPageView.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_glku_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAuditorium_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label_Desc_StudentCenter_Click(object sender, EventArgs e)
        {

        }

        private void label_Desc_Auditorium_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TUCH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Desc_TUCH_Click(object sender, EventArgs e)
        {

        }
    }
}
