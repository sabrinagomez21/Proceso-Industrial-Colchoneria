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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                dgvBusquedaUsuario.DataSource = D_BusquedaUser.Buscar(txtNombreUsuario.Text, txtApellidoUsuario.Text + "%");
            }
            else
            {
                dgvBusquedaUsuario.DataSource = D_BusquedaUser.Buscar(txtNombreUsuario.Text + "%", txtApellidoUsuario.Text);
            }

            if (dgvBusquedaUsuario.Rows.Count > 0)
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
    }
}
