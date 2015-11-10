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
    public partial class frmReclutamiento : Form
    {
        public frmReclutamiento()
        {
            InitializeComponent();
        }
        private void frmReclutamiento_Load(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodempresa", "SELECT ncodempresa from MaEmpresa", "ncodempresa", cmbCodEmpresa);
            cnegocio.funconsultarRegistrosCombo("ncodsolicitud", "SELECT ncodsolicitud from TrSolicitud", "ncodsolicitud", cmbSolicitud);
            cnegocio.funconsultarRegistrosCombo("ncodplaza", "SELECT ncodplaza from MaPlaza", "ncodplaza", cmbCodigoSeleccionado);
            cnegocio.funconsultarRegistros("MaPlaza", "SELECT ncodplaza as Codigo, vtipo as Tipo, vdescripcion as Descripcion, vsueldomin as SueldoMinimo, vsueldomax as SueldoMaximo, vhorario as Horario, ncodempresa as CodigoEmpresa, ncodsolicitud as CodigoSolicitud from MaPLAZA", "consulta", grdReclutamiento);
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //finaliza cambio de richtextbox a textbox para enviar a BD
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCodigo, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, true);
            cnegocio.funactivarDesactivarTextbox(txtTipo, true);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMin, true);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMax, true);
            cnegocio.funactivarDesactivarTextbox(txtHorario, true);
            cnegocio.funactivarDesactivarCombobox(cmbCodEmpresa, true);
            cnegocio.funactivarDesactivarCombobox(cmbSolicitud, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            TextBox[] datos = { txtCodigo, txtTipo, txtDescripcion, txtSueldoMin, txtSueldoMax, txtHorario, txtCodigoEmpresa, txtCodigoSolicitud };
            string tabla = "MaPLAZA";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            txtCodigo.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            txtSueldoMin.Text = "";
            txtSueldoMax.Text = "";
            txtHorario.Text = "";
            txtCodigoEmpresa.Text = "";
            txtCodigoSolicitud.Text = "";
            
 
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodempresa", "SELECT ncodempresa from MaEmpresa", "ncodempresa", cmbCodEmpresa);
            cnegocio.funconsultarRegistrosCombo("ncodsolicitud", "SELECT ncodsolicitud from TrSolicitud", "ncodsolicitud", cmbSolicitud);
            cnegocio.funconsultarRegistrosCombo("ncodplaza", "SELECT ncodplaza from MaPlaza", "ncodplaza", cmbCodigoSeleccionado);
            cnegocio.funconsultarRegistros("MaPlaza", "SELECT ncodplaza as Codigo, vtipo as Tipo, vdescripcion as Descripcion, vsueldomin as SueldoMinimo, vsueldomax as SueldoMaximo, vhorario as Horario, ncodempresa as CodigoEmpresa, ncodsolicitud as CodigoSolicitud from MaPLAZA", "consulta", grdReclutamiento);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCodigo, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, false);
            cnegocio.funactivarDesactivarTextbox(txtTipo, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMin, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMax, false);
            cnegocio.funactivarDesactivarTextbox(txtHorario, false);
            cnegocio.funactivarDesactivarCombobox(cmbCodEmpresa, false);
            cnegocio.funactivarDesactivarCombobox(cmbSolicitud, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
            
        }

        private void cmbCodEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoEmpresa.Text = cmbCodEmpresa.Text;
        }

        private void cmbSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoSolicitud.Text = cmbSolicitud.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTipo.Text = cmbEstado.Text;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            TextBox[] datos = { txtCodigo, txtTipo, txtDescripcion, txtSueldoMin, txtSueldoMax, txtHorario, txtCodigoEmpresa, txtCodigoSolicitud };
            string tabla = "MaPLAZA";
            Boolean permiso = true;
            string codigo = cmbCodigoSeleccionado.SelectedValue.ToString();
            cn.EditarObjetos(tabla, permiso, datos, codigo, "ncodplaza");
            cmbCodigoSeleccionado.Enabled = true;
            txtCodigo.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            txtSueldoMin.Text = "";
            txtSueldoMax.Text = "";
            txtHorario.Text = "";
            txtCodigoEmpresa.Text = "";
            txtCodigoSolicitud.Text = "";
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
            tabla = "MaPLAZA";
            codEliminar = cmbCodigoSeleccionado.SelectedValue.ToString();
            campoLlavePrimaria = "ncodplaza";
            campoEstado = "vtipo";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
        }

        private void cmbCodigoSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoSeleccionado.Text = cmbCodigoSeleccionado.SelectedValue.ToString();
        }

        private void grdReclutamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdReclutamiento.Rows[e.RowIndex];
            cmbCodigoSeleccionado.SelectedValue = row.Cells[0].Value.ToString();
            cmbCodigoSeleccionado.Enabled = false;
            txtCodigo.Text = row.Cells[1].Value.ToString();
            txtTipo.Text = row.Cells[2].Value.ToString();
            txtDescripcion.Text = row.Cells[3].Value.ToString();
            txtSueldoMin.Text = row.Cells[4].Value.ToString();
            txtSueldoMax.Text = row.Cells[5].Value.ToString();
            txtHorario.Text = row.Cells[6].Value.ToString();
            cmbCodEmpresa.Text = row.Cells[6].Value.ToString();
            cmbSolicitud.Text = row.Cells[7].Value.ToString();


        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funimprimir(txtImprimir);
        }

        private void btnirprimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdReclutamiento);

        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdReclutamiento);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdReclutamiento);

        }

        private void btnirultimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdReclutamiento);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar newMDIChild = new buscar();
            newMDIChild.Show();
        }


       
    }
}
