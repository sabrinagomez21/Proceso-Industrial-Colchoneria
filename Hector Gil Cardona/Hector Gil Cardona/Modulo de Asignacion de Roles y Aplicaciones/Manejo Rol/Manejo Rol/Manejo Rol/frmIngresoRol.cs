/* Proyecto Desarrollado y Elaborado Por: Hector Joannes Gil Cardona
 * Fecha de Asignacion: 23 de Septiembre
 * Fecha de Entrega: 10 de Octubre
 * 
 */
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
    public partial class frmIngresoRol : Form
    {
        public frmIngresoRol()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            E_ManageRol pNameRol = new E_ManageRol();     // instancia ala capa Entidad Manejo Rol para llamar a las variables
            pNameRol.Nombre_Rol = txtname.Text.Trim();  // asignacion de la variable Nombre_Rol al textbox txtname
            new N_ManageRol().Insert_Rol(pNameRol); // se crea nuevo metodo para la insercion a la capa de Negocios N_ManejoRol la entidad pNameRol
             //limpia los textbox
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm(); //llama al void actualia form el cual actualiza lixtobos de roles
        }



       


        private void frmIngresoRol_Load(object sender, EventArgs e)
        {
           ActualizarForm(); // actualiza el listbox de los roles
        }


        private void BuscarRol(int Llave)
        {
            // instancia de la capa Entidad Rol
            E_ManageRol pRol = new N_ManageRol().GetSingle_Rol(Llave); // busca los atributos de la llave y los obtiene para cada registro 
            txtID.Text = Convert.ToString(pRol.Id_Rol); //asociacion de textbox id a la variable id del rol 
            txtname.Text = pRol.Nombre_Rol; //asociacion textbox name a la variable rol de la capa entidad
            
            
        }

        private void ActualizarForm()
        {
            try
            {
                dgvRoles.DataSource = new N_ManageRol().GetAll(); // tiene todos los registro del datatable
                dgvRoles.Refresh(); // refresca el datagrid

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1)) // si el indice de la fila es mayor a -1 lo retorna
            {
                return;
            }
            // seleccion de la fila en el grid

            DataGridViewRow row = dgvRoles.Rows[e.RowIndex];
            // el valor de la fila y celda se le asigna a la variable llave (valor)
            int valor = (int)row.Cells[0].Value;
            BuscarRol(valor); // manda como parametro el valor al void buscar rol
            // habilita botones
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            btnsearch.Enabled = false;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //instancia la capa de datos al datagrid utilizando como parametro el textbox name del form/
            dgvRoles.DataSource = D_ManageRol.BuscarRegisRol(txtname.Text);
            if (dgvRoles.Rows.Count > 0) // si el resultado de la busqueda es mayor a 0
            {
                // muestra mensaje y lo muestra en el grid
                MessageBox.Show("Registro Encontrado");
               
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = false;
             
                txtname.ResetText();
                btnCancelar.Enabled = true;
            }
            else
            {
                // no lo muestra y limpia textobox y datagrid 
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
                ActualizarForm();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // instancia  al acapa entidad del manejo rol
            E_ManageRol pRol = new E_ManageRol();
            // si el textbox id es diferente de null 
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                // hace la busqueda del id del registro
                pRol.Id_Rol = Convert.ToInt32(txtID.Text); // convierte el texto a int para su utilizacion
                new N_ManageRol().Delete_Rol(pRol); // intancia a la capa de negocios el id del rol
                ActualizarForm(); // actualiza el grid
                // habilita botones y limpia textbox
                txtname.ResetText();
                txtID.ResetText();
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                btnsearch.Enabled = true;
            }
            else
            {
                // no se encontro el registro
                MessageBox.Show("No hay Codigo Disponible", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActualizarForm();
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // edicion del rol
            E_ManageRol pRol = new E_ManageRol(); // intancia a la capa de 
            pRol.Id_Rol = Convert.ToInt16(txtID.Text); // asignacion de varible id_rol al textbox
            pRol.Nombre_Rol = txtname.Text.Trim(); // asignacion de variable nombre rol al textobx
            new N_ManageRol().Update_Rol(pRol); // creando metodo para la actualizacion del registro
            // limpiar textbox
            txtname.ResetText();
            txtID.ResetText();
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = true;
            btnsearch.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            ActualizarForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // limpia textbox y limpia grid
            txtname.ResetText();
            txtID.ResetText();
            ActualizarForm();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //limpia textbox y actualiza grid
            txtname.ResetText();
            txtID.ResetText();
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = true;
            btnsearch.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            ActualizarForm();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmManejoRol rol = new frmManejoRol();
            rol.Show();
            this.Hide();
        }
        
    }
}
