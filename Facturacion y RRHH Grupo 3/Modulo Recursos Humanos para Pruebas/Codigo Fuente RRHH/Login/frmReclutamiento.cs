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
    public partial class frmReclutamiento : Form
    {
        public frmReclutamiento()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //finaliza cambio de richtextbox a textbox para enviar a BD
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtDepartamento, true);
            cnegocio.funactivarDesactivarTextbox(txtcausa, true);
            cnegocio.funactivarDesactivarTextbox(txtEmpleado, true);
            cnegocio.funactivarDesactivarTextbox(txtCapacidades, true);
            cnegocio.funactivarDesactivarTextbox(txtHorario, true);
            cnegocio.funactivarDesactivarTextbox(txtTipo, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, true);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMin, true);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMax, true);
            cnegocio.funactivarDesactivarCombobox(cmbCodEmpresa, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, true);
        
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            TextBox[] datos = { txtDepartamento, txtcausa, txtEmpleado, txtCapacidades, txtHorario, txtTipo, txtDescripcion, txtSueldoMin, txtSueldoMax, txtCodigoEmpresa };
            string tabla = "MaPLAZA";
            Boolean permiso = true;
            string codigo = cmbCodigoSeleccionado.SelectedValue.ToString();
            cn.EditarObjetos(tabla, permiso, datos, codigo, "ncodplaza");
            cmbCodigoSeleccionado.Enabled = true;
            txtDepartamento.Text = "";
            txtcausa.Text = "";
            txtEmpleado.Text = "";
            txtCapacidades.Text = "";
            txtHorario.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            txtSueldoMin.Text = "";
            txtSueldoMax.Text = "";
            txtCodigoEmpresa.Text = "";
            
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            cbDepartamento.Text = txtDepartamento.Text;
            cbcausa.Text = txtcausa.Text;
            cmbEstado.Text = txtTipo.Text;

            TextBox[] datos = { txtDepartamento, txtcausa, txtEmpleado, txtCapacidades, txtHorario, txtTipo, txtDescripcion, txtSueldoMin, txtSueldoMax, txtCodigoEmpresa };
            string tabla = "MaPLAZA";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            txtDepartamento.Text = "";
            txtcausa.Text = "";
            txtEmpleado.Text = "";
            txtCapacidades.Text = "";
            txtHorario.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            txtSueldoMin.Text = "";
            txtSueldoMax.Text = "";
            txtCodigoEmpresa.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            //finaliza cambio de richtextbox a textbox para enviar a BD
            cnegocio.funactivarDesactivarTextbox(txtDepartamento, false);
            cnegocio.funactivarDesactivarTextbox(txtcausa, false);
            cnegocio.funactivarDesactivarTextbox(txtEmpleado, false);
            cnegocio.funactivarDesactivarTextbox(txtCapacidades, false);
            cnegocio.funactivarDesactivarTextbox(txtHorario, false);
            cnegocio.funactivarDesactivarTextbox(txtTipo, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMin, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoMax, false);
            cnegocio.funactivarDesactivarCombobox(cmbCodEmpresa, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodempresa", "SELECT ncodempresa from MaEmpresa", "ncodempresa", cmbCodEmpresa);
            cnegocio.funconsultarRegistrosCombo("ncodplaza", "SELECT ncodplaza from MaPlaza", "ncodplaza", cmbCodigoSeleccionado);
            cnegocio.funconsultarRegistros("MaPlaza", "SELECT ncodplaza as Codigo, vdepartamento as Departamento, vcausasolicitud as CausaSolicitud, vtipoempleado as Empleado, vcapacidadesrequeridas as CapacidadesRequeridas, vhorario as Horario, vtipo as Estado, vdescripcion as Descripcion, dsueldomin as SueldoMinimo, dsueldomax as SueldoMaximo, ncodempresa as CodigoEmpresa from MaPLAZA", "consulta", grdReclutamiento);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funimprimir(txtImprimir);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar newMDIChild = new buscar();
            newMDIChild.Show();
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

        private void frmReclutamiento_Load(object sender, EventArgs e)
        {
             clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodempresa", "SELECT ncodempresa from MaEmpresa", "ncodempresa", cmbCodEmpresa);
            cnegocio.funconsultarRegistrosCombo("ncodplaza", "SELECT ncodplaza from MaPlaza", "ncodplaza", cmbCodigoSeleccionado);
            cnegocio.funconsultarRegistros("MaPlaza", "SELECT ncodplaza as Codigo, vdepartamento as Departamento, vcausasolicitud as CausaSolicitud, vtipoempleado as Empleado, vcapacidadesrequeridas as CapacidadesRequeridas, vhorario as Horario, vtipo as Estado, vdescripcion as Descripcion, dsueldomin as SueldoMinimo, dsueldomax as SueldoMaximo, ncodempresa as CodigoEmpresa from MaPLAZA", "consulta", grdReclutamiento);
        }
        }
    }

