namespace RentIt.View.Admin_Proposal
{
    partial class Admin_ProposalView
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(713, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 52;
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
            this.redBox.TabIndex = 51;
            // 
            // facility
            // 
            this.facility.BackColor = System.Drawing.SystemColors.Control;
            this.facility.FlatAppearance.BorderSize = 0;
            this.facility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facility.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.facility.ForeColor = System.Drawing.Color.DarkRed;
            this.facility.Location = new System.Drawing.Point(589, 68);
            this.facility.Name = "facility";
            this.facility.Size = new System.Drawing.Size(118, 50);
            this.facility.TabIndex = 50;
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
            this.home.Location = new System.Drawing.Point(472, 68);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(111, 50);
            this.home.TabIndex = 49;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(279, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 385);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(272, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 61;
            this.label1.Text = "Proposal Peminjaman";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RentIt.Properties.Resources.babi;
            this.pictureBox3.Location = new System.Drawing.Point(156, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentIt.Properties.Resources.PP;
            this.pictureBox1.Location = new System.Drawing.Point(1004, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(135, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 313);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Admin_ProposalView
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
            this.Name = "Admin_ProposalView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_Proposal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}