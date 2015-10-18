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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            E_Registro pUser = new E_Registro();
            pUser.NombreUser = txtNombreUsuario.Text.Trim();
            pUser.ApellidoUser = txtApellidoUsuario.Text.Trim();
            pUser.EmailUser = txtEmail.Text.Trim();
            pUser.Password = txtPassword.Text.Trim();
            pUser.User = txtUsuario.Text.Trim();
            new N_Registro().Insert_User(pUser);
            txtNombreUsuario.ResetText();
            txtApellidoUsuario.ResetText();
            txtEmail.ResetText();
            txtPassword.ResetText();
            txtUsuario.ResetText();
       
        }
    }
}
