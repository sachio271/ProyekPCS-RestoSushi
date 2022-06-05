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
    public partial class member : UserControl
    {
        MySqlConnection conn;
        DataTable dt;
        MySqlCommand com;
        MySqlDataAdapter da;
        public member()
        {
            InitializeComponent();
            conn = Form1.conn;
        }

        public void cekState()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void prepareawal()
        {
            cekState();
            loaddgmember();
            loaddgcust();
        }

        public void loaddgmember()
        {
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "select id,nama,harga,waktu_exp" +
                "" +
                " FROM membership" +
                " ORDER BY CAST(ID AS INT)";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void loaddgcust()
        {
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "select c.id,c.kode,c.nama,c.jenis_kelamin,c.alamat,c.no_telp,c.tanggal_lahir,m.nama" +
                "" +
                " FROM customer c , membership m where c.membership_id = m.id" +
                " ORDER BY CAST(c.ID AS INT)";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dgcust.DataSource = dt;
        }

        private void member_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string nama = tbnama.Text;
            string alamat = tbalamat.Text;
            string tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string exp = DateTime.Now.AddYears(+1).ToString("yyyy-MM-dd");
            string notlp = tbno.Text;
            string gender = "";
            string member = tbmember.Text;
            if (rbl.Checked)
            {
                gender = "L";
            }
            else if (rbp.Checked)
            {
                gender = "P";
            }
            string mid = tbmember.Text;
            if (nama == "" || alamat == "" || tanggal == "" || notlp == "" || gender == "")
            {
                MessageBox.Show("Ada Field yang Belum Terisi!");
            }
            else
            {
                com = new MySqlCommand("select max(cast(id as int)) from customer", Form1.conn);
                int id = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;
                string kode = nama.Substring(0, 3).ToUpper();
                com = new MySqlCommand("SELECT IFNULL(MAX(SUBSTR(KODE,-1,1)),0) FROM CUSTOMER WHERE SUBSTR(KODE,1,3) = '" + kode + "'", Form1.conn);
                int nourut = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;
                kode = kode + "00" + nourut.ToString();
                com = new MySqlCommand();
                com.Connection = conn;
                com.CommandText = "insert into customer (id,kode,nama,jenis_kelamin,alamat,no_telp,tanggal_lahir,membership_id,membership_exp) values (@id,@kode,@nama,@jenis_kelamin,@alamat,@no_telp,@tanggal_lahir,@membership_id,@membership_exp)";
                com.Parameters.Add(new MySqlParameter("@id", id));
                com.Parameters.Add(new MySqlParameter("@kode", kode));
                com.Parameters.Add(new MySqlParameter("@nama", nama));
                com.Parameters.Add(new MySqlParameter("@jenis_kelamin", gender));
                com.Parameters.Add(new MySqlParameter("@alamat", alamat));
                com.Parameters.Add(new MySqlParameter("@no_telp", notlp));
                com.Parameters.Add(new MySqlParameter("@tanggal_lahir", tanggal));
                com.Parameters.Add(new MySqlParameter("@membership_id", member));
                com.Parameters.Add(new MySqlParameter("@membership_exp", exp));
                com.ExecuteNonQuery();
                MessageBox.Show("Berhasil Insert!");
                loaddgcust();
                tbnama.Text = "";
                tbalamat.Text = "";
                rbl.Checked = true;
                tbno.Text = "";
                tbmember.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
