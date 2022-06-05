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
    public partial class bahantersedia : UserControl
    {
        MySqlConnection conn;
        DataTable dt;
        MySqlCommand com;
        MySqlDataAdapter da;
        public bahantersedia()
        {
            InitializeComponent();
            conn = Form1.conn;
        }

        public void prepareawal()
        {
            cekState();
            loaddg();
        }

        public void cekState()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void loaddg()
        {
            cekState();
            dt = new DataTable();
            com = new MySqlCommand();
            string sql = "SELECT id 'ID', kode 'Kode', merk 'Nama Bahan',concat(qty_stok,' ',satuan) 'Stok'" +
                "" +
                " FROM bahan" +
                " ORDER BY CAST(ID AS INT)";
            da = new MySqlDataAdapter(sql, Form1.conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
