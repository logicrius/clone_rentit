namespace RentIt
{
    partial class MainPageView
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.loginMssg = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.twitter = new System.Windows.Forms.PictureBox();
            this.linkedin = new System.Windows.Forms.PictureBox();
            this.instagram = new System.Windows.Forms.PictureBox();
            this.facebook = new System.Windows.Forms.PictureBox();
            this.logoBottom = new System.Windows.Forms.PictureBox();
            this.SignInBut = new RoundedButton();
            this.kontak = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.Label();
            this.panelFasil = new RoundedPanel();
            this.sewaText = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainText = new System.Windows.Forms.Label();
            this.backgroundPic = new RoundedPictureBox();
            this.home = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.logoTUTop = new System.Windows.Forms.PictureBox();
            this.logoTop = new System.Windows.Forms.PictureBox();
            this.facility = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kelas = new System.Windows.Forms.PictureBox();
            this.gedung = new System.Windows.Forms.PictureBox();
            this.olahraga = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBottom)).BeginInit();
            this.panelFasil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTUTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gedung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olahraga)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Controls.Add(this.loginMssg);
            this.mainPanel.Controls.Add(this.SignIn);
            this.mainPanel.Controls.Add(this.bottomPanel);
            this.mainPanel.Controls.Add(this.SignInBut);
            this.mainPanel.Controls.Add(this.kontak);
            this.mainPanel.Controls.Add(this.alamat);
            this.mainPanel.Controls.Add(this.panelFasil);
            this.mainPanel.Controls.Add(this.mainText);
            this.mainPanel.Controls.Add(this.backgroundPic);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(42, 11, 42, 130);
            this.mainPanel.Size = new System.Drawing.Size(1142, 613);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // loginMssg
            // 
            this.loginMssg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginMssg.AutoSize = true;
            this.loginMssg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.loginMssg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginMssg.Location = new System.Drawing.Point(359, 212);
            this.loginMssg.Name = "loginMssg";
            this.loginMssg.Size = new System.Drawing.Size(145, 13);
            this.loginMssg.TabIndex = 8;
            this.loginMssg.Text = "Log in using your account on:";
            this.loginMssg.Click += new System.EventHandler(this.label4_Click);
            // 
            // SignIn
            // 
            this.SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignIn.AutoSize = true;
            this.SignIn.BackColor = System.Drawing.Color.IndianRed;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.SignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignIn.Location = new System.Drawing.Point(509, 165);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(66, 20);
            this.SignIn.TabIndex = 7;
            this.SignIn.Text = "Sign In";
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bottomPanel.Controls.Add(this.twitter);
            this.bottomPanel.Controls.Add(this.linkedin);
            this.bottomPanel.Controls.Add(this.instagram);
            this.bottomPanel.Controls.Add(this.facebook);
            this.bottomPanel.Controls.Add(this.logoBottom);
            this.bottomPanel.Location = new System.Drawing.Point(0, 509);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1142, 101);
            this.bottomPanel.TabIndex = 2;
            this.bottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // twitter
            // 
            this.twitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.twitter.Image = global::RentIt.Properties.Resources.twit;
            this.twitter.Location = new System.Drawing.Point(1074, 36);
            this.twitter.Name = "twitter";
            this.twitter.Size = new System.Drawing.Size(30, 28);
            this.twitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twitter.TabIndex = 4;
            this.twitter.TabStop = false;
            this.twitter.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // linkedin
            // 
            this.linkedin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkedin.Image = global::RentIt.Properties.Resources.Linked;
            this.linkedin.Location = new System.Drawing.Point(1016, 36);
            this.linkedin.Name = "linkedin";
            this.linkedin.Size = new System.Drawing.Size(30, 28);
            this.linkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.linkedin.TabIndex = 3;
            this.linkedin.TabStop = false;
            this.linkedin.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // instagram
            // 
            this.instagram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.instagram.Image = global::RentIt.Properties.Resources.insta;
            this.instagram.Location = new System.Drawing.Point(960, 36);
            this.instagram.Name = "instagram";
            this.instagram.Size = new System.Drawing.Size(30, 28);
            this.instagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.instagram.TabIndex = 2;
            this.instagram.TabStop = false;
            this.instagram.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // facebook
            // 
            this.facebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.facebook.Image = global::RentIt.Properties.Resources.face;
            this.facebook.Location = new System.Drawing.Point(899, 36);
            this.facebook.Name = "facebook";
            this.facebook.Size = new System.Drawing.Size(30, 28);
            this.facebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebook.TabIndex = 1;
            this.facebook.TabStop = false;
            this.facebook.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // logoBottom
            // 
            this.logoBottom.Image = global::RentIt.Properties.Resources.babi;
            this.logoBottom.Location = new System.Drawing.Point(12, 24);
            this.logoBottom.Name = "logoBottom";
            this.logoBottom.Size = new System.Drawing.Size(191, 50);
            this.logoBottom.TabIndex = 0;
            this.logoBottom.TabStop = false;
            this.logoBottom.Click += new System.EventHandler(this.logoBottom_Click);
            // 
            // SignInBut
            // 
            this.SignInBut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInBut.FlatAppearance.BorderSize = 0;
            this.SignInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBut.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SignInBut.Image = global::RentIt.Properties.Resources.Untitled_design2;
            this.SignInBut.Location = new System.Drawing.Point(338, 214);
            this.SignInBut.Name = "SignInBut";
            this.SignInBut.Size = new System.Drawing.Size(491, 55);
            this.SignInBut.TabIndex = 6;
            this.SignInBut.Text = "Connect with office365";
            this.SignInBut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignInBut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SignInBut.UseVisualStyleBackColor = true;
            this.SignInBut.Click += new System.EventHandler(this.roundedButton1_Click_1);
            // 
            // kontak
            // 
            this.kontak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kontak.AutoSize = true;
            this.kontak.BackColor = System.Drawing.Color.White;
            this.kontak.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kontak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kontak.Location = new System.Drawing.Point(852, 392);
            this.kontak.Name = "kontak";
            this.kontak.Size = new System.Drawing.Size(177, 45);
            this.kontak.TabIndex = 5;
            this.kontak.Text = "Contact Us\r\n\r\nE-Mail: clove@telkomuniversity.ac.id\r\nWhatsApp Khusus Dosen: +62 82" +
    "1-1666-3563\r\nWhatsApp Khusus Mahasiswa: +62 812-2200-1813";
            this.kontak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kontak.Click += new System.EventHandler(this.kontak_Click);
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.alamat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alamat.Location = new System.Drawing.Point(42, 418);
            this.alamat.Name = "alamat";
            this.alamat.Padding = new System.Windows.Forms.Padding(15, 0, 0, 20);
            this.alamat.Size = new System.Drawing.Size(158, 65);
            this.alamat.TabIndex = 4;
            this.alamat.Text = "Address\r\n\r\nGedung Panehan Pasca Sarjana Lantai 1,\r\nJl. Telekomunikasi Terusan Bua" +
    "h Batu,\r\nBandung - 40257, Indonesia";
            this.alamat.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelFasil
            // 
            this.panelFasil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelFasil.Controls.Add(this.sewaText);
            this.panelFasil.Controls.Add(this.pictureBox3);
            this.panelFasil.Controls.Add(this.pictureBox2);
            this.panelFasil.Controls.Add(this.pictureBox1);
            this.panelFasil.Location = new System.Drawing.Point(252, 299);
            this.panelFasil.Name = "panelFasil";
            this.panelFasil.Size = new System.Drawing.Size(654, 185);
            this.panelFasil.TabIndex = 3;
            this.panelFasil.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // sewaText
            // 
            this.sewaText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sewaText.AutoSize = true;
            this.sewaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sewaText.Location = new System.Drawing.Point(21, 16);
            this.sewaText.Name = "sewaText";
            this.sewaText.Size = new System.Drawing.Size(215, 13);
            this.sewaText.TabIndex = 3;
            this.sewaText.Text = "Jenis Fasilitas Yang Bisa Anda Sewa";
            this.sewaText.Click += new System.EventHandler(this.sewaText_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox3.Image = global::RentIt.Properties.Resources.olahraga1;
            this.pictureBox3.Location = new System.Drawing.Point(472, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::RentIt.Properties.Resources.kelas;
            this.pictureBox2.Location = new System.Drawing.Point(306, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::RentIt.Properties.Resources.gedung;
            this.pictureBox1.Location = new System.Drawing.Point(128, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainText
            // 
            this.mainText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainText.BackColor = System.Drawing.Color.IndianRed;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.mainText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainText.Location = new System.Drawing.Point(130, 83);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(848, 82);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "SELAMAT DATANG, MAU SEWA FASILITAS?\nMASUK PAKAI AKUN SSO DULU YUK!";
            this.mainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainText.Click += new System.EventHandler(this.label1_Click);
            // 
            // backgroundPic
            // 
            this.backgroundPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPic.Image = global::RentIt.Properties.Resources.pic1;
            this.backgroundPic.Location = new System.Drawing.Point(42, 11);
            this.backgroundPic.Name = "backgroundPic";
            this.backgroundPic.Size = new System.Drawing.Size(1058, 472);
            this.backgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundPic.TabIndex = 0;
            this.backgroundPic.TabStop = false;
            this.backgroundPic.Click += new System.EventHandler(this.roundedPictureBox1_Click);
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Left;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.home.Size = new System.Drawing.Size(111, 43);
            this.home.TabIndex = 1;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.logoTUTop);
            this.topPanel.Controls.Add(this.logoTop);
            this.topPanel.Controls.Add(this.facility);
            this.topPanel.Controls.Add(this.home);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1142, 43);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoTUTop
            // 
            this.logoTUTop.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoTUTop.Image = global::RentIt.Properties.Resources.Logo_Telkom_University_potrait;
            this.logoTUTop.Location = new System.Drawing.Point(1080, 0);
            this.logoTUTop.Name = "logoTUTop";
            this.logoTUTop.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.logoTUTop.Size = new System.Drawing.Size(62, 43);
            this.logoTUTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoTUTop.TabIndex = 0;
            this.logoTUTop.TabStop = false;
            this.logoTUTop.Click += new System.EventHandler(this.logoTUTop_Click);
            // 
            // logoTop
            // 
            this.logoTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoTop.Image = global::RentIt.Properties.Resources.babi;
            this.logoTop.Location = new System.Drawing.Point(523, 1);
            this.logoTop.Name = "logoTop";
            this.logoTop.Size = new System.Drawing.Size(189, 36);
            this.logoTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoTop.TabIndex = 2;
            this.logoTop.TabStop = false;
            this.logoTop.Click += new System.EventHandler(this.logoTop_Click);
            // 
            // facility
            // 
            this.facility.BackColor = System.Drawing.SystemColors.Control;
            this.facility.Dock = System.Windows.Forms.DockStyle.Left;
            this.facility.FlatAppearance.BorderSize = 0;
            this.facility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.facility.Location = new System.Drawing.Point(111, 0);
            this.facility.Name = "facility";
            this.facility.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.facility.Size = new System.Drawing.Size(118, 43);
            this.facility.TabIndex = 2;
            this.facility.Text = "Facility";
            this.facility.UseVisualStyleBackColor = false;
            this.facility.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jenis Fasilitas Yang Bisa Anda Sewa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kelas
            // 
            this.kelas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kelas.Image = global::RentIt.Properties.Resources.Untitled_design3;
            this.kelas.Location = new System.Drawing.Point(379, 61);
            this.kelas.Margin = new System.Windows.Forms.Padding(4);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(101, 89);
            this.kelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kelas.TabIndex = 4;
            this.kelas.TabStop = false;
            this.kelas.Click += new System.EventHandler(this.kelas_Click);
            // 
            // gedung
            // 
            this.gedung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gedung.Image = global::RentIt.Properties.Resources.gedung3;
            this.gedung.Location = new System.Drawing.Point(141, 61);
            this.gedung.Margin = new System.Windows.Forms.Padding(4);
            this.gedung.Name = "gedung";
            this.gedung.Size = new System.Drawing.Size(101, 89);
            this.gedung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gedung.TabIndex = 5;
            this.gedung.TabStop = false;
            this.gedung.Click += new System.EventHandler(this.gedung_Click);
            // 
            // olahraga
            // 
            this.olahraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.olahraga.Image = global::RentIt.Properties.Resources.olahraga2;
            this.olahraga.Location = new System.Drawing.Point(635, 64);
            this.olahraga.Margin = new System.Windows.Forms.Padding(4);
            this.olahraga.Name = "olahraga";
            this.olahraga.Size = new System.Drawing.Size(101, 89);
            this.olahraga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.olahraga.TabIndex = 6;
            this.olahraga.TabStop = false;
            this.olahraga.Click += new System.EventHandler(this.olahraga_Click);
            // 
            // MainPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 656);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "MainPageView";
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.twitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBottom)).EndInit();
            this.panelFasil.ResumeLayout(false);
            this.panelFasil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoTUTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gedung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olahraga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton SignInBut;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label loginMssg;
        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.PictureBox twitter;
        private System.Windows.Forms.PictureBox linkedin;
        private System.Windows.Forms.PictureBox instagram;
        private System.Windows.Forms.PictureBox facebook;
        private System.Windows.Forms.PictureBox logoBottom;
        private System.Windows.Forms.Label kontak;
        private System.Windows.Forms.Label alamat;
        private RoundedPanel panelFasil;
        private System.Windows.Forms.Label mainText;
        private RoundedPictureBox backgroundPic;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox logoTop;
        private System.Windows.Forms.PictureBox logoTUTop;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button facility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kelas;
        private System.Windows.Forms.PictureBox gedung;
        private System.Windows.Forms.PictureBox olahraga;
        private System.Windows.Forms.Label sewaText;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

