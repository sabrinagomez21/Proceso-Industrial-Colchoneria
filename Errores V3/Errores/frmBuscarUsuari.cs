using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Errores
{
    public partial class frmBuscarUsuari : Form
    {
        private frmErrores presentacionHandler;
        public frmBuscarUsuari()
        {
            InitializeComponent();
        }
        public frmBuscarUsuari(frmErrores Form)
        {
            InitializeComponent();
            presentacionHandler = Form;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            dvgbuscar.DataSource = cErrorD.Buscar(txtname.Text, txtlastname.Text);

            if (dvgbuscar.Rows.Count > 0)
            {
                MessageBox.Show("Registro Encontrado");
                btnaccept.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro No Encontrado !");
                btnaccept.Enabled = false;
                dvgbuscar.DataSource = null;
                dvgbuscar.Refresh();
            }
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            if (cUsuario.id > 0)
            {
                presentacionHandler.Usuario(cUsuario.id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }

        private void dvgbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            DataGridViewRow row = dvgbuscar.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            cUsuario.id = valor;
            MessageBox.Show("Usuario Seleccionado");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtlastname.ResetText();
            btnaccept.Enabled = false;
            dvgbuscar.DataSource = null;
            dvgbuscar.Refresh();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
