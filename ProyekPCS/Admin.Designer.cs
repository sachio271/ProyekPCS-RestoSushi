
namespace ProyekPCS
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblkar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTambahKaryawan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPenggajian = new System.Windows.Forms.Button();
            this.btnPemBahan = new System.Windows.Forms.Button();
            this.btnLaba = new System.Windows.Forms.Button();
            this.btnBahan = new System.Windows.Forms.Button();
            this.Jam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tanggal = new System.Windows.Forms.Label();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnTambahBahan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tambahkaryawan1 = new ProyekPCS.tambahkaryawan();
            this.penggajian1 = new ProyekPCS.penggajian();
            this.laba1 = new ProyekPCS.laba();
            this.memberadmin1 = new ProyekPCS.memberadmin();
            this.bahantersedia1 = new ProyekPCS.bahantersedia();
            this.pembelianbahan1 = new ProyekPCS.pembelianbahan();
            this.tambahbahan1 = new ProyekPCS.tambahbahan();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblkar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTambahKaryawan);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPenggajian);
            this.panel1.Controls.Add(this.btnPemBahan);
            this.panel1.Controls.Add(this.btnLaba);
            this.panel1.Controls.Add(this.btnBahan);
            this.panel1.Controls.Add(this.Jam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Tanggal);
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.btnTambahBahan);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 734);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Felix Titling", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Restaurant Sushi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ProyekPCS.Properties.Resources.messageImage_1654230913883;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblkar
            // 
            this.lblkar.AutoSize = true;
            this.lblkar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkar.ForeColor = System.Drawing.Color.White;
            this.lblkar.Location = new System.Drawing.Point(12, 592);
            this.lblkar.Name = "lblkar";
            this.lblkar.Size = new System.Drawing.Size(124, 21);
            this.lblkar.TabIndex = 18;
            this.lblkar.Text = "Nama Karyawan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(11, 571);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Karyawan :";
            // 
            // btnTambahKaryawan
            // 
            this.btnTambahKaryawan.FlatAppearance.BorderSize = 0;
            this.btnTambahKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnTambahKaryawan.Image = global::ProyekPCS.Properties.Resources.user_add_free_icon_font;
            this.btnTambahKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahKaryawan.Location = new System.Drawing.Point(0, 165);
            this.btnTambahKaryawan.Name = "btnTambahKaryawan";
            this.btnTambahKaryawan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTambahKaryawan.Size = new System.Drawing.Size(269, 47);
            this.btnTambahKaryawan.TabIndex = 16;
            this.btnTambahKaryawan.Text = "  Tambah Karyawan";
            this.btnTambahKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambahKaryawan.UseVisualStyleBackColor = true;
            this.btnTambahKaryawan.Click += new System.EventHandler(this.btnTambahKaryawan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProyekPCS.Properties.Resources.sign_out_free_icon_font;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 682);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(272, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "        Logout";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPenggajian
            // 
            this.btnPenggajian.FlatAppearance.BorderSize = 0;
            this.btnPenggajian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenggajian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenggajian.ForeColor = System.Drawing.Color.White;
            this.btnPenggajian.Image = global::ProyekPCS.Properties.Resources.money_check_edit_free_icon_font;
            this.btnPenggajian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenggajian.Location = new System.Drawing.Point(0, 399);
            this.btnPenggajian.Name = "btnPenggajian";
            this.btnPenggajian.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPenggajian.Size = new System.Drawing.Size(269, 47);
            this.btnPenggajian.TabIndex = 14;
            this.btnPenggajian.Text = "  Penggajian";
            this.btnPenggajian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPenggajian.UseVisualStyleBackColor = true;
            this.btnPenggajian.Click += new System.EventHandler(this.btnPenggajian_Click);
            // 
            // btnPemBahan
            // 
            this.btnPemBahan.FlatAppearance.BorderSize = 0;
            this.btnPemBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPemBahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPemBahan.ForeColor = System.Drawing.Color.White;
            this.btnPemBahan.Image = global::ProyekPCS.Properties.Resources.document_signed_free_icon_font1;
            this.btnPemBahan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPemBahan.Location = new System.Drawing.Point(0, 258);
            this.btnPemBahan.Name = "btnPemBahan";
            this.btnPemBahan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPemBahan.Size = new System.Drawing.Size(269, 47);
            this.btnPemBahan.TabIndex = 13;
            this.btnPemBahan.Text = "  Pembelian Bahan";
            this.btnPemBahan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPemBahan.UseVisualStyleBackColor = true;
            this.btnPemBahan.Click += new System.EventHandler(this.btnPemBahan_Click);
            // 
            // btnLaba
            // 
            this.btnLaba.FlatAppearance.BorderSize = 0;
            this.btnLaba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaba.ForeColor = System.Drawing.Color.White;
            this.btnLaba.Image = global::ProyekPCS.Properties.Resources.chart_histogram_free_icon_font;
            this.btnLaba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaba.Location = new System.Drawing.Point(0, 352);
            this.btnLaba.Name = "btnLaba";
            this.btnLaba.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLaba.Size = new System.Drawing.Size(269, 47);
            this.btnLaba.TabIndex = 12;
            this.btnLaba.Text = "  Laba";
            this.btnLaba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaba.UseVisualStyleBackColor = true;
            this.btnLaba.Click += new System.EventHandler(this.btnLaba_Click);
            // 
            // btnBahan
            // 
            this.btnBahan.FlatAppearance.BorderSize = 0;
            this.btnBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBahan.ForeColor = System.Drawing.Color.White;
            this.btnBahan.Image = global::ProyekPCS.Properties.Resources.wheat_free_icon_font;
            this.btnBahan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBahan.Location = new System.Drawing.Point(0, 211);
            this.btnBahan.Name = "btnBahan";
            this.btnBahan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBahan.Size = new System.Drawing.Size(269, 47);
            this.btnBahan.TabIndex = 11;
            this.btnBahan.Text = "  Stok Bahan";
            this.btnBahan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBahan.UseVisualStyleBackColor = true;
            this.btnBahan.Click += new System.EventHandler(this.btnBahan_Click);
            // 
            // Jam
            // 
            this.Jam.AutoSize = true;
            this.Jam.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jam.ForeColor = System.Drawing.Color.White;
            this.Jam.Location = new System.Drawing.Point(116, 652);
            this.Jam.Name = "Jam";
            this.Jam.Size = new System.Drawing.Size(38, 17);
            this.Jam.TabIndex = 10;
            this.Jam.Text = "Jam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jam :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tanggal :";
            // 
            // Tanggal
            // 
            this.Tanggal.AutoSize = true;
            this.Tanggal.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanggal.ForeColor = System.Drawing.Color.White;
            this.Tanggal.Location = new System.Drawing.Point(116, 633);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(78, 17);
            this.Tanggal.TabIndex = 7;
            this.Tanggal.Text = "Tanggal";
            // 
            // btnMember
            // 
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Image = global::ProyekPCS.Properties.Resources.users_alt_free_icon_font;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 305);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMember.Size = new System.Drawing.Size(269, 47);
            this.btnMember.TabIndex = 6;
            this.btnMember.Text = "  Member";
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnTambahBahan
            // 
            this.btnTambahBahan.FlatAppearance.BorderSize = 0;
            this.btnTambahBahan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahBahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahBahan.ForeColor = System.Drawing.Color.White;
            this.btnTambahBahan.Image = global::ProyekPCS.Properties.Resources.shopping_cart_add_free_icon_font;
            this.btnTambahBahan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTambahBahan.Location = new System.Drawing.Point(0, 117);
            this.btnTambahBahan.Name = "btnTambahBahan";
            this.btnTambahBahan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTambahBahan.Size = new System.Drawing.Size(269, 47);
            this.btnTambahBahan.TabIndex = 0;
            this.btnTambahBahan.Text = "  Beli Bahan";
            this.btnTambahBahan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambahBahan.UseVisualStyleBackColor = true;
            this.btnTambahBahan.Click += new System.EventHandler(this.btnTambahBahan_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Silahkan Pilih Opsi di bagian Kiri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(593, 46);
            this.label5.TabIndex = 15;
            this.label5.Text = "Silahkan Pilih Opsi di bagian Kiri";
            // 
            // tambahkaryawan1
            // 
            this.tambahkaryawan1.Location = new System.Drawing.Point(266, 0);
            this.tambahkaryawan1.Name = "tambahkaryawan1";
            this.tambahkaryawan1.Size = new System.Drawing.Size(1092, 731);
            this.tambahkaryawan1.TabIndex = 16;
            this.tambahkaryawan1.Load += new System.EventHandler(this.tambahkaryawan1_Load);
            // 
            // penggajian1
            // 
            this.penggajian1.Location = new System.Drawing.Point(266, 0);
            this.penggajian1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.penggajian1.Name = "penggajian1";
            this.penggajian1.Size = new System.Drawing.Size(1092, 734);
            this.penggajian1.TabIndex = 14;
            // 
            // laba1
            // 
            this.laba1.Location = new System.Drawing.Point(266, 0);
            this.laba1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.laba1.Name = "laba1";
            this.laba1.Size = new System.Drawing.Size(1092, 731);
            this.laba1.TabIndex = 13;
            // 
            // memberadmin1
            // 
            this.memberadmin1.Location = new System.Drawing.Point(266, 0);
            this.memberadmin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memberadmin1.Name = "memberadmin1";
            this.memberadmin1.Size = new System.Drawing.Size(1092, 731);
            this.memberadmin1.TabIndex = 12;
            // 
            // bahantersedia1
            // 
            this.bahantersedia1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bahantersedia1.Location = new System.Drawing.Point(266, 0);
            this.bahantersedia1.Name = "bahantersedia1";
            this.bahantersedia1.Size = new System.Drawing.Size(1092, 731);
            this.bahantersedia1.TabIndex = 11;
            // 
            // pembelianbahan1
            // 
            this.pembelianbahan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pembelianbahan1.Location = new System.Drawing.Point(266, 0);
            this.pembelianbahan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pembelianbahan1.Name = "pembelianbahan1";
            this.pembelianbahan1.Size = new System.Drawing.Size(1092, 731);
            this.pembelianbahan1.TabIndex = 10;
            // 
            // tambahbahan1
            // 
            this.tambahbahan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tambahbahan1.Location = new System.Drawing.Point(266, 0);
            this.tambahbahan1.Name = "tambahbahan1";
            this.tambahbahan1.Size = new System.Drawing.Size(1092, 731);
            this.tambahbahan1.TabIndex = 9;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 732);
            this.Controls.Add(this.tambahkaryawan1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.penggajian1);
            this.Controls.Add(this.laba1);
            this.Controls.Add(this.memberadmin1);
            this.Controls.Add(this.bahantersedia1);
            this.Controls.Add(this.pembelianbahan1);
            this.Controls.Add(this.tambahbahan1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tanggal;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTambahBahan;
        private System.Windows.Forms.Button btnPenggajian;
        private System.Windows.Forms.Button btnPemBahan;
        private System.Windows.Forms.Button btnLaba;
        private System.Windows.Forms.Button btnBahan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private tambahbahan tambahbahan1;
        private pembelianbahan pembelianbahan1;
        private bahantersedia bahantersedia1;
        private memberadmin memberadmin1;
        private laba laba1;
        private penggajian penggajian1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTambahKaryawan;
        private tambahkaryawan tambahkaryawan1;
        private System.Windows.Forms.Label lblkar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}