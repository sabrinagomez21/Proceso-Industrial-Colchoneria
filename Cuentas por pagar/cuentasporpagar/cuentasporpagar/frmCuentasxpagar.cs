using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cuentasporpagar
{
    public partial class frmCuentasxpagar : Form
    {
        public frmCuentasxpagar()
        {
            InitializeComponent();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPagos frm = new frmPagos();
            frm.Show();
        }
    }
}
