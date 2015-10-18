using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_User
{
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            E_Registro pUser = new E_Registro();
            pUser.IdUser = Convert.ToInt16(txtid.Text);
            pUser.NombreUser = txtNombreUsuario.Text.Trim();
            pUser.ApellidoUser = txtApellidoUsuario.Text.Trim();
            pUser.EmailUser = txtEmail.Text.Trim();
            pUser.User = txtUsuario.Text.Trim();
            pUser.Password = txtPassword.Text.Trim();
            new N_EditUser().Update_User(pUser);
            txtid.ResetText();
            txtNombreUsuario.ResetText();
            txtApellidoUsuario.ResetText();
            txtEmail.ResetText();
            txtUsuario.ResetText();
            txtPassword.ResetText();
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
                E_Registro pUser = new E_Registro();
                pUser.IdUser = Convert.ToInt16(txtid.Text);
                pUser.NombreUser = txtNombreUsuario.Text.Trim();
                pUser.ApellidoUser = txtApellidoUsuario.Text.Trim();
                pUser.EmailUser = txtEmail.Text.Trim();
                pUser.User = txtUsuario.Text.Trim();
                pUser.Password = txtPassword.Text.Trim();
                new N_EditUser().Delete_User(pUser);
                txtid.ResetText();
                txtNombreUsuario.ResetText();
                txtApellidoUsuario.ResetText();
                txtEmail.ResetText();
                txtUsuario.ResetText();
                txtPassword.ResetText();
                btnCancelar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
               
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtid.ResetText();
            txtNombreUsuario.ResetText();
            txtApellidoUsuario.ResetText();
            txtEmail.ResetText();
            txtUsuario.ResetText();
            txtPassword.ResetText();
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarUser buscar = new frmBuscarUser();
            buscar.Show();
            txtid.ResetText();
            txtNombreUsuario.ResetText();
            txtApellidoUsuario.ResetText();
            txtEmail.ResetText();
            txtUsuario.ResetText();
            txtPassword.ResetText();
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}
