using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    public partial class frmCuentasPorCobrar : Form
    {
        public frmCuentasPorCobrar()
        {
            InitializeComponent();
            grdCuentasporcobrar.Rows.Add("001", "Juan", "022", "26/10/2015", "1000", "Cancelado");
            grdCuentasporcobrar.Rows.Add("002", "Pedro", "023", "26/10/2015", "20000", "Activo");
        }

        private void grdCuentasporcobrar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmTipoCobro ver = new frmTipoCobro();
            //ver.Show();
        }
    }
}
