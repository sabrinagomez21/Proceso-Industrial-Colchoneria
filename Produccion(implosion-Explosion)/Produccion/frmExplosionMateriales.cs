using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produccion
{
    public partial class frmExplosionMateriales : Form
    {
        public frmExplosionMateriales()
        {
            InitializeComponent();
            cargarBox();
        }
        private void cargarBox()
        {
            cmbProducto.DataSource = new cNegocioExplosion().obtenerProducto();
            cmbProducto.Refresh();
            cmbProducto.ValueMember = "ncodreceta";
            cmbProducto.DisplayMember = "vnombrereceta";
            cmbProducto.SelectedValue = 0;
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvDetalle.DataSource = new cNegocioExplosion().Explotar(Convert.ToInt32(cmbProducto.SelectedValue));
            dgvDetalle.Refresh();
        }
    }
}
