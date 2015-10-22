using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLSeguridad
{
    public partial class frmIngresoRol : Form
    {
        public frmIngresoRol()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            E_ManejoRol pNameRol = new E_ManejoRol();
            pNameRol.Nombre = txtname.Text.Trim();
            new N_ManejoRol().Insert_Rol(pNameRol);
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm();
        }

        private void frmIngresoRol_Load(object sender, EventArgs e)
        {
           ActualizarForm();
        }


        private void BuscarRol(int Llave)
        {
            E_ManejoRol pRol = new N_ManejoRol().GetSingle_Rol(Llave); // busca los atributos de la llave y los obtiene para cada registro 
            txtID.Text = Convert.ToString(pRol.Id);
            txtname.Text = pRol.Nombre;
            
        }

        private void ActualizarForm()
        {
            try
            {
                dgvRoles.DataSource = new N_ManejoRol().GetAll(); // tiene todos los registro del datatable
                dgvRoles.Refresh();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            DataGridViewRow row = dgvRoles.Rows[e.RowIndex];

            int valor = (int)row.Cells[0].Value;
            BuscarRol(valor);

            //if (btnEliminar.Enabled == false || btnActualizar.Enabled == false)
            //{
            //    btnEliminar.Enabled = true;
            //    btnActualizar.Enabled = true;
            //    btnInsertar.Enabled = false;
            //}

            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dgvRoles.DataSource = D_ManejoRol.BuscarRegisRol(txtname.Text);
            if (dgvRoles.Rows.Count > 0)
            {
                MessageBox.Show("Registro Encontrado");
               
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
             
                txtname.ResetText();
            }
            else
            {
                MessageBox.Show("Registro No Encontrado !");
                txtname.ResetText();
                txtID.ResetText();
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = false;
                dgvRoles.DataSource = null;
                dgvRoles.Refresh();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            E_ManejoRol pRol = new E_ManejoRol();
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                pRol.Id = Convert.ToInt32(txtID.Text);
                new N_ManejoRol().Delete_Rol(pRol);
                ActualizarForm();
                txtname.ResetText();
                txtID.ResetText();
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No hay Codigo Disponible", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActualizarForm();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            E_ManejoRol pRol = new E_ManejoRol();
            pRol.Id = Convert.ToInt16(txtID.Text);
            pRol.Nombre = txtname.Text.Trim();
            new N_ManejoRol().Update_Rol(pRol);
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm();
        }
        
    }
}
