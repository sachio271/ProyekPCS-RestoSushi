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
    public partial class tambahbahan : UserControl
    {
        MySqlConnection conn;
        MySqlCommand com;
        public tambahbahan()
        {
            InitializeComponent();
            conn = Form1.conn;
            btnAdd.Cursor = Cursors.Hand;
            btnClear.Cursor = Cursors.Hand;
            btnBuy.Cursor = Cursors.Hand;
            btnReset.Cursor = Cursors.Hand;
        }

        public void cekState()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void loadcbBahan()
        {
            cekState();
            com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT * FROM BAHAN";
            MySqlDataReader reader = com.ExecuteReader();
            comboBahan.DisplayMember = "Text";
            comboBahan.ValueMember = "Value";
            while (reader.Read())
            {
                comboBahan.Items.Add(new { Text = reader.GetString(2), Value = reader.GetString(0) });
            }
            reader.Close();
            comboBahan.SelectedIndex = 0;
        }

        public void loadcbsup()
        {
            cekState();
            com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT * FROM SUPPLIER";
            MySqlDataReader reader = com.ExecuteReader();
            comboSup.DisplayMember = "Text";
            comboSup.ValueMember = "Value";
            while (reader.Read())
            {
                comboSup.Items.Add(new { Text = reader.GetString(2), Value = reader.GetString(0) });
            }
            reader.Close();
            comboSup.SelectedIndex = 0;
        }

        private void tambahbahan_Load(object sender, EventArgs e)
        {
            
        }

        public void prepareawal()
        {
            loadcbBahan();
            loadcbsup();
            tbHargaSatuan.Text = "Rp. 500000";
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int harga = Convert.ToInt32(tbHargaSatuan.Text.ToString().Substring(3));
            int qty = Convert.ToInt32(numericUpDown1.Value);
            int subtotal = qty * harga;
            tbsubtotal.Text = subtotal.ToString();
        }

        public void clear()
        {
            comboBahan.SelectedIndex = 0;
            comboSup.SelectedIndex = 0;
            numericUpDown1.Value = 1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sub = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            int gt = Convert.ToInt32(lblgrand.Text);
            gt = gt - sub;
            lblgrand.Text = gt + "";
            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            com = new MySqlCommand("select kode from bahan where merk = '" + comboBahan.Text + "'", Form1.conn);
            string kode = com.ExecuteScalar().ToString();
            com = new MySqlCommand("select id from bahan where merk = '" + comboBahan.Text + "'", Form1.conn);
            string id = com.ExecuteScalar().ToString();
            if (dataGridView1.Rows.Count == 0)
            {
                dataGridView1.Rows.Add(1, kode, comboBahan.Text, numericUpDown1.Value, tbHargaSatuan.Text.Substring(3), tbsubtotal.Text, id);
            }
            else
            {
                int ketemu = -1;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (comboBahan.Text == dataGridView1.Rows[i].Cells[2].Value.ToString())
                    {
                        ketemu = i;
                    }
                }
                if (ketemu == -1)
                {
                    int no = dataGridView1.Rows.Count + 1;
                    dataGridView1.Rows.Add(no, kode, comboBahan.Text, numericUpDown1.Value, tbHargaSatuan.Text.Substring(3), tbsubtotal.Text, id);
                }
                else
                {
                    int qty = Convert.ToInt32(dataGridView1.Rows[ketemu].Cells[3].Value.ToString()) + Convert.ToInt32(numericUpDown1.Value);
                    dataGridView1.Rows[ketemu].Cells[3].Value = qty;
                    int sub = Convert.ToInt32(tbHargaSatuan.Text.Substring(3)) * qty;
                    dataGridView1.Rows[ketemu].Cells[5].Value = sub;
                }
            }
            int grandtotal = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int subtotal = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value.ToString());
                grandtotal += subtotal;
            }
            lblgrand.Text = grandtotal + "";
            clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void comboBahan_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBahan.SelectedIndex > -1)
            {
                string cari = comboBahan.Text;
                com = new MySqlCommand("SELECT HARGA FROM BAHAN WHERE MERK='" + cari + "'", Form1.conn);
                int harga = Convert.ToInt32(com.ExecuteScalar().ToString());
                tbHargaSatuan.Text = "Rp. " + harga.ToString();
                int qty = Convert.ToInt32(numericUpDown1.Text.ToString());
                int subtotal = qty * harga;
                tbsubtotal.Text = subtotal.ToString();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            cekState();
            string nota = "BELI" + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
            com = new MySqlCommand("SELECT IFNULL(COUNT(*),0) FROM H_BELI_BAHAN WHERE SUBSTR(NOMOR_NOTA,1,12) = '" + nota + "'", Form1.conn);
            int nomor = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;
            nota += "00" + nomor;
            int supp = comboSup.SelectedIndex + 1;
            com = new MySqlCommand("SELECT ID FROM KARYAWAN WHERE NAMA='" + Form1.nama + "'", Form1.conn);
            int id = Convert.ToInt32(com.ExecuteScalar().ToString());
            using (MySqlTransaction obTrans = conn.BeginTransaction())
            {
                try
                {

                    // masukan ke h beli bahan 
                    com = new MySqlCommand();
                    com.Connection = conn;
                    com.CommandText = "INSERT INTO H_BELI_BAHAN (NOMOR_NOTA,TANGGAL_TRANS,TOTAL,FK_SUPPLIER,FK_KARYAWAN) VALUES (@NOMOR_NOTA,@TANGGAL_TRANS,@TOTAL,@FK_SUPPLIER,@FK_KARYAWAN)";
                    com.Parameters.Add(new MySqlParameter("@NOMOR_NOTA", nota));
                    com.Parameters.Add(new MySqlParameter("@TANGGAL_TRANS", DateTime.Now.ToString("yyyy-MM-dd")));
                    com.Parameters.Add(new MySqlParameter("@TOTAL", lblgrand.Text));
                    com.Parameters.Add(new MySqlParameter("@FK_SUPPLIER", supp));
                    com.Parameters.Add(new MySqlParameter("@FK_KARYAWAN", id));
                    com.ExecuteNonQuery();

                    // masukan ke d beli bahan 
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        com.Parameters.Clear();
                        com.CommandText = "insert into d_beli_bahan (nomor_nota,fk_bahan,quantity,harga,subtotal) values (@nomor_nota,@fk_bahan,@quantity,@harga,@subtotal)";
                        com.Parameters.Add(new MySqlParameter("@NOMOR_NOTA", nota));
                        com.Parameters.Add(new MySqlParameter("@fk_bahan", dataGridView1.Rows[i].Cells[6].Value.ToString()));
                        com.Parameters.Add(new MySqlParameter("@quantity", dataGridView1.Rows[i].Cells[3].Value.ToString()));
                        com.Parameters.Add(new MySqlParameter("@harga", dataGridView1.Rows[i].Cells[4].Value.ToString()));
                        com.Parameters.Add(new MySqlParameter("@subtotal", dataGridView1.Rows[i].Cells[5].Value.ToString()));
                        com.ExecuteNonQuery();

                        // update bahan
                        com = new MySqlCommand("SELECT QTY_STOK FROM BAHAN WHERE MERK='" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", Form1.conn);
                        int qty = Convert.ToInt32(com.ExecuteScalar().ToString());
                        qty = qty + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        com = new MySqlCommand("UPDATE BAHAN SET QTY_STOK = " + qty + " WHERE MERK='" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", Form1.conn);
                        com.ExecuteScalar();
                    }
                    obTrans.Commit();
                    MessageBox.Show("Pembelian Sukses !");
                    dataGridView1.Rows.Clear();
                    lblgrand.Text = 0 + "";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    obTrans.Rollback();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            lblgrand.Text = "0";
        }
    }
}
