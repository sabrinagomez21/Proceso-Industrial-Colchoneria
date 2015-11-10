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
        }

        private void cmbCodEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoEmpresa.Text = cmbCodEmpresa.Text;
        }

        private void cmbSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoSolicitud.Text = cmbSolicitud.Text;
        }

       
    }
}
