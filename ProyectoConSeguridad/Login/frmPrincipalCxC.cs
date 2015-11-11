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


namespace Login
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
            
            clasnegocio nuevo = new clasnegocio();
            nuevo.funactivarDesactivarBoton(btnnuevo, Convert.ToBoolean(Permisos.btnnuevo));
            nuevo.funactivarDesactivarBoton(btneditar, Convert.ToBoolean(Permisos.btneditar));
            nuevo.funactivarDesactivarBoton(btneliminar, Convert.ToBoolean(Permisos.btneliminar));
            nuevo.funactivarDesactivarBoton(btnguardar, Convert.ToBoolean(Permisos.btnguardar));
            nuevo.funactivarDesactivarBoton(btncancelar, Convert.ToBoolean(Permisos.btncancelar));
            nuevo.funactivarDesactivarBoton(btnrefrescar, Convert.ToBoolean(Permisos.btnrefrescar));
            nuevo.funactivarDesactivarBoton(btnimprimir, Convert.ToBoolean(Permisos.btnimprimir));
            nuevo.funactivarDesactivarBoton(btnbuscar, Convert.ToBoolean(Permisos.btnbuscar));
            nuevo.funactivarDesactivarBoton(btnirPrimero, Convert.ToBoolean(Permisos.btnirPrimiero));
            nuevo.funactivarDesactivarBoton(btnanterior, Convert.ToBoolean(Permisos.btnanterior));
            nuevo.funactivarDesactivarBoton(btnsiguiente, Convert.ToBoolean(Permisos.btnsiguiente));
            nuevo.funactivarDesactivarBoton(btnirUltimo, Convert.ToBoolean(Permisos.btnirUltimo));
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
            txtCliente.Text = cmbTransaccion.SelectedText +"";
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            txtDocto.Text = "";
            funActualizarGrid();
        }

        private void txtDocto_Enter(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            funActualizarGrid();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        
        
    }
}
