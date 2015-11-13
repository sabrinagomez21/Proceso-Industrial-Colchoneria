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
    public partial class MantenimientoFacturas : Form
    {
        String sBanderaGuardar;
        Boolean bBuscando;
        clasnegocio cn = new clasnegocio();
        string sCod;
       
        public MantenimientoFacturas()
        {
            InitializeComponent();
            funActualizarGrid();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarBoton(btnbuscar, false);
            cnegocio.funactivarDesactivarBoton(btnguardar, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, false);
            cnegocio.funactivarDesactivarBoton(btnimprimir, false);
            dtpFecha.Enabled = dtpVencimiento.Enabled = false;
        }

        private void MantenimientoFacturas_Load(object sender, EventArgs e)
        {
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
            nuevo.funactivarDesactivarBoton(btnimprimir, false);
        }

        private void funLimpiarTextos()
        {
            txtCliente.Text = txtDocto.Text = txtTotal.Text = "";
            dtpFecha.ResetText();
            dtpVencimiento.ResetText();
        }

        private void funCancelar()
        {
            funLimpiarTextos();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCliente, false);
            cnegocio.funactivarDesactivarTextbox(txtDocto, false);
            cnegocio.funactivarDesactivarTextbox(txtTotal, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, false);
            cnegocio.funactivarDesactivarBoton(btnguardar, false);
            cnegocio.funactivarDesactivarBoton(btneliminar, true);
            cnegocio.funactivarDesactivarBoton(btneditar, true);
            cnegocio.funactivarDesactivarBoton(btnbuscar, true);
            cnegocio.funactivarDesactivarBoton(btnnuevo, true);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, true);
            dtpFecha.Enabled = dtpVencimiento.Enabled = false;
            bBuscando = false;
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO'", "consulta", grdFacturas);
            //grdFacturas.Columns[0].Visible = false;
        }

        private void funDesbloqueo()
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarBoton(btnguardar, false);
            cn.funactivarDesactivarBoton(btncancelar, false);
            cn.funactivarDesactivarBoton(btneliminar, true);
            cn.funactivarDesactivarBoton(btnrefrescar, true);
            cn.funactivarDesactivarBoton(btneditar, true);
            cn.funactivarDesactivarBoton(btnnuevo, true);
        }

        private void funHabilitarText()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCliente, true);
            cnegocio.funactivarDesactivarTextbox(txtDocto, true);
            cnegocio.funactivarDesactivarTextbox(txtTotal, true);
            dtpFecha.Enabled = dtpVencimiento.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            sBanderaGuardar = "Guardar";
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
            cnegocio.funactivarDesactivarBoton(btnbuscar, false);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdFacturas);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdFacturas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdFacturas);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdFacturas);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sBanderaGuardar = "Editar";
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sBanderaGuardar = "Eliminar";
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(sBanderaGuardar == "Guardar"){
                txtFecha.Text = dtpFecha.Text;
                txtVenchimiento.Text = dtpVencimiento.Text;
                txtEstado.Text = "ACTIVO";
                txtPagado.Text = "NO";
                TextBox[] aDatos = { txtDocto, txtFecha, txtVenchimiento, txtTotal, txtEstado, txtPagado, txtCliente };
                string sTabla = "mafacturacobro";
                Boolean bPermiso = true;
                clasnegocio cn = new clasnegocio();
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                funDesbloqueo();
                funActualizarGrid();
                funLimpiarTextos();
            }
            else if (sBanderaGuardar == "Editar")
            {
                txtFecha.Text = dtpFecha.Text;
                txtVenchimiento.Text = dtpVencimiento.Text;
                txtEstado.Text = "ACTIVO";
                TextBox[] aDatos = { txtDocto, txtFecha, txtVenchimiento, txtTotal, txtEstado, txtCliente };
                string sTabla = "mafacturacobro";
                string sCodigo = "ncodfactura";
                Boolean bPermiso = true;
                System.Console.WriteLine(sTabla + " " + sCod + " " + sCodigo);
                cn.EditarObjetos(sTabla, bPermiso, aDatos, sCod, sCodigo);
                funActualizarGrid();
                funCancelar();
                sBanderaGuardar = "Guardar";
            }
            else if (sBanderaGuardar == "Eliminar")
            {
                string sTabla = "mafacturacobro";
                string sCampoLlavePrimaria = "ncodfactura";
                string sCampoEstado = "cestado";
                System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
                funActualizarGrid();
                funCancelar();
                sBanderaGuardar = "Guardar";
            }
            cn.funactivarDesactivarTextbox(txtCliente, false);
            cn.funactivarDesactivarTextbox(txtDocto, false);
            cn.funactivarDesactivarTextbox(txtTotal, false);
            dtpFecha.Enabled = dtpVencimiento.Enabled = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            bBuscando = true;
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarBoton(btnguardar, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
        }

        private void grdFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sBanderaGuardar == "Editar" || sBanderaGuardar == "Eliminar")
            {
                sCod = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtDocto.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[1].Value.ToString();
                dtpFecha.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[2].Value.ToString();
                dtpVencimiento.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtTotal.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[4].Value.ToString();
                txtCliente.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (bBuscando == true)
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtCliente.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO' AND ncodcliente LIKE '" + txtCliente.Text + "%'", "consulta", grdFacturas);
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

        private void txtDocto_KeyUp(object sender, KeyEventArgs e)
        {
            if (bBuscando == true)
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtDocto.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO' AND nnofactura LIKE '" + txtDocto.Text + "%'", "consulta", grdFacturas);
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

        private void txtTotal_KeyUp(object sender, KeyEventArgs e)
        {
            if (bBuscando == true)
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtTotal.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO' AND ntotal LIKE '" + txtTotal.Text + "%'", "consulta", grdFacturas);
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
            if (bBuscando == true)
            {
                try
                {
                    if (!String.IsNullOrEmpty(dtpFecha.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO' AND dfecha LIKE '" + dtpFecha.Text + "%'", "consulta", grdFacturas);
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

        private void dtpVencimiento_ValueChanged(object sender, EventArgs e)
        {
            if (bBuscando == true)
            {
                try
                {
                    if (!String.IsNullOrEmpty(dtpVencimiento.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO' AND dfechaexpiracion LIKE '" + dtpVencimiento.Text + "%'", "consulta", grdFacturas);
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

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            if (sBanderaGuardar == "Editar")
            funLimpiarTextos();
        }

        private void txtDocto_Enter(object sender, EventArgs e)
        {
            if (sBanderaGuardar == "Editar")
            funLimpiarTextos();
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            if (sBanderaGuardar == "Editar")
            funLimpiarTextos();
        }

        private void dtpFecha_Enter(object sender, EventArgs e)
        {
            if (sBanderaGuardar == "Editar")
            funLimpiarTextos();
        }

        private void dtpVencimiento_Enter(object sender, EventArgs e)
        {
            if (sBanderaGuardar == "Editar")
            funLimpiarTextos();
        }
    }
}
