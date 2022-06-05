
namespace ProyekPCS
{
    partial class tambahkaryawan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbKary = new ProyekPCS.customradio();
            this.btnClear = new ProyekPCS.custombutton();
            this.btnInsert = new ProyekPCS.custombutton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAdm = new ProyekPCS.customradio();
            this.rbKoki = new ProyekPCS.customradio();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbWanita = new ProyekPCS.customradio();
            this.rbPria = new ProyekPCS.customradio();
            this.dtLahir = new ProyekPCS.customdate();
            this.tbNama = new ProyekPCS.customtextbox();
            this.tbAlamat = new ProyekPCS.customtextbox();
            this.tbEmail = new ProyekPCS.customtextbox();
            this.tbNo = new ProyekPCS.customtextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "No Telp :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tanggal Lahir :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Jabatan :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 596);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 64);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tambah Karyawan";
            // 
            // rbKary
            // 
            this.rbKary.Checked = true;
            this.rbKary.CheckedColor = System.Drawing.Color.Black;
            this.rbKary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKary.Location = new System.Drawing.Point(3, 8);
            this.rbKary.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbKary.Name = "rbKary";
            this.rbKary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbKary.Size = new System.Drawing.Size(123, 27);
            this.rbKary.TabIndex = 21;
            this.rbKary.TabStop = true;
            this.rbKary.Text = "Karyawan";
            this.rbKary.UnCheckedColor = System.Drawing.Color.Turquoise;
            this.rbKary.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.BackgroundColor = System.Drawing.Color.Red;
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.BorderColor1 = System.Drawing.Color.Black;
            this.btnClear.BorderRadius = 10;
            this.btnClear.BorderRadius1 = 10;
            this.btnClear.BorderSize = 2;
            this.btnClear.BorderSize1 = 2;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(287, 586);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 96);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.BackgroundColor = System.Drawing.Color.Green;
            this.btnInsert.BorderColor = System.Drawing.Color.Black;
            this.btnInsert.BorderColor1 = System.Drawing.Color.Black;
            this.btnInsert.BorderRadius = 10;
            this.btnInsert.BorderRadius1 = 10;
            this.btnInsert.BorderSize = 2;
            this.btnInsert.BorderSize1 = 2;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(64, 586);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(177, 96);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbAdm);
            this.panel2.Controls.Add(this.rbKoki);
            this.panel2.Controls.Add(this.rbKary);
            this.panel2.Location = new System.Drawing.Point(175, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 37);
            this.panel2.TabIndex = 22;
            // 
            // rbAdm
            // 
            this.rbAdm.CheckedColor = System.Drawing.Color.Black;
            this.rbAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdm.Location = new System.Drawing.Point(223, 8);
            this.rbAdm.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbAdm.Name = "rbAdm";
            this.rbAdm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbAdm.Size = new System.Drawing.Size(99, 27);
            this.rbAdm.TabIndex = 23;
            this.rbAdm.Text = "Admin";
            this.rbAdm.UnCheckedColor = System.Drawing.Color.Green;
            this.rbAdm.UseVisualStyleBackColor = true;
            // 
            // rbKoki
            // 
            this.rbKoki.CheckedColor = System.Drawing.Color.Black;
            this.rbKoki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKoki.Location = new System.Drawing.Point(132, 8);
            this.rbKoki.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbKoki.Name = "rbKoki";
            this.rbKoki.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbKoki.Size = new System.Drawing.Size(85, 27);
            this.rbKoki.TabIndex = 22;
            this.rbKoki.Text = "Koki";
            this.rbKoki.UnCheckedColor = System.Drawing.Color.Red;
            this.rbKoki.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbWanita);
            this.panel3.Controls.Add(this.rbPria);
            this.panel3.Location = new System.Drawing.Point(175, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 39);
            this.panel3.TabIndex = 23;
            // 
            // rbWanita
            // 
            this.rbWanita.CheckedColor = System.Drawing.Color.Black;
            this.rbWanita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWanita.Location = new System.Drawing.Point(132, 6);
            this.rbWanita.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbWanita.Name = "rbWanita";
            this.rbWanita.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbWanita.Size = new System.Drawing.Size(111, 27);
            this.rbWanita.TabIndex = 22;
            this.rbWanita.Text = "Wanita";
            this.rbWanita.UnCheckedColor = System.Drawing.Color.DeepPink;
            this.rbWanita.UseVisualStyleBackColor = true;
            // 
            // rbPria
            // 
            this.rbPria.Checked = true;
            this.rbPria.CheckedColor = System.Drawing.Color.Black;
            this.rbPria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPria.Location = new System.Drawing.Point(3, 6);
            this.rbPria.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbPria.Name = "rbPria";
            this.rbPria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbPria.Size = new System.Drawing.Size(123, 27);
            this.rbPria.TabIndex = 21;
            this.rbPria.TabStop = true;
            this.rbPria.Text = "Pria";
            this.rbPria.UnCheckedColor = System.Drawing.Color.MediumBlue;
            this.rbPria.UseVisualStyleBackColor = true;
            // 
            // dtLahir
            // 
            this.dtLahir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtLahir.BorderSize = 0;
            this.dtLahir.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtLahir.Location = new System.Drawing.Point(175, 337);
            this.dtLahir.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtLahir.Name = "dtLahir";
            this.dtLahir.Size = new System.Drawing.Size(313, 35);
            this.dtLahir.SkinColor = System.Drawing.Color.White;
            this.dtLahir.TabIndex = 24;
            this.dtLahir.TextColor = System.Drawing.Color.Black;
            // 
            // tbNama
            // 
            this.tbNama.BackColor = System.Drawing.SystemColors.Window;
            this.tbNama.BorderColor = System.Drawing.Color.Red;
            this.tbNama.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNama.BorderSize = 3;
            this.tbNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.ForeColor = System.Drawing.Color.Black;
            this.tbNama.IsFocused = false;
            this.tbNama.Location = new System.Drawing.Point(175, 100);
            this.tbNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNama.Multiline = false;
            this.tbNama.Name = "tbNama";
            this.tbNama.Padding = new System.Windows.Forms.Padding(7);
            this.tbNama.PasswordChar = false;
            this.tbNama.Size = new System.Drawing.Size(313, 40);
            this.tbNama.TabIndex = 25;
            this.tbNama.UnderlinedStyle = true;
            // 
            // tbAlamat
            // 
            this.tbAlamat.BackColor = System.Drawing.SystemColors.Window;
            this.tbAlamat.BorderColor = System.Drawing.Color.Red;
            this.tbAlamat.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbAlamat.BorderSize = 3;
            this.tbAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlamat.ForeColor = System.Drawing.Color.Black;
            this.tbAlamat.IsFocused = false;
            this.tbAlamat.Location = new System.Drawing.Point(175, 191);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAlamat.Multiline = false;
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Padding = new System.Windows.Forms.Padding(7);
            this.tbAlamat.PasswordChar = false;
            this.tbAlamat.Size = new System.Drawing.Size(313, 40);
            this.tbAlamat.TabIndex = 26;
            this.tbAlamat.UnderlinedStyle = true;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbEmail.BorderColor = System.Drawing.Color.Red;
            this.tbEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbEmail.BorderSize = 3;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.IsFocused = false;
            this.tbEmail.Location = new System.Drawing.Point(175, 242);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Padding = new System.Windows.Forms.Padding(7);
            this.tbEmail.PasswordChar = false;
            this.tbEmail.Size = new System.Drawing.Size(313, 40);
            this.tbEmail.TabIndex = 27;
            this.tbEmail.UnderlinedStyle = true;
            // 
            // tbNo
            // 
            this.tbNo.BackColor = System.Drawing.SystemColors.Window;
            this.tbNo.BorderColor = System.Drawing.Color.Red;
            this.tbNo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNo.BorderSize = 3;
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNo.ForeColor = System.Drawing.Color.Black;
            this.tbNo.IsFocused = false;
            this.tbNo.Location = new System.Drawing.Point(175, 290);
            this.tbNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNo.Multiline = false;
            this.tbNo.Name = "tbNo";
            this.tbNo.Padding = new System.Windows.Forms.Padding(7);
            this.tbNo.PasswordChar = false;
            this.tbNo.Size = new System.Drawing.Size(313, 40);
            this.tbNo.TabIndex = 28;
            this.tbNo.UnderlinedStyle = true;
            // 
            // tambahkaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(155)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.tbNo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.dtLahir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "tambahkaryawan";
            this.Size = new System.Drawing.Size(1092, 731);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private custombutton btnInsert;
        private custombutton btnClear;
        private customradio rbKary;
        private System.Windows.Forms.Panel panel2;
        private customradio rbKoki;
        private customradio rbAdm;
        private System.Windows.Forms.Panel panel3;
        private customradio rbWanita;
        private customradio rbPria;
        private customdate dtLahir;
        private customtextbox tbNama;
        private customtextbox tbAlamat;
        private customtextbox tbEmail;
        private customtextbox tbNo;
    }
}
