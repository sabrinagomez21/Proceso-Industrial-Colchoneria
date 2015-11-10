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
    public partial class frmConciliacion : Form
    {
        public frmConciliacion()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Today;
            lblfeha.Text = fecha.Year.ToString() + "/" + fecha.Month.ToString() + "/" + fecha.Day.ToString();
            funBuscarCuentas();
        }
        private void funBuscarCuentas()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodcuenta", "SELECT ncodcuenta from macuenta ", "ncodcuenta", cmbcuenta);
        }

        private void grbConciliacion_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtEncargado, true);
            cnegocio.funactivarDesactivarCombobox(cmbcuenta, true);
            cnegocio.funactivarDesactivarCombobox(cmbMes, true);

        }

        private void pnlInformacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtcuenta.Text = cmbcuenta.Text;
            txtFecha.Text = lblfeha.Text;
            //System.Console.Write(txtFecha.Text+" -- "+ lblfeha.Text +"--->"+cmbcuenta.Text+"<----");
            TextBox[] datos = { txtFecha, txtEncargado, txtEstado, txtcuenta };
            string tabla = "maencabezadoconciliacion";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio(); 
            cn.AsignarObjetos(tabla, permiso, datos);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtcuenta.Text = cmbcuenta.Text;
            txtFecha.Text = lblfeha.Text;
            //System.Console.Write(txtFecha.Text+" -- "+ lblfeha.Text +"--->"+cmbcuenta.Text+"<----");
            TextBox[] datos = { txtFecha, txtEncargado, txtEstado, txtcuenta };
            string tabla = "maencabezadoconciliacion";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);

        }

        private void funLlenarTabla(string mes)
        {

        }
    }
}
