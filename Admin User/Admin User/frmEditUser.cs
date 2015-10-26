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
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            E_Registro pUser = new E_Registro(); // Aca cargamos los datos que se encuentren en el formulario de edicion de usuarios.
            pUser.IdUser = Convert.ToInt16(txtid.Text);
            pUser.NombreUser = txtNombreUsuario.Text.Trim();
            pUser.ApellidoUser = txtApellidoUsuario.Text.Trim();
            pUser.EmailUser = txtEmail.Text.Trim();
            pUser.User = txtUsuario.Text.Trim();
            pUser.Password = txtPassword.Text.Trim();
           
            new N_EditUser().Update_User(pUser);// al realizar la modificacion, limpiaremos todos los campos.
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
            //Metodo en el cual cumple la funcion de tomar los datos que se encuentran en las cajas de texto.
                E_Registro pUser = new E_Registro();
                pUser.IdUser = Convert.ToInt16(txtid.Text);
                pUser.NombreUser = txtNombreUsuario.Text.Trim();
                pUser.ApellidoUser = txtApellidoUsuario.Text.Trim();
                pUser.EmailUser = txtEmail.Text.Trim();
                pUser.User = txtUsuario.Text.Trim();
                pUser.Password = txtPassword.Text.Trim();
            // al realizar el funcion de eliminar los registros cargados en las cajas de texto, las limpiamos para poder realizar otra busqueda.    
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
            //Si al realizar la busqueda ya no deseamos realizar otra actividad este codigo nos permite borrar los datos que se encuentran cargados.
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
            //Si ya realizamos la actvidad deseada y deseamos realizar otra busqueda tenemos este meotodo en el cual ocultamos el formulario de edicion y mostrados el formulario de busqueda.
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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
