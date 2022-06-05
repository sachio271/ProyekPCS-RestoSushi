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
    public partial class Koki : Form
    {
        MySqlConnection conn;
        DataTable dt;
        MySqlCommand com;
        MySqlDataAdapter da;
        int idxdg = -1;
        int orderan = 0;
        public Koki()
        {
            InitializeComponent();
            conn = Form1.conn;
            button4.Cursor = Cursors.Hand;
            btnProses.Cursor = Cursors.Hand;
            btnSel.Cursor = Cursors.Hand;
        }

        public void cekState()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void loaddghtrans()
        {
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "SELECT nomor_nota 'Nota', tanggal_trans 'Tanggal'" +
                "" +
                " FROM h_trans" +
                " WHERE status<3" +
                " ORDER BY tanggal_trans";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dghtrans.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (orderan!=0)
            {
                MessageBox.Show("Ada Order Yang Belum Selesai!");
            }
            else
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void Koki_Load(object sender, EventArgs e)
        {
            loaddghtrans();
            lblnama.Text = Form1.nama;
            Tanggal.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Jam.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }

        private void dghtrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idxdg = e.RowIndex;
            if (dghtrans.Rows[idxdg].Cells[0].Style.BackColor == Color.Yellow)
            {
                btnProses.Cursor = Cursors.No;
                btnProses.Enabled = false;
                btnSel.Enabled = true;
                btnSel.Cursor = Cursors.Hand;
            }
            else
            {
                btnProses.Enabled = true;
                btnProses.Cursor = Cursors.Hand;
                btnSel.Cursor = Cursors.No;
                btnSel.Enabled = false;
            }
            string nota = dghtrans.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblnota.Text = nota;
                
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "SELECT m.nama 'Menu', d.quantity 'Qty'" +
                "" +
                " FROM h_trans h ,d_trans d, menu m " +
                " WHERE h.nomor_nota = d.nomor_nota and d.fk_menu = m.id and d.nomor_nota = '"+nota+"'" +
                " ORDER BY m.nama";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dgdtrans.DataSource = dt;
        }

        private void dgdtrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int idx = e.RowIndex;
            com = new MySqlCommand("select id from menu where nama='" + dgdtrans.Rows[idx].Cells[0].Value.ToString() + "'",Form1.conn);
            string idmenu = com.ExecuteScalar().ToString();
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "SELECT b.merk 'Bahan', r.qty 'Qty'" +
                "" +
                " FROM resep r , menu m , bahan b" +
                " WHERE r.id_menu = m.id and r.id_bahan = b.id and r.id_menu = '"+idmenu+"'" +
                " ORDER BY m.nama";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dgresep.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tanggal.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            Jam.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (orderan == 1)
            {
                MessageBox.Show("Selesaikan Orderan Sebelumnya!");
            }
            else
            {
                com = new MySqlCommand("update h_trans set status = 2 where nomor_nota = '" + lblnota.Text + "'", Form1.conn);
                com.ExecuteNonQuery();
                dghtrans.Rows[idxdg].Cells[0].Style.BackColor = Color.Yellow;
                dghtrans.Rows[idxdg].Cells[1].Style.BackColor = Color.Yellow;
                dghtrans.Rows[idxdg].Selected = false;
                orderan++;
            }
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            orderan--;
            dgdtrans.DataSource = null;
            dgresep.DataSource = null;
            com = new MySqlCommand("update h_trans set status = 3 where nomor_nota = '" + lblnota.Text + "'", Form1.conn);
            com.ExecuteNonQuery();
            loaddghtrans();
        }
    }
}
