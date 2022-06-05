
namespace ProyekPCS
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new ProyekPCS.customtextbox();
            this.tbUsername = new ProyekPCS.customtextbox();
            this.custombutton1 = new ProyekPCS.custombutton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.label3.Location = new System.Drawing.Point(278, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restaurant Sushi";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.tbPass.BorderColor = System.Drawing.Color.Red;
            this.tbPass.BorderFocusColor = System.Drawing.Color.Red;
            this.tbPass.BorderSize = 2;
            this.tbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tbPass.ForeColor = System.Drawing.Color.Black;
            this.tbPass.IsFocused = false;
            this.tbPass.Location = new System.Drawing.Point(286, 244);
            this.tbPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPass.Multiline = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbPass.PasswordChar = true;
            this.tbPass.Size = new System.Drawing.Size(333, 35);
            this.tbPass.TabIndex = 8;
            this.tbPass.UnderlinedStyle = true;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.tbUsername.BorderColor = System.Drawing.Color.Red;
            this.tbUsername.BorderFocusColor = System.Drawing.Color.Red;
            this.tbUsername.BorderSize = 2;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.IsFocused = false;
            this.tbUsername.Location = new System.Drawing.Point(286, 168);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(7);
            this.tbUsername.PasswordChar = false;
            this.tbUsername.Size = new System.Drawing.Size(333, 35);
            this.tbUsername.TabIndex = 7;
            this.tbUsername.UnderlinedStyle = true;
            // 
            // custombutton1
            // 
            this.custombutton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.custombutton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.custombutton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custombutton1.BorderColor1 = System.Drawing.Color.PaleVioletRed;
            this.custombutton1.BorderRadius = 20;
            this.custombutton1.BorderRadius1 = 20;
            this.custombutton1.BorderSize = 0;
            this.custombutton1.BorderSize1 = 0;
            this.custombutton1.FlatAppearance.BorderSize = 0;
            this.custombutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custombutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custombutton1.ForeColor = System.Drawing.Color.White;
            this.custombutton1.Location = new System.Drawing.Point(286, 303);
            this.custombutton1.Name = "custombutton1";
            this.custombutton1.Size = new System.Drawing.Size(333, 60);
            this.custombutton1.TabIndex = 6;
            this.custombutton1.Text = "Submit";
            this.custombutton1.TextColor = System.Drawing.Color.White;
            this.custombutton1.UseVisualStyleBackColor = false;
            this.custombutton1.Click += new System.EventHandler(this.custombutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyekPCS.Properties.Resources.messageImage_1654230913883;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 415);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(697, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.custombutton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private custombutton custombutton1;
        private customtextbox tbUsername;
        private customtextbox tbPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

