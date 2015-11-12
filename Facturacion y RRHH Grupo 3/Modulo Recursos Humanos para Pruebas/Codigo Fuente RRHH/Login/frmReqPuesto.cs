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
    public partial class frmReqPuesto : Form
    {
        public frmReqPuesto()
        {
            InitializeComponent();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            //finaliza cambio de richtextbox a textbox para enviar a BD
           
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtnombre, true);
            cnegocio.funactivarDesactivarTextbox(txtapellido, true);
            cnegocio.funactivarDesactivarTextbox(txtestadocivil, true);
            cnegocio.funactivarDesactivarTextbox(txtgenero, true);
            cnegocio.funactivarDesactivarTextbox(txtedad, true);
            cnegocio.funactivarDesactivarTextbox(txtinvisible, true);
            cnegocio.funactivarDesactivarTextbox(txtescolaridad, true);
            cnegocio.funactivarDesactivarTextbox(txtdpi, true);
            cnegocio.funactivarDesactivarTextbox(txttelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtsalario, true);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { txtnombre, txtapellido, txtestadocivil, txtgenero, txtedad, txtinvisible, txtinvisible, txtescolaridad, txtdpi, txttelefono, txtsalario };
            clasnegocio cn = new clasnegocio();

            string tabla = "MaEMPLEADO";
            Boolean permiso = true;
            string codigo = cbcodigo.SelectedValue.ToString();
            cn.EditarObjetos("MaEMPLEADO", permiso, arraytexto, codigo, "ncodempleado");

            txtnombre.Text = "";
            txtapellido.Text = "";
            txtestadocivil.Text = "";
            txtgenero.Text = "";
            txtedad.Text = "";
            txtinvisible.Text = "";
            txtescolaridad.Text = "";
            txtdpi.Text = "";
            txttelefono.Text = "";
            txtsalario.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "MaEMPLEADO";
            codEliminar = cbcodigo.SelectedValue.ToString();
            campoLlavePrimaria = "ncodempleado";
            campoEstado = "vtipo";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            TextBox[] datos = { txtnombre, txtapellido, txtestadocivil, txtgenero, txtedad, txtinvisible, txtescolaridad, txtdpi, txttelefono, txtsalario };
            string tabla = "MaEMPLEADO";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);

            txtnombre.Text = "";
            txtapellido.Text = "";
            txtestadocivil.Text = "";
            txtgenero.Text = "";
            txtedad.Text = "";
            txtinvisible.Text = "";
            txtescolaridad.Text = "";
            txtdpi.Text = "";
            txttelefono.Text = "";
            txtsalario.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtnombre, false);
            cnegocio.funactivarDesactivarTextbox(txtapellido, false);
            cnegocio.funactivarDesactivarTextbox(txtestadocivil, false);
            cnegocio.funactivarDesactivarTextbox(txtgenero, false);
            cnegocio.funactivarDesactivarTextbox(txtedad, false);
            cnegocio.funactivarDesactivarTextbox(txtinvisible, false);
            cnegocio.funactivarDesactivarTextbox(txtescolaridad, false);
            cnegocio.funactivarDesactivarTextbox(txtdpi, false);
            cnegocio.funactivarDesactivarTextbox(txtsalario, false);
            cnegocio.funactivarDesactivarCombobox(cbcodigo, false);
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();

            cnegocio.funconsultarRegistrosCombo("ncodempleado", "SELECT ncodempleado,vnomempleado from MaEMPLEADO ", "ncodempleado", cbcodigo);
            cnegocio.funconsultarRegistros("MaEMPLEADO", "SELECT ncodempleado as Codigo,vnomempleado as Nombre,vapeempleado as Empleado,vestadocivil as EstadoCivil,ntelefono as Telefono,nedad as Edad,vgenero as Genero from MaCAPACITACION ", "consulta", dgempleado);
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
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funPrimero(dgempleado);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funAnterior(dgempleado);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funSiguiente(dgempleado); // parámetro que envía es nombre del GridView el cual
        }

        private void btnirultimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); cnegocio.funUltimo(dgempleado);
        }
    }
}
