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
    public partial class memberadmin : UserControl
    {
        public memberadmin()
        {
            InitializeComponent();
            crystalReportViewer1.RefreshReport();
        }
    }
}
