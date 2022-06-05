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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            Tanggal.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Jam.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Tanggal.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Jam.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnTambahBahan_Click(object sender, EventArgs e)
        {
            tambahbahan1.prepareawal();
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            tambahbahan1.Show();
            tambahbahan1.BringToFront();
        }

        private void btnPemBahan_Click(object sender, EventArgs e)
        {
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            pembelianbahan1.Show();
            pembelianbahan1.BringToFront();
        }

        private void btnBahan_Click(object sender, EventArgs e)
        {
            bahantersedia1.prepareawal();
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            bahantersedia1.Show();
            bahantersedia1.BringToFront();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            memberadmin1.Show();
            memberadmin1.BringToFront();
        }

        private void btnLaba_Click(object sender, EventArgs e)
        {
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            laba1.Show();
            laba1.BringToFront();
        }

        private void btnPenggajian_Click(object sender, EventArgs e)
        {
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            penggajian1.Show();
            penggajian1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btnTambahKaryawan_Click(object sender, EventArgs e)
        {
            tambahkaryawan1.start();
            tambahbahan1.Hide();
            pembelianbahan1.Hide();
            bahantersedia1.Hide();
            memberadmin1.Hide();
            laba1.Hide();
            penggajian1.Hide();
            tambahkaryawan1.Hide();
            tambahkaryawan1.Show();
            tambahkaryawan1.BringToFront();
        }

        private void tambahkaryawan1_Load(object sender, EventArgs e)
        {
            lblkar.Text = Form1.nama;
        }
    }
}
