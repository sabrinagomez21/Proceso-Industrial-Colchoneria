//Modulo de Registro y busqueda de usuarios al sistema.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo

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
            //metodo en el cual cargamos los datos que se encuentren en las cajas de texto para luego mandarla a las variables que se encuentran en la clase
            //E_Registro.
            E_Registro pUser = new E_Registro();
            pUser.NombreUser = txtNombreUsuario.Text.Trim();
            pUser.ApellidoUser = txtApellidoUsuario.Text.Trim();
            pUser.EmailUser = txtEmail.Text.Trim();
            pUser.Password = txtPassword.Text.Trim();
            pUser.User = txtUsuario.Text.Trim();
            //Al terminar el registro del usuario nuevo limpiamos los valores para poder realizar otra accion.
            new N_Registro().Insert_User(pUser);
            txtNombreUsuario.ResetText();
            txtApellidoUsuario.ResetText();
            txtEmail.ResetText();
            txtPassword.ResetText();
            txtUsuario.ResetText();
       
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void gbRegistro_Enter(object sender, EventArgs e)
        {

        }
    }
}
