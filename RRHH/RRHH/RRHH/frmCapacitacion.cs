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
    public partial class frmCapacitacion : Form
    {
        public frmCapacitacion()
        {
            InitializeComponent();
        }

        private void frmCapacitacion_Load(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodcapacitacion", "SELECT ncodcapacitacion,vnecesidad  from MaCAPACITACION", "ncodcapacitacion", cbcodigo);
            cnegocio.funconsultarRegistros("MaCAPACITACION", "SELECT ncodcapacitacion as Codigo,vnecesidad as Funcion ,vobjetivo as Objetivo,vresultadosesperados as Resultados,vresponsable as Responsable,vdetalle as Detalle,iparticipantes as Participantes,vtiempo as Duracion,vnombrecapacitacion as NombreCapacitacion from MaCAPACITACION", "consulta", dgcapacitacion);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
           
            //finaliza cambio de richtextbox a textbox para enviar a BD

            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtrecibedetalle, true);
            cnegocio.funactivarDesactivarTextbox(txtrecibenecesidad, true);
            cnegocio.funactivarDesactivarTextbox(txtrecibeobjetivos, true);
            cnegocio.funactivarDesactivarTextbox(txtresultados, true);
            cnegocio.funactivarDesactivarTextbox(txtresponsable, true);
            cnegocio.funactivarDesactivarTextbox(txtnombrecapacitacion, true);
            cnegocio.funactivarDesactivarTextbox(txtparticipantes, true);
            cnegocio.funactivarDesactivarTextbox(txttiempo, true);
            cnegocio.funactivarDesactivarTextbox(txttipocapacitacion, true);
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void rtnecesidad_TextChanged(object sender, EventArgs e)
        {
            //this.rtnecesidad.TextChanged += new System.EventHandler(this.rtnecesidad_TextChanged);

        }

        private void rtdetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneditar_Click(object sender, EventArgs e)
        {

            
            TextBox[] arraytexto = { txtrecibedetalle, txtrecibenecesidad, txtrecibeobjetivos, txtresultados, txtresponsable, txtnombrecapacitacion, txtparticipantes, txttiempo, txttipocapacitacion};
            clasnegocio cn = new clasnegocio();

            string tabla = "MaCAPACITACION";
            Boolean permiso = true;
            string codigo = cbcodigo.SelectedValue.ToString();
            cn.EditarObjetos("MaCAPACITACION", permiso, arraytexto, codigo, "ncodcapacitacion");
          
            txtrecibedetalle.Text = "";
            txtrecibenecesidad.Text = "";
            txtrecibeobjetivos.Text = "";
            txtresultados.Text = "";
            txtresponsable.Text = "";
            txtnombrecapacitacion.Text = "";
            txtparticipantes.Text = "";
            txttiempo.Text = "";
            txttipocapacitacion.Text = "";   
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "MaCAPACITACION"; 
            codEliminar = cbcodigo.SelectedValue.ToString();
            campoLlavePrimaria = "ncodcapacitacion";
            campoEstado = "vtipo";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            TextBox[] datos = { txtrecibedetalle, txtrecibenecesidad, txtrecibeobjetivos, txtresultados, txtresponsable, txtnombrecapacitacion, txtparticipantes, txttiempo, txttipocapacitacion };
            string tabla = "MaCAPACITACION";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);

            txtrecibedetalle.Text = "";
            txtrecibenecesidad.Text = "";
            txtrecibeobjetivos.Text = "";
            txtresultados.Text = "";
            txtresponsable.Text = "";
            txtnombrecapacitacion.Text = "";
            txtparticipantes.Text = "";
            txttiempo.Text = "";
            txttipocapacitacion.Text = "";
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtrecibedetalle, false); 
            cnegocio.funactivarDesactivarTextbox(txtrecibenecesidad, false);
            cnegocio.funactivarDesactivarTextbox(txtrecibeobjetivos, false);
            cnegocio.funactivarDesactivarTextbox(txtresultados, false);
            cnegocio.funactivarDesactivarTextbox(txtresponsable, false);
            cnegocio.funactivarDesactivarTextbox(txtnombrecapacitacion, false);
            cnegocio.funactivarDesactivarTextbox(txtparticipantes, false);
            cnegocio.funactivarDesactivarTextbox(txttiempo, false);
            cnegocio.funactivarDesactivarTextbox(txttipocapacitacion, false);
            cnegocio.funactivarDesactivarCombobox(cbcodigo, false);

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();

            cnegocio.funconsultarRegistrosCombo("ncodcapacitacion", "SELECT ncodcapacitacion,vnombrecapacitacion from MaCAPACITACION ", "ncodcapacitacion", cbcodigo);
           cnegocio.funconsultarRegistros("MaCAPACITACION", "SELECT ncodcapacitacion as Codigo,vnecesidad as Necesidad,vobjetivo as Objetivo,vresultadosesperados as Resultados,vresponsable as Responsable,vdetalle as Detalle,iparticipantes as Participantes,vtiempo as Tiempo, vnombrecapacitacion as NombreCapacitacion,vtipo as Tipo from MaCAPACITACION ", "consulta", dgcapacitacion);

        }
       
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funimprimir(txtimprimir); // envía como parámetro a la función de imprimir contenida en la dll,el nombre del textbox (textBox4).
            groupBox2.Enabled = true;
            gbimpresion.Enabled = true; 
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar busc = new buscar(); 
            busc.Show();
        }

        private void btnirprimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funPrimero(dgcapacitacion);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funAnterior(dgcapacitacion);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funSiguiente(dgcapacitacion); // parámetro que envía es nombre del GridView el cual
        }

        private void btnirultimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funUltimo(dgcapacitacion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasconexion.funobtenerConexion();
            MessageBox.Show("iniciando conexion");
        }
    }
}



