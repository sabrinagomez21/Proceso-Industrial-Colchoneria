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
            E_ManageRol pNameRol = new E_ManageRol();     
            pNameRol.Nombre_Rol = txtname.Text.Trim();
            new N_ManageRol().Insert_Rol(pNameRol);
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
            E_ManageRol pRol = new N_ManageRol().GetSingle_Rol(Llave); // busca los atributos de la llave y los obtiene para cada registro 
            txtID.Text = Convert.ToString(pRol.Id_Rol);
            txtname.Text = pRol.Nombre_Rol;
            
            
        }

        private void ActualizarForm()
        {
            try
            {
                dgvRoles.DataSource = new N_ManageRol().GetAll(); // tiene todos los registro del datatable
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
            dgvRoles.DataSource = D_ManageRol.BuscarRegisRol(txtname.Text);
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
            E_ManageRol pRol = new E_ManageRol();
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                pRol.Id_Rol = Convert.ToInt32(txtID.Text);
                new N_ManageRol().Delete_Rol(pRol);
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
            E_ManageRol pRol = new E_ManageRol();
            pRol.Id_Rol = Convert.ToInt16(txtID.Text);
            pRol.Nombre_Rol = txtname.Text.Trim();
            new N_ManageRol().Update_Rol(pRol);
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm();
        }
        
    }
}
