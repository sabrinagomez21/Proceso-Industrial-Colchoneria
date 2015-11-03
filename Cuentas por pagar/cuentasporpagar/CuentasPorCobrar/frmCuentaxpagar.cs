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
    public partial class frmCuentaxpagar : Form
    {
        public frmCuentaxpagar()
        {
            InitializeComponent();
        }

        private void frmCuentaxpagar_Load(object sender, EventArgs e)
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
    }
}
