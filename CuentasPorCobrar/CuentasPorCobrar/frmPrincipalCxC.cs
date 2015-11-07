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
    public partial class frmPrincipalCxC : Form
    {
        public frmPrincipalCxC()
        {
            InitializeComponent();
        }

        private void frmPrincipalCxC_Load(object sender, EventArgs e)
        {
            // Create new Checkbox Column
            DataGridViewCheckBoxColumn myCheckedColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Checked Column",
                FalseValue = 0,
                TrueValue = 1,
                Visible = true
            };
            // add the new column to your dataGridView 
            grdDocumentos.Columns.Add(myCheckedColumn);
        }
        private void consultaRecibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCxC ver = new frmConsultaCxC();
            //ver.MdiParent = this;
            ver.Show();
        }

        private void mantenimientoTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTransaccion ver = new MantenimientoTransaccion();
            ver.Show();
        }
    }
}
