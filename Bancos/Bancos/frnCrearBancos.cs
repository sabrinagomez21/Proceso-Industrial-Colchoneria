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
    public partial class frmCrearBancos : Form
    {
        public frmCrearBancos()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            System.Console.WriteLine("esto es lo que tiene---- "+cmbEstado.SelectedItem.ToString());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true); 
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string tabla = "mabanco";
            Boolean permiso = true;
            txtEstado.Text = cmbEstado.SelectedItem.ToString();
            TextBox[] datos = { txtNombre, txtDireccion, txtEstado };

            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            funLimpiar();
        }

        void funLimpiar(){
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
        }

        void funLlenarTabla()
        {

        }
    }
}
