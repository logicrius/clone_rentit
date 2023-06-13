namespace RentIt.View.Admin_LaporanKerusakan
{
    partial class Admin_LaporanKerusakanView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.redBox = new System.Windows.Forms.Panel();
            this.facility = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.GKU = new System.Windows.Forms.PictureBox();
            this.Uwang = new System.Windows.Forms.Label();
            this.GDku = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GKU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(715, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 58;
            this.button1.Text = "Laporan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.DarkRed;
            this.redBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.redBox.Location = new System.Drawing.Point(0, 0);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(1241, 38);
            this.redBox.TabIndex = 57;
            this.redBox.Paint += new System.Windows.Forms.PaintEventHandler(this.redBox_Paint);
            // 
            // facility
            // 
            this.facility.BackColor = System.Drawing.SystemColors.Control;
            this.facility.FlatAppearance.BorderSize = 0;
            this.facility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.facility.ForeColor = System.Drawing.SystemColors.ControlText;
            this.facility.Location = new System.Drawing.Point(591, 66);
            this.facility.Name = "facility";
            this.facility.Size = new System.Drawing.Size(118, 50);
            this.facility.TabIndex = 56;
            this.facility.Text = "Proposal";
            this.facility.UseVisualStyleBackColor = false;
            this.facility.Click += new System.EventHandler(this.facility_Click);
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.home.Location = new System.Drawing.Point(474, 66);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(111, 50);
            this.home.TabIndex = 55;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(266, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 385);
            this.panel1.TabIndex = 59;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.GKU);
            this.panel2.Controls.Add(this.Uwang);
            this.panel2.Controls.Add(this.GDku);
            this.panel2.Location = new System.Drawing.Point(123, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 84);
            this.panel2.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(349, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "See More";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // GKU
            // 
            this.GKU.Image = global::RentIt.Properties.Resources.pic;
            this.GKU.Location = new System.Drawing.Point(0, 0);
            this.GKU.Margin = new System.Windows.Forms.Padding(2);
            this.GKU.Name = "GKU";
            this.GKU.Size = new System.Drawing.Size(82, 84);
            this.GKU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GKU.TabIndex = 33;
            this.GKU.TabStop = false;
            // 
            // Uwang
            // 
            this.Uwang.AutoSize = true;
            this.Uwang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uwang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.Uwang.Location = new System.Drawing.Point(105, 48);
            this.Uwang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Uwang.Name = "Uwang";
            this.Uwang.Size = new System.Drawing.Size(102, 13);
            this.Uwang.TabIndex = 1;
            this.Uwang.Text = "Rp 1.000.000.00";
            this.Uwang.Click += new System.EventHandler(this.Uwang_Click);
            // 
            // GDku
            // 
            this.GDku.AutoSize = true;
            this.GDku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GDku.Location = new System.Drawing.Point(105, 15);
            this.GDku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GDku.Name = "GDku";
            this.GDku.Size = new System.Drawing.Size(164, 17);
            this.GDku.TabIndex = 0;
            this.GDku.Text = "Gedung Kuliah Umum";
            this.GDku.Click += new System.EventHandler(this.GDku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(259, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 62;
            this.label1.Text = "Laporan Kerusakan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RentIt.Properties.Resources.babi;
            this.pictureBox3.Location = new System.Drawing.Point(158, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentIt.Properties.Resources.PP;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Admin_LaporanKerusakanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.redBox);
            this.Controls.Add(this.facility);
            this.Controls.Add(this.home);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_LaporanKerusakanView";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GKU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel redBox;
        private System.Windows.Forms.Button facility;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox GKU;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Uwang;
        private System.Windows.Forms.Label GDku;
        private System.Windows.Forms.Button button2;
    }
}