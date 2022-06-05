
namespace ProyekPCS
{
    partial class order
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
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbshopee = new ProyekPCS.customradio();
            this.rbcash = new ProyekPCS.customradio();
            this.rbdebit = new ProyekPCS.customradio();
            this.rbovo = new ProyekPCS.customradio();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblgrand = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.custombutton2 = new ProyekPCS.custombutton();
            this.custombutton1 = new ProyekPCS.custombutton();
            this.cbcust = new ProyekPCS.customcombo();
            this.cbjenis = new ProyekPCS.customcombo();
            this.tbsearch = new ProyekPCS.customtextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMenu
            // 
            this.dgMenu.AllowUserToAddRows = false;
            this.dgMenu.AllowUserToDeleteRows = false;
            this.dgMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMenu.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.Location = new System.Drawing.Point(31, 64);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.ReadOnly = true;
            this.dgMenu.RowHeadersWidth = 51;
            this.dgMenu.RowTemplate.Height = 24;
            this.dgMenu.Size = new System.Drawing.Size(1036, 268);
            this.dgMenu.TabIndex = 0;
            this.dgMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellDoubleClick);
            // 
            // dgCart
            // 
            this.dgCart.AllowUserToAddRows = false;
            this.dgCart.AllowUserToDeleteRows = false;
            this.dgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCart.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgCart.Location = new System.Drawing.Point(525, 391);
            this.dgCart.Name = "dgCart";
            this.dgCart.ReadOnly = true;
            this.dgCart.RowHeadersWidth = 51;
            this.dgCart.RowTemplate.Height = 24;
            this.dgCart.Size = new System.Drawing.Size(542, 311);
            this.dgCart.TabIndex = 2;
            this.dgCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCart_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Menu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subtotal";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "id";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Menu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(694, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jenis Menu : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbshopee);
            this.groupBox1.Controls.Add(this.rbcash);
            this.groupBox1.Controls.Add(this.rbdebit);
            this.groupBox1.Controls.Add(this.rbovo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metode Pembayaran";
            // 
            // rbshopee
            // 
            this.rbshopee.AutoSize = true;
            this.rbshopee.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbshopee.Location = new System.Drawing.Point(347, 52);
            this.rbshopee.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbshopee.Name = "rbshopee";
            this.rbshopee.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbshopee.Size = new System.Drawing.Size(124, 24);
            this.rbshopee.TabIndex = 21;
            this.rbshopee.Text = "ShopeePay";
            this.rbshopee.UnCheckedColor = System.Drawing.Color.Black;
            this.rbshopee.UseVisualStyleBackColor = true;
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Checked = true;
            this.rbcash.CheckedColor = System.Drawing.Color.LimeGreen;
            this.rbcash.Location = new System.Drawing.Point(11, 52);
            this.rbcash.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbcash.Name = "rbcash";
            this.rbcash.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbcash.Size = new System.Drawing.Size(79, 24);
            this.rbcash.TabIndex = 20;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Cash";
            this.rbcash.UnCheckedColor = System.Drawing.Color.Black;
            this.rbcash.UseVisualStyleBackColor = true;
            // 
            // rbdebit
            // 
            this.rbdebit.AutoSize = true;
            this.rbdebit.CheckedColor = System.Drawing.Color.Red;
            this.rbdebit.Location = new System.Drawing.Point(116, 52);
            this.rbdebit.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbdebit.Name = "rbdebit";
            this.rbdebit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbdebit.Size = new System.Drawing.Size(80, 24);
            this.rbdebit.TabIndex = 23;
            this.rbdebit.Text = "Debit";
            this.rbdebit.UnCheckedColor = System.Drawing.Color.Black;
            this.rbdebit.UseVisualStyleBackColor = true;
            // 
            // rbovo
            // 
            this.rbovo.AutoSize = true;
            this.rbovo.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbovo.Location = new System.Drawing.Point(236, 52);
            this.rbovo.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbovo.Name = "rbovo";
            this.rbovo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbovo.Size = new System.Drawing.Size(77, 24);
            this.rbovo.TabIndex = 22;
            this.rbovo.Text = "OVO";
            this.rbovo.UnCheckedColor = System.Drawing.Color.Black;
            this.rbovo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grand Total : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rp. ";
            // 
            // lblgrand
            // 
            this.lblgrand.AutoSize = true;
            this.lblgrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrand.Location = new System.Drawing.Point(224, 434);
            this.lblgrand.Name = "lblgrand";
            this.lblgrand.Size = new System.Drawing.Size(18, 20);
            this.lblgrand.TabIndex = 13;
            this.lblgrand.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nama Customer : ";
            // 
            // custombutton2
            // 
            this.custombutton2.BackColor = System.Drawing.Color.Green;
            this.custombutton2.BackgroundColor = System.Drawing.Color.Green;
            this.custombutton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custombutton2.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.custombutton2.BorderRadius = 20;
            this.custombutton2.BorderRadius1 = 20;
            this.custombutton2.BorderSize = 0;
            this.custombutton2.BorderSize1 = 0;
            this.custombutton2.FlatAppearance.BorderSize = 0;
            this.custombutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custombutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custombutton2.ForeColor = System.Drawing.Color.White;
            this.custombutton2.Location = new System.Drawing.Point(20, 643);
            this.custombutton2.Name = "custombutton2";
            this.custombutton2.Size = new System.Drawing.Size(488, 40);
            this.custombutton2.TabIndex = 21;
            this.custombutton2.Text = "Clear Order";
            this.custombutton2.TextColor = System.Drawing.Color.White;
            this.custombutton2.UseVisualStyleBackColor = false;
            this.custombutton2.Click += new System.EventHandler(this.custombutton2_Click);
            // 
            // custombutton1
            // 
            this.custombutton1.BackColor = System.Drawing.Color.Green;
            this.custombutton1.BackgroundColor = System.Drawing.Color.Green;
            this.custombutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custombutton1.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.custombutton1.BorderRadius = 20;
            this.custombutton1.BorderRadius1 = 20;
            this.custombutton1.BorderSize = 0;
            this.custombutton1.BorderSize1 = 0;
            this.custombutton1.FlatAppearance.BorderSize = 0;
            this.custombutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custombutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custombutton1.ForeColor = System.Drawing.Color.White;
            this.custombutton1.Location = new System.Drawing.Point(20, 589);
            this.custombutton1.Name = "custombutton1";
            this.custombutton1.Size = new System.Drawing.Size(488, 40);
            this.custombutton1.TabIndex = 20;
            this.custombutton1.Text = "Confirm Order";
            this.custombutton1.TextColor = System.Drawing.Color.White;
            this.custombutton1.UseVisualStyleBackColor = false;
            this.custombutton1.Click += new System.EventHandler(this.custombutton1_Click);
            // 
            // cbcust
            // 
            this.cbcust.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbcust.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbcust.BorderSize = 1;
            this.cbcust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcust.ForeColor = System.Drawing.Color.DimGray;
            this.cbcust.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbcust.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbcust.ListTextColor = System.Drawing.Color.DimGray;
            this.cbcust.Location = new System.Drawing.Point(179, 391);
            this.cbcust.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbcust.Name = "cbcust";
            this.cbcust.Padding = new System.Windows.Forms.Padding(1);
            this.cbcust.Size = new System.Drawing.Size(340, 30);
            this.cbcust.TabIndex = 19;
            // 
            // cbjenis
            // 
            this.cbjenis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbjenis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbjenis.BorderSize = 1;
            this.cbjenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbjenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbjenis.ForeColor = System.Drawing.Color.DimGray;
            this.cbjenis.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbjenis.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbjenis.ListTextColor = System.Drawing.Color.DimGray;
            this.cbjenis.Location = new System.Drawing.Point(800, 28);
            this.cbjenis.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Padding = new System.Windows.Forms.Padding(1);
            this.cbjenis.Size = new System.Drawing.Size(267, 30);
            this.cbjenis.TabIndex = 18;
            // 
            // tbsearch
            // 
            this.tbsearch.BackColor = System.Drawing.SystemColors.Window;
            this.tbsearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbsearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbsearch.BorderSize = 2;
            this.tbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.ForeColor = System.Drawing.Color.DimGray;
            this.tbsearch.IsFocused = false;
            this.tbsearch.Location = new System.Drawing.Point(136, 26);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbsearch.Multiline = false;
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Padding = new System.Windows.Forms.Padding(7);
            this.tbsearch.PasswordChar = false;
            this.tbsearch.Size = new System.Drawing.Size(444, 32);
            this.tbsearch.TabIndex = 17;
            this.tbsearch.UnderlinedStyle = true;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(155)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.custombutton2);
            this.Controls.Add(this.custombutton1);
            this.Controls.Add(this.cbcust);
            this.Controls.Add(this.cbjenis);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblgrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgCart);
            this.Controls.Add(this.dgMenu);
            this.Name = "order";
            this.Size = new System.Drawing.Size(1092, 734);
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.DataGridView dgCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private customtextbox tbsearch;
        private customradio rbshopee;
        private customradio rbcash;
        private customradio rbdebit;
        private customradio rbovo;
        private customcombo cbjenis;
        private customcombo cbcust;
        private custombutton custombutton1;
        private custombutton custombutton2;
    }
}
