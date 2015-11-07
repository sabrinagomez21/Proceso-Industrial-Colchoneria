using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;


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
            funActualizarGrid();
            funActualizarCombo();
            funAgregarCheckBox();
        }

        private void funLimpiarText()
        {
            txtCliente.Text = txtDocto.Text = "";
        }

        private void funAgregarCheckBox()
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

        private void funActualizarGrid()
        {
            if (cmbTransaccion.Text == "Cobro") {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("mafactura", "SELECT ncodfactura, dfecha, ntotal from mafactura WHERE vestado='ACTIVO'", "consulta", grdDocumentos);
            }
        }

        private void funActualizarCombo()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodtipotransaccion", "SELECT ncodtipotransaccion,vnombredocumento from matipotransaccion", "vnombredocumento", cmbTransaccion);
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
            funActualizarCombo();
        }

        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbTransaccion.Text == "Cobro")
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtCliente.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafactura", "SELECT mafactura.ncodfactura, mafactura.dfecha, mafactura.ntotal from mafactura, macliente WHERE mafactura.vestado='ACTIVO' AND macliente.ncodcliente LIKE '" + txtCliente.Text + "%' AND macliente.ncodcliente = mafactura.ncodcliente", "consulta", grdDocumentos);
                    }
                    else
                    {
                        funActualizarGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error filtrando clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtDocto_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbTransaccion.Text == "Cobro")
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtDocto.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafactura", "SELECT mafactura.ncodfactura, mafactura.dfecha, mafactura.ntotal from mafactura WHERE mafactura.vestado='ACTIVO' AND mafactura.ncodfactura LIKE '" + txtDocto.Text + "%'", "consulta", grdDocumentos);
                    }
                    else
                    {
                        funActualizarGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error filtrando documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (cmbTransaccion.Text == "Cobro")
            {
                try
                {
                    clasnegocio cnegocio = new clasnegocio();
                    cnegocio.funconsultarRegistros("mafactura", "SELECT mafactura.ncodfactura, mafactura.dfecha, mafactura.ntotal from mafactura WHERE mafactura.vestado='ACTIVO' AND mafactura.dfecha = '" + dtpFecha.Text + "%'", "consulta", grdDocumentos);
                }
                catch
                {
                    MessageBox.Show("Se produjo un error filtrando documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            funActualizarGrid();
            funLimpiarText();
        }

        private void btnPagoCobro_Click(object sender, EventArgs e)
        {

        }
    }
}
