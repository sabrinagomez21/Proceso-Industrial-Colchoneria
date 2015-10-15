using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Rol
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }
        public E_Rol EmpleadoSeleccionado { get; set; }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dvgbuscar.DataSource = D_Rol.Buscar(txtname.Text, txtlastname.Text);

            if (dvgbuscar.Rows.Count > 0)
            {
                MessageBox.Show("Registro Encontrado");
                btnaccept.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro No Encontrado !");
                txtname.ResetText();
                txtlastname.ResetText();
                btnaccept.Enabled = false;
                dvgbuscar.DataSource = null;
                dvgbuscar.Refresh();
            }
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            frmManejoRol Empleado = new frmManejoRol();
            Empleado.txtUsuario.Text = this.dvgbuscar.CurrentRow.Cells[0].Value.ToString();
            Empleado.txtNombreUsuario.Text = this.dvgbuscar.CurrentRow.Cells[1].Value.ToString();
            this.Close();
            Empleado.Show();
            Empleado.CargarRolAsig();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtlastname.ResetText();
            btnaccept.Enabled = false;
            dvgbuscar.DataSource = null;
            dvgbuscar.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmManejoRol rol = new frmManejoRol();
            rol.Show();
        }
    }
}
