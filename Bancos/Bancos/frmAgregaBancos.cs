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

namespace Bancos
{
    public partial class frmAgregaBancos : Form
    {
        string estado = "";
        string sCod;
        public frmAgregaBancos()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            funLlenarTabla();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtEstado, true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sTabla = "mabanco";
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            txtEstado.Text = cmbEstado.SelectedItem.ToString();
            
                       
            

            if (estado.Equals("editar"))
            {                
                TextBox[] aDatosEdit = { txtNombre, txtDireccion, txtEstado };                
                string sCodigo = "ncodbanco";

                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);


            }
            else if (estado.Equals("eliminar"))
            {
                //string sTabla = "matipotransaccion";
                string sCampoLlavePrimaria = "ncodbanco";
                string sCampoEstado = "cestado";
                //System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {                                
                //string sTabla = "matipotransaccion";
                txtEstado.Text = "Activo";
                TextBox[] datos = { txtNombre, txtDireccion, txtEstado };
                cn.AsignarObjetos(sTabla, bPermiso, datos);

                funLimpiar();
                funLlenarTabla();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtDireccion, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);                        
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
            lblEstado.Visible = false;
            txtEstado.Visible = false;
            funLimpiar();
            funLlenarTabla(); 
        }

        void funLimpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        void funLlenarTabla()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mabanco", "SELECT ncodbanco as No, vnombrebanco as Nombre, vdireccion as Direccion, cestado as Estado from mabanco", "consulta", grdDatos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNombre.Clear();
            txtDireccion.Clear();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtDireccion, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
            btnAnterior.Enabled = false;
            btnIrPrimero.Enabled = false;
            btnSiguiente.Enabled = false;
            btnIrUltimo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtDireccion, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
            txtBuscar.Visible = false;
            //lblBuscar.Visible = false;
            lblNombre.Visible = true;
            lblDireccion.Visible = true;
            lblEstado.Visible = true;
            txtNombre.Visible = true;
            txtDireccion.Visible = true;           
            txtNombre.Clear();
            txtDireccion.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;
            cmbEstado.Visible = false;
            lblEstado.Visible = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;

            funLlenarTabla();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funLlenarTabla();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdDatos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDatos);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtNombre, true);
                cn.funactivarDesactivarTextbox(txtDireccion, true);
                cn.funactivarDesactivarCombobox(cmbEstado, true);
                sCod = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtDireccion.Text = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[2].Value.ToString();
                cmbEstado.Visible = true;
                txtNombre.Enabled = true;
                lblEstado.Visible = true;
                cmbEstado.Enabled = true;
                string sCmb = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[3].Value.ToString();
                if (sCmb.Equals("Activo"))
                {
                    cmbEstado.SelectedIndex = 0;
                    cmbEstado.Enabled = false;
                    cmbEstado.Visible = false;
                    lblEstado.Visible = false;
                }
                else if (sCmb.Equals("Inactivo"))
                {
                    cmbEstado.SelectedIndex = 1;                    
                }

            } if (estado.Equals("eliminar"))
            {
                sCod = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            lblDireccion.Visible = false;
            txtDireccion.Visible = false;
            cmbEstado.Visible = false;
            lblEstado.Visible = false;
            txtBuscar.Visible = true;
            txtBuscar.Enabled = true;
            //lblBuscar.Visible = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mabanco", "SELECT ncodbanco as Codigo, vnombrebanco as Nombre ,vdireccion as Operacion, cestado as Estado  from mabanco WHERE vnombrebanco LIKE '" + txtBuscar.Text + "%'", "consulta", grdDatos);
        }
    }
}
