using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekPCS
{
    public partial class Karyawan : Form
    {
        public Karyawan()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            order1.prepareawal();
            member1.Hide();
            order1.Show();
            order1.BringToFront();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            member1.prepareawal();
            order1.Hide();
            member1.Show();
            member1.BringToFront();
        }

        private void Karyawan_Load(object sender, EventArgs e)
        {
            lbNama.Text = Form1.nama;
            order1.Hide();
            member1.Hide();
            Tanggal.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Jam.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tanggal.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Jam.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
