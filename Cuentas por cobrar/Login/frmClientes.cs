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


/*---------------------------------------------------------------------------------------------------------------------------
    MODULULO: CUENTAS POR COBRAR
    APLICACION: COBRO DE FACTURAS
    ANALISTAS Y PROGRAMADORES: JOSUE REVOLORIO, DYLAN CORADO
 ---------------------------------------------------------------------------------------------------------------------------*/

namespace Login
{
    public partial class frmClientes : Form
    {
        string estado = "";
        string sCod;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
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
            funActualizarGrid();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            txtNombre.Enabled = txtApellido.Enabled = txtDireccion.Enabled = txtNit.Enabled = txtTelefono.Enabled = txtCorreo.Enabled = false;
                 
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maclientecobro", "SELECT ncodcliente as Codigo, vnombrecliente as Nombre, vapellidocliente as Apellido , vnit as Nit, vdireccion as Direccion, ntelefono as Telefono, vcorreo as Correo from maclientecobro WHERE vestado='ACTIVO'", "consulta", grdClientes);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtNit, true);
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            txtNombre.Enabled = txtApellido.Enabled = txtDireccion.Enabled = txtNit.Enabled = txtTelefono.Enabled = txtCorreo.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNombre.Clear();
            txtNit.Clear();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtNit, false);
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            btnanterior.Enabled = false;
            btnirPrimero.Enabled = false;
            btnsiguiente.Enabled = false;
            btnirUltimo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            if (estado.Equals("editar"))
            {
                TextBox[] aDatosEdit = { txtNit, txtNombre, txtApellido, txtDireccion, txtTelefono, txtCorreo};
                string sTabla = "maclientecobro";
                string sCodigo = "ncodcliente";
                
                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
            }
            else if (estado.Equals("eliminar"))
            {
                string sTabla = "maclientecobro";
                string sCampoLlavePrimaria = "ncodcliente";
                string sCampoEstado = "vestado";
                System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {
                TextBox[] aDatos = { txtNit, txtNombre, txtApellido, txtDireccion, txtTelefono, txtCorreo, txtEstado, txtSaldo };
                string sTabla = "maclientecobro";
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                funActualizarGrid();
                txtNombre.Clear();
                txtNit.Clear();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtNit, false);
            txtNombre.Clear();
            txtNit.Clear();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
            funActualizarGrid();
            txtNombre.Text = txtApellido.Text = txtDireccion.Text = txtNit.Text = txtTelefono.Text = txtCorreo.Text = "";
            txtNombre.Enabled = txtApellido.Enabled = txtDireccion.Enabled = txtNit.Enabled = txtTelefono.Enabled = txtCorreo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtNit, false);
            txtBuscar.Visible = false;
            lblBuscar.Visible = false;
            lblNombre.Visible = true;
            lblNit.Visible = true;
            txtNombre.Visible = true;
            txtNit.Visible = true;
            txtNombre.Clear();
            txtNit.Clear();
            txtBuscar.Clear();

            LblApellido.Visible = true;
            txtApellido.Visible = true;
            LblDireccion.Visible = true;
            txtDireccion.Visible = true;
            LblTelefono.Visible = true;
            txtTelefono.Visible = true;
            LblCorreo.Visible = true;
            txtCorreo.Visible = true;

            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
            txtNombre.Enabled = txtApellido.Enabled = txtDireccion.Enabled = txtNit.Enabled = txtTelefono.Enabled = txtCorreo.Enabled = false;
            txtNombre.Text = txtApellido.Text = txtDireccion.Text = txtNit.Text = txtTelefono.Text = txtCorreo.Text = "";
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            lblNombre.Visible = false;
            txtNit.Visible = false;
            lblNit.Visible = false;
            txtBuscar.Visible = true;
            lblBuscar.Visible = true;
            
            LblApellido.Visible = false;
            txtApellido.Visible = false;
            LblDireccion.Visible = false;
            txtDireccion.Visible = false;
            LblTelefono.Visible = false;
            txtTelefono.Visible = false;
            LblCorreo.Visible = false;
            txtCorreo.Visible = false;

            btnguardar.Enabled = false;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdClientes);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdClientes);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdClientes);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdClientes);
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtNombre, true);
                cn.funactivarDesactivarTextbox(txtNit, true);
                txtNombre.Enabled = txtApellido.Enabled = txtDireccion.Enabled = txtNit.Enabled = txtTelefono.Enabled = txtCorreo.Enabled = true;
                sCod = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtApellido.Text = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtNit.Text = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[3].Value.ToString();
                txtDireccion.Text = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[4].Value.ToString();
                txtTelefono.Text = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[5].Value.ToString();
                txtCorreo.Text = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[6].Value.ToString();
            } if (estado.Equals("eliminar"))
            {
                sCod = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
                System.Console.WriteLine("hola"+sCod);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maclientecobro", "SELECT ncodcliente as Codigo, vnombrecliente as Nombre, vapellidocliente as Apellido , vnit as Nit, vdireccion as Direccion, ntelefono as Telefono, vcorreo as Correo from maclientecobro WHERE vestado='ACTIVO' AND vnombrecliente LIKE '" + txtBuscar.Text + "%'", "consulta", grdClientes);
        }

        
    }
}
