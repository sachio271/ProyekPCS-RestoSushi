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
    public partial class tambahkaryawan : UserControl
    {
        MySqlConnection conn;
        DataTable dt;
        MySqlCommand com;
        MySqlDataAdapter da;
        public tambahkaryawan()
        {
            InitializeComponent();
            conn = Form1.conn;

            btnInsert.Cursor = Cursors.Hand;
            btnClear.Cursor = Cursors.Hand;
        }

        public void start()
        {
            cekState();
            loadDataGrid();
        }

        public void cekState()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void loadDataGrid()
        {
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "select k.id as ID," +
                " k.kode as Kode," +
                " k.nama as Nama," +
                " j.nama_jabatan as 'Jabatan'," +
                " case when k.status=1 then 'Aktif' else 'Tidak Aktif' end as Status" +
                " from karyawan k, jabatan j" +
                " where k.fk_jabatan = j.id";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            tbAlamat.Text = "";
            tbNama.Text = "";
            tbEmail.Text = "";
            tbNo.Text = "";
            dtLahir.Value = DateTime.Now;
            rbPria.Checked = true;
            rbKary.Checked = true;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cekState();
                com = new MySqlCommand("SELECT MAX(CAST(ID AS INT)) FROM KARYAWAN", Form1.conn);
                int id = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;
                string nama = tbNama.Text.ToUpper();
                string no = tbNo.Text;
                string email = tbEmail.Text.ToUpper();
                string alamat = tbAlamat.Text.ToUpper();
                string kelamin = "";
                int role = -1;
                if (rbPria.Checked)
                {
                    kelamin = "L";
                }
                else if (rbWanita.Checked)
                {
                    kelamin = "P";
                }
                if (rbAdm.Checked)
                {
                    role = 1;
                }
                else if (rbKary.Checked)
                {
                    role = 2;
                }
                else if (rbKoki.Checked)
                {
                    role = 3;
                }
                string tanggal = dtLahir.Value.ToString("yyyy-MM-dd");
                string kode = nama.Substring(0, 4);
                com = new MySqlCommand("SELECT IFNULL(MAX(SUBSTR(KODE,-1,1)),0) FROM KARYAWAN WHERE SUBSTR(KODE,1,4) = '" + kode + "'", Form1.conn);
                int nourut = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;
                kode = kode + "0000" + nourut.ToString();
                com = new MySqlCommand();
                com.Connection = conn;
                com.CommandText = "INSERT INTO KARYAWAN (ID,KODE,USERNAME,PASSWORD,NAMA,JENIS_KELAMIN,ALAMAT,EMAIL,NO_TELP,TANGGAL_LAHIR,FK_JABATAN,STATUS) VALUES(@ID,@KODE,@USERNAME,@PASSWORD,@NAMA,@JENIS_KELAMIN,@ALAMAT,@EMAIL,@NO_TELP,@TANGGAL_LAHIR,@FK_JABATAN,@STATUS)";
                com.Parameters.Add(new MySqlParameter("@ID", id));
                com.Parameters.Add(new MySqlParameter("@KODE", kode));
                com.Parameters.Add(new MySqlParameter("@USERNAME", nama));
                com.Parameters.Add(new MySqlParameter("@PASSWORD", nama));
                com.Parameters.Add(new MySqlParameter("@NAMA", nama));
                com.Parameters.Add(new MySqlParameter("@JENIS_KELAMIN", kelamin));
                com.Parameters.Add(new MySqlParameter("@ALAMAT", alamat));
                com.Parameters.Add(new MySqlParameter("@EMAIL", email));
                com.Parameters.Add(new MySqlParameter("@NO_TELP", no));
                com.Parameters.Add(new MySqlParameter("@TANGGAL_LAHIR", tanggal));
                com.Parameters.Add(new MySqlParameter("@FK_JABATAN", role));
                com.Parameters.Add(new MySqlParameter("@STATUS", 1));
                com.ExecuteNonQuery();
                loadDataGrid();
                clear();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
