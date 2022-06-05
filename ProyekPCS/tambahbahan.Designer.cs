
namespace ProyekPCS
{
    partial class tambahbahan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsubtotal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblgrand = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSup = new ProyekPCS.customcombo();
            this.comboBahan = new ProyekPCS.customcombo();
            this.tbHargaSatuan = new ProyekPCS.customtextbox();
            this.btnReset = new ProyekPCS.custombutton();
            this.btnAdd = new ProyekPCS.custombutton();
            this.btnBuy = new ProyekPCS.custombutton();
            this.btnClear = new ProyekPCS.custombutton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(535, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 596);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Merk";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Harga";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "id";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Supplier : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nama Bahan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Harga Satuan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Total :";
            // 
            // tbsubtotal
            // 
            this.tbsubtotal.AutoSize = true;
            this.tbsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsubtotal.Location = new System.Drawing.Point(196, 203);
            this.tbsubtotal.Name = "tbsubtotal";
            this.tbsubtotal.Size = new System.Drawing.Size(23, 25);
            this.tbsubtotal.TabIndex = 41;
            this.tbsubtotal.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(152, 157);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 30);
            this.numericUpDown1.TabIndex = 42;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(153, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Rp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Rp.";
            // 
            // lblgrand
            // 
            this.lblgrand.AutoSize = true;
            this.lblgrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrand.Location = new System.Drawing.Point(196, 382);
            this.lblgrand.Name = "lblgrand";
            this.lblgrand.Size = new System.Drawing.Size(23, 25);
            this.lblgrand.TabIndex = 45;
            this.lblgrand.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "Grand Total : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 64);
            this.panel1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(31, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 46);
            this.label8.TabIndex = 1;
            this.label8.Text = "Beli Bahan";
            // 
            // comboSup
            // 
            this.comboSup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboSup.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboSup.BorderSize = 2;
            this.comboSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboSup.ForeColor = System.Drawing.Color.Black;
            this.comboSup.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboSup.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboSup.ListTextColor = System.Drawing.Color.DimGray;
            this.comboSup.Location = new System.Drawing.Point(152, 324);
            this.comboSup.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboSup.Name = "comboSup";
            this.comboSup.Padding = new System.Windows.Forms.Padding(2);
            this.comboSup.Size = new System.Drawing.Size(348, 38);
            this.comboSup.TabIndex = 54;
            // 
            // comboBahan
            // 
            this.comboBahan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBahan.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBahan.BorderSize = 2;
            this.comboBahan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBahan.ForeColor = System.Drawing.Color.Black;
            this.comboBahan.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.comboBahan.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBahan.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBahan.Location = new System.Drawing.Point(152, 110);
            this.comboBahan.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBahan.Name = "comboBahan";
            this.comboBahan.Padding = new System.Windows.Forms.Padding(2);
            this.comboBahan.Size = new System.Drawing.Size(354, 36);
            this.comboBahan.TabIndex = 53;
            this.comboBahan.OnSelectedIndexChanged += new System.EventHandler(this.comboBahan_OnSelectedIndexChanged);
            // 
            // tbHargaSatuan
            // 
            this.tbHargaSatuan.BackColor = System.Drawing.SystemColors.Window;
            this.tbHargaSatuan.BorderColor = System.Drawing.Color.Red;
            this.tbHargaSatuan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbHargaSatuan.BorderSize = 2;
            this.tbHargaSatuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaSatuan.ForeColor = System.Drawing.Color.Black;
            this.tbHargaSatuan.IsFocused = false;
            this.tbHargaSatuan.Location = new System.Drawing.Point(371, 155);
            this.tbHargaSatuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHargaSatuan.Multiline = false;
            this.tbHargaSatuan.Name = "tbHargaSatuan";
            this.tbHargaSatuan.Padding = new System.Windows.Forms.Padding(7);
            this.tbHargaSatuan.PasswordChar = false;
            this.tbHargaSatuan.Size = new System.Drawing.Size(135, 35);
            this.tbHargaSatuan.TabIndex = 52;
            this.tbHargaSatuan.UnderlinedStyle = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkRed;
            this.btnReset.BackgroundColor = System.Drawing.Color.DarkRed;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.BorderColor1 = System.Drawing.Color.Black;
            this.btnReset.BorderRadius = 10;
            this.btnReset.BorderRadius1 = 10;
            this.btnReset.BorderSize = 2;
            this.btnReset.BorderSize1 = 2;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(270, 248);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(217, 51);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderColor1 = System.Drawing.Color.Black;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderRadius1 = 10;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.BorderSize1 = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(36, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 51);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Green;
            this.btnBuy.BackgroundColor = System.Drawing.Color.Green;
            this.btnBuy.BorderColor = System.Drawing.Color.Black;
            this.btnBuy.BorderColor1 = System.Drawing.Color.Black;
            this.btnBuy.BorderRadius = 10;
            this.btnBuy.BorderRadius1 = 10;
            this.btnBuy.BorderSize = 2;
            this.btnBuy.BorderSize1 = 2;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(21, 578);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(485, 61);
            this.btnBuy.TabIndex = 55;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextColor = System.Drawing.Color.White;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(21, 645);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(485, 61);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.TextColor = System.Drawing.Color.White;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tambahbahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(155)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.comboSup);
            this.Controls.Add(this.comboBahan);
            this.Controls.Add(this.tbHargaSatuan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblgrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tbsubtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "tambahbahan";
            this.Size = new System.Drawing.Size(1092, 734);
            this.Load += new System.EventHandler(this.tambahbahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbsubtotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblgrand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private custombutton btnAdd;
        private custombutton btnReset;
        private customtextbox tbHargaSatuan;
        private customcombo comboBahan;
        private customcombo comboSup;
        private custombutton btnBuy;
        private custombutton btnClear;
    }
}
