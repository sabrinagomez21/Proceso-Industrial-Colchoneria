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
    public partial class frmAutorizacionCobros : Form
    {
        public frmAutorizacionCobros()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("001","Cheque","010","26/10/2015","Dylan Corado","2000");
            dataGridView1.Rows.Add("002", "Deposito", "022", "26/10/2015", "Diego Taracena", "2250");
        }
    }
}
