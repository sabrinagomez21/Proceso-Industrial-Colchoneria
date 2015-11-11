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
        }

        private void funLimpiarTextos()
        {
            txtCliente.Text = txtDocto.Text = txtTotal.Text = "";
            dtpFecha.ResetText();
            dtpVencimiento.ResetText();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mafacturacobro", "SELECT nnofactura, dfecha, dfechaexpiracion, ntotal, ncodcliente from mafacturacobro WHERE cestado='ACTIVO'", "consulta", grdFacturas);
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
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
            cnegocio.funactivarDesactivarBoton(btnnuevo, true);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, true);
            dtpFecha.Enabled = dtpVencimiento.Enabled = false;
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
                TextBox[] aDatos = { txtDocto, txtFecha, txtVenchimiento, txtTotal, txtEstado, txtCliente };
                //System.Console.WriteLine(txtDocto.Text + " " + txtFecha.Text + " " + txtVenchimiento.Text + " " +txtTotal.Text + " " + txtEstado.Text + " " +txtCliente.Text );
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
                cn.EditarObjetos(sTabla, bPermiso, aDatos, sCod, sCodigo);
            }
            else if (sBanderaGuardar == "Eliminar")
            {

            }

        }

        private void grdFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sBanderaGuardar == "Editar")
            {
                sCod = txtDocto.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                dtpFecha.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[1].Value.ToString();
                dtpVencimiento.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtTotal.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtCliente.Text = grdFacturas.Rows[grdFacturas.CurrentCell.RowIndex].Cells[4].Value.ToString();
            }
        }



    }
}
