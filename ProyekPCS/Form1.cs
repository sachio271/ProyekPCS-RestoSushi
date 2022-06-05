using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyekPCS
{
    public partial class Form1 : Form
    {
        public static MySqlConnection conn;
        public static string nama;
        MySqlCommand com;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection();
            conn.ConnectionString = "server = localhost; uid = root; database = db_sushi";
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void custombutton1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            if (tbUsername.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Silahkan Inputkan Field yang kosong!");
            }
            else
            {
                com = new MySqlCommand("SELECT COUNT(*) FROM KARYAWAN WHERE USERNAME='" + tbUsername.Text + "' AND PASSWORD='" + tbPass.Text + "'", Form1.conn);
                int cek = Convert.ToInt32(com.ExecuteScalar().ToString());
                if (cek == 0)
                {
                    MessageBox.Show("Username atau password salah!");
                }
                else
                {
                    com = new MySqlCommand("SELECT NAMA FROM KARYAWAN WHERE USERNAME='" + tbUsername.Text + "' AND PASSWORD='" + tbPass.Text + "'", Form1.conn);
                    nama = com.ExecuteScalar().ToString();
                    com = new MySqlCommand("SELECT FK_JABATAN FROM KARYAWAN WHERE NAMA='" + nama + "'", Form1.conn);
                    int role = Convert.ToInt32(com.ExecuteScalar().ToString());
                    if (role == 2)
                    {
                        Karyawan k = new Karyawan();
                        k.ShowDialog();
                        tbUsername.Text = "";
                        tbPass.Text = "";
                        this.Hide();
                        this.Close();

                    }
                    else if (role == 1)
                    {

                        Admin a = new Admin();
                        a.ShowDialog();
                        tbUsername.Text = "";
                        tbPass.Text = "";
                        this.Hide();
                        this.Close();
                    }
                    else if (role == 3)
                    {

                        Koki o = new Koki();
                        o.ShowDialog();
                        tbUsername.Text = "";
                        tbPass.Text = "";
                        this.Hide();
                        this.Close();
                    }
                }
            }
        }

        
    }
}
