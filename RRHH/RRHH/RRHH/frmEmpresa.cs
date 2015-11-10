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
using ConexionODBC;

namespace RRHH
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }
        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodempresa", "SELECT ncodempresa from MaEmpresa", "ncodempresa", cmbSeleccionado);
            cnegocio.funconsultarRegistros("MaEmpresa", "SELECT ncodempresa as Codigo, vtipoempresa as Tipo, vnomempresa as Nombre, vdireccion as Direccion, ntelefono as Telefono, vdescripcion as Descripcion from MaEmpresa", "consulta", grdEmpresa);
        }
        private void btnirprimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdEmpresa);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdEmpresa);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdEmpresa);

        }

        private void btnirultimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdEmpresa);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar nuevoBuscar = new buscar();
            nuevoBuscar.Show();
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodempresa", "SELECT ncodempresa from MaEmpresa", "ncodempresa", cmbSeleccionado);
            cnegocio.funconsultarRegistros("MaEmpresa", "SELECT ncodempresa as Codigo, vtipoempresa as Tipo, vnomempresa as Nombre, vdireccion as Direccion, ntelefono as Telefono, vdescripcion as Descripcion from MaEmpresa", "consulta", grdEmpresa);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funimprimir(txtImprimir);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, false);
            cnegocio.funactivarDesactivarCombobox(cmbSeleccionado, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, true);
            cnegocio.funactivarDesactivarCombobox(cmbSeleccionado, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, true);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            TextBox[] datos = { txtEstado, txtNombre, txtDireccion, txtTelefono, txtDescripcion };
            string tabla = "MaEMPRESA";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            txtEstado.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtDescripcion.Text = "";
            txtTelefono.Text = "";
           
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEstado.Text = cmbEstado.Text;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            /*
       funeliminarRegistro(1,2,3,4);
       * 1) Nombre tabla a eliminar registro
       * 2) Código de llave primaria a eliminar
       * 3) Campo de llave primaria 
       * 4) Nombre del campo estado de la tabla
       */
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "MaEMPRESA";
            codEliminar =  cmbSeleccionado.SelectedValue.ToString();
            campoLlavePrimaria = "ncodempresa";
            campoEstado = "vtipoempresa";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            TextBox[] datos = { txtEstado, txtNombre, txtDireccion, txtTelefono, txtDescripcion };
            string tabla = "MaEMPRESA";
            Boolean permiso = true;
            string codigo = cmbSeleccionado.SelectedValue.ToString();
            cn.EditarObjetos(tabla, permiso, datos, codigo, "ncodempresa");
            cmbSeleccionado.Enabled = true;
            txtEstado.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtDescripcion.Text = "";
            txtTelefono.Text = "";
        }

       
    }
}
