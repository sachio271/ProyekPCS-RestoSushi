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

    public partial class order : UserControl
    {
        MySqlConnection conn;
        DataTable dt;
        MySqlCommand com;
        MySqlDataAdapter da;
        public order()
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

        private void order_Load(object sender, EventArgs e)
        {
            
        }

        public void prepareawal()
        {
            loadcbcust();
            loadcbjenis();
            loaddgmenu();

        }

        public void loadcbjenis()
        {
            com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT * FROM jenis_menu";
            MySqlDataReader reader = com.ExecuteReader();
            cbjenis.DisplayMember = "Text";
            cbjenis.ValueMember = "Value";
            while (reader.Read())
            {
                cbjenis.Items.Add(new { Text = reader.GetString(1), Value = reader.GetString(0) });
            }
            reader.Close();
            cbjenis.SelectedIndex = 0;
        }

        public void loadcbcust()
        {
            com = new MySqlCommand();
            com.Connection = conn;
            com.CommandText = "SELECT * FROM customer";
            MySqlDataReader reader = com.ExecuteReader();
            cbcust.DisplayMember = "Text";
            cbcust.ValueMember = "Value";
            while (reader.Read())
            {
                cbcust.Items.Add(new { Text = reader.GetString(2), Value = reader.GetString(0) });
            }
            reader.Close();
            cbcust.SelectedIndex = 0;
        }



        public void loaddgmenu()
        {
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "SELECT m.id 'ID', m.kode 'Kode', m.nama 'Nama Menu', m.deskripsi 'Deskripsi', concat('Rp. ',m.harga) 'Harga', m.stok 'Stok', j.nama_jenis 'Jenis Menu'" +
                "" +
                " FROM menu m, jenis_menu j" +
                " WHERE m.jenis_menu = j.id" +
                " ORDER BY CAST(m.ID AS INT)";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dgMenu.DataSource = dt;
        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (dgMenu.Rows[idx].Cells[5].Value.ToString() == "0")
            {
                MessageBox.Show("Stok Habis!");
            }
            else
            {
                if (dgCart.Rows.Count == 0)
                {
                    dgCart.Rows.Add(1, dgMenu.Rows[idx].Cells[2].Value.ToString(), dgMenu.Rows[idx].Cells[4].Value.ToString(), 1, dgMenu.Rows[idx].Cells[4].Value.ToString(),dgMenu.Rows[idx].Cells[0].Value.ToString());
                }
                else
                {
                    int ketemu = -1;
                    for (int i = 0; i < dgCart.Rows.Count; i++)
                    {
                        if (dgMenu.Rows[idx].Cells[2].Value.ToString() == dgCart.Rows[i].Cells[1].Value.ToString())
                        {
                            ketemu = i;
                        }
                    }
                    if (ketemu == -1)
                    {
                        int no = dgCart.Rows.Count + 1;
                        dgCart.Rows.Add(no, dgMenu.Rows[idx].Cells[2].Value.ToString(), dgMenu.Rows[idx].Cells[4].Value.ToString(), 1, dgMenu.Rows[idx].Cells[4].Value.ToString(), dgMenu.Rows[idx].Cells[0].Value.ToString());
                    }
                    else
                    {
                        int qty = Convert.ToInt32(dgCart.Rows[ketemu].Cells[3].Value.ToString()) + 1;
                        dgCart.Rows[ketemu].Cells[3].Value = qty;
                        int sub = Convert.ToInt32(dgCart.Rows[ketemu].Cells[4].Value.ToString().Substring(3)) * qty;
                        dgCart.Rows[ketemu].Cells[4].Value = "Rp. " + sub;
                    }
                }
                int temp = Convert.ToInt32(dgMenu.Rows[idx].Cells[5].Value.ToString()) - 1;
                dgMenu.Rows[idx].Cells[5].Value = temp;
                int grandtotal = 0;
                for (int i = 0; i < dgCart.Rows.Count; i++)
                {
                    int subtotal = Convert.ToInt32(dgCart.Rows[i].Cells[4].Value.ToString().Substring(3));
                    grandtotal += subtotal;
                }
                lblgrand.Text = grandtotal + "";
            }
        }

        private void dgCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int q = Convert.ToInt32(dgCart.Rows[e.RowIndex].Cells[3].Value.ToString());
            int subt = Convert.ToInt32(dgCart.Rows[e.RowIndex].Cells[4].Value.ToString().Substring(3));
            int tempgrand = Convert.ToInt32(lblgrand.Text);
            tempgrand = tempgrand - subt;
            lblgrand.Text = tempgrand + "";
            for (int i = 0; i < dgMenu.Rows.Count; i++)
            {
                if (dgCart.Rows[e.RowIndex].Cells[1].Value.ToString() == dgMenu.Rows[i].Cells[2].Value.ToString())
                {
                    int qmenu = Convert.ToInt32(dgMenu.Rows[i].Cells[5].Value.ToString()) + q;
                    dgMenu.Rows[i].Cells[5].Value = qmenu;
                }
            }
            dgCart.Rows.RemoveAt(e.RowIndex);
            
        }

        private void custombutton1_Click(object sender, EventArgs e)
        {
            cekState();
            string nota = "JUAL" + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("dd");
            com = new MySqlCommand("SELECT IFNULL(COUNT(*),0) FROM H_TRANS WHERE SUBSTR(NOMOR_NOTA,1,12) = '" + nota + "'", Form1.conn);
            int nomor = Convert.ToInt32(com.ExecuteScalar().ToString()) + 1;
            nota += "00" + nomor;
            int idcust = cbcust.SelectedIndex + 1;
            com = new MySqlCommand("SELECT ID FROM KARYAWAN WHERE NAMA='" + Form1.nama + "'", Form1.conn);
            int id = Convert.ToInt32(com.ExecuteScalar().ToString());
            string metod = "";
            if (rbcash.Checked)
            {
                metod = "Cash";
            }
            else if (rbdebit.Checked)
            {
                metod = "Debit";
            }
            else if (rbovo.Checked)
            {
                metod = "OVO";
            }
            else if (rbshopee.Checked)
            {
                metod = "ShopeePay";
            }
            using (MySqlTransaction obTrans = conn.BeginTransaction())
            {
                try
                {
                    //masukan ke h trans
                    com = new MySqlCommand();
                    com.Connection = conn;
                    com.CommandText = "insert into h_trans (nomor_nota,tanggal_trans,total,fk_karyawan,fk_customer,metode_pembayaran,status) values (@nomor_nota,@tanggal_trans,@total,@fk_karyawan,@fk_customer,@metode_pembayaran,@status)";
                    com.Parameters.Add(new MySqlParameter("@nomor_nota", nota));
                    com.Parameters.Add(new MySqlParameter("@tanggal_trans", DateTime.Now.ToString("yyyy-MM-dd")));
                    com.Parameters.Add(new MySqlParameter("@total", lblgrand.Text));
                    com.Parameters.Add(new MySqlParameter("@fk_karyawan", id));
                    com.Parameters.Add(new MySqlParameter("@fk_customer", idcust));
                    com.Parameters.Add(new MySqlParameter("@metode_pembayaran", metod));
                    com.Parameters.Add(new MySqlParameter("@status", 1));
                    com.ExecuteNonQuery();

                    //masukan ke d trans
                    for (int i = 0; i < dgCart.Rows.Count; i++)
                    {
                        com.Parameters.Clear();
                        com.CommandText = "insert into d_trans (nomor_nota,fk_menu,quantity,harga,subtotal) values (@nomor_nota,@fk_menu,@quantity,@harga,@subtotal)";
                        com.Parameters.Add(new MySqlParameter("@nomor_nota", nota));
                        com.Parameters.Add(new MySqlParameter("@fk_menu", dgCart.Rows[i].Cells[5].Value.ToString()));
                        com.Parameters.Add(new MySqlParameter("@quantity", dgCart.Rows[i].Cells[3].Value.ToString()));
                        com.Parameters.Add(new MySqlParameter("@harga", dgCart.Rows[i].Cells[2].Value.ToString().Substring(3)));
                        com.Parameters.Add(new MySqlParameter("@subtotal", dgCart.Rows[i].Cells[4].Value.ToString().Substring(3)));
                        com.ExecuteNonQuery();

                        //update bahan
                        int tempqty = Convert.ToInt32(dgCart.Rows[i].Cells[3].Value.ToString());
                        com = new MySqlCommand("update menu set stok = stok - " + tempqty + " where nama = '" + dgCart.Rows[i].Cells[1].Value.ToString() + "'", Form1.conn);
                        com.ExecuteNonQuery();
                    }
                    obTrans.Commit();
                    MessageBox.Show("Order Sukses !");
                    dgCart.Rows.Clear();
                    loaddgmenu();
                    tbsearch.Text = "";
                    cbjenis.SelectedIndex = 0;
                    lblgrand.Text = "0";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    obTrans.Rollback();
                }
            }
        }

        private void custombutton2_Click(object sender, EventArgs e)
        {
            loaddgmenu();
            dgCart.Rows.Clear();
            tbsearch.Text = "";
            cbjenis.SelectedIndex = 0;
            lblgrand.Text = "0";
        }
    }
}
