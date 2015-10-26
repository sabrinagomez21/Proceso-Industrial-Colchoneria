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
    public partial class frmBuscarUser : Form
    {
        public frmBuscarUser()
        {
            InitializeComponent();
        }

        //Aca encontraremos la funcion buscar un usuario.
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))//comprobamos que el campo no este vacio
            {
                dgvBusquedaUsuario.DataSource = D_BusquedaUser.Buscar(txtNombreUsuario.Text, txtApellidoUsuario.Text + "%");
            }
            else
            {
                dgvBusquedaUsuario.DataSource = D_BusquedaUser.Buscar(txtNombreUsuario.Text + "%", txtApellidoUsuario.Text);
            }

            if (dgvBusquedaUsuario.Rows.Count > 0) //si se encuentra el dato buscado se almacena en un data grid y nos muestra un mensaje que nuestra busqueda tuvo exito.
            {
                MessageBox.Show("Registro Encontrado");
                btnAceptar.Enabled = true;
                btncancelar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro No Encontrado !");
                txtNombreUsuario.ResetText();
                txtApellidoUsuario.ResetText();
                btnAceptar.Enabled = false;
                btncancelar.Enabled = false;
                dgvBusquedaUsuario.DataSource = null;
                dgvBusquedaUsuario.Refresh();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           //Al realizar una busqueda tendremos la oportunidad de editar el registro encontrado, por lo que al realizar la busqueda enviaremos 
            //los datos del data grid a los campos que se encuetran en el formulario frmEditUser
            frmEditUser usuario = new frmEditUser();
            usuario.txtid.Text = this.dgvBusquedaUsuario.CurrentRow.Cells[0].Value.ToString();
            usuario.txtNombreUsuario.Text = this.dgvBusquedaUsuario.CurrentRow.Cells[1].Value.ToString();
            usuario.txtApellidoUsuario.Text = this.dgvBusquedaUsuario.CurrentRow.Cells[2].Value.ToString();
            usuario.txtEmail.Text = this.dgvBusquedaUsuario.CurrentRow.Cells[3].Value.ToString();
            usuario.txtUsuario.Text = this.dgvBusquedaUsuario.CurrentRow.Cells[4].Value.ToString();
            usuario.txtPassword.Text = this.dgvBusquedaUsuario.CurrentRow.Cells[5].Value.ToString();
            usuario.btnCancelar.Enabled = true;
            usuario.btnEditar.Enabled = true;
            usuario.btnEliminar.Enabled = true;
            usuario.Show();
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
        //Si hemos terminado la busqueda podremos limpiar los datos que se encuentran en el datagrid
            txtNombreUsuario.ResetText();
             txtApellidoUsuario.ResetText();
            dgvBusquedaUsuario.DataSource = null;
            dgvBusquedaUsuario.Refresh();
        }

        private void frmBuscarUser_Load(object sender, EventArgs e)
        {

        }
    }
}
