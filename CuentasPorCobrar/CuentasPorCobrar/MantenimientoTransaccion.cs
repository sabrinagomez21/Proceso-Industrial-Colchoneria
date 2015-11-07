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

namespace CuentasPorCobrar
{
    public partial class MantenimientoTransaccion : Form
    {
        public MantenimientoTransaccion()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombreTr, true);
            cnegocio.funactivarDesactivarCombobox(cmbOperacionTr, true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtOperacionTr.Text = cmbOperacionTr.SelectedItem.ToString();
            TextBox[] aDatos = { txtNombreTr, txtOperacionTr};
            string sTabla = "matipotransaccion";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
        }
    }
}
