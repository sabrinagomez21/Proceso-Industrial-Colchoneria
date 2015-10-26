using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicaciones
{
    public partial class frmEditarAplicacion : Form
    {
        public frmEditarAplicacion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombreUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            E_RegistroAp pUser = new E_RegistroAp();
            pUser.Idapli = Convert.ToInt16(txtIdAplicacion.Text);
            pUser.NombreAplicacion = txtNombreAplicacion.Text.Trim();
            pUser.NormbreForm = txtNombreFormulario.Text.Trim();
            
            new N_EditApli().Update_Aplicacion(pUser);
            
            txtIdAplicacion.ResetText();
            txtNombreAplicacion.ResetText();
            txtNombreFormulario.ResetText();
            
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            E_RegistroAp pUser = new E_RegistroAp();
            pUser.Idapli = Convert.ToInt16(txtIdAplicacion.Text);
            pUser.NombreAplicacion = txtNombreAplicacion.Text.Trim();
            pUser.NormbreForm = txtNombreFormulario.Text.Trim();
            
            new N_EditApli().Delete_app(pUser);
            txtIdAplicacion.ResetText();
            txtNombreAplicacion.ResetText();
            txtNombreFormulario.ResetText();
            
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarApli buscar = new frmBuscarApli();
            buscar.Show();
            txtIdAplicacion.ResetText();
            txtNombreAplicacion.ResetText();
            txtNombreFormulario.ResetText();
            
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
