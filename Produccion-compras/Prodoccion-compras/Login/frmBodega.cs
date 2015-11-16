using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;

namespace Login
{   

    public partial class frmBodega : Form
    {
        private bool editar;
        private bool nuevo;
        private bool eliminar;
        public frmBodega()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtCantidad, true);
            cnegocio.funactivarDesactivarTextbox(txtEstado, true);
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnguardar.Enabled = true;
            nuevo = true;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(nuevo==true)
            {
                TextBox[] datos = { txtNombre, txtCantidad, txtEstado };
                string tabla = "MaMATERIAL";
                Boolean permiso = true;
                clasnegocio cn = new clasnegocio();
                cn.AsignarObjetos(tabla, permiso, datos);
                txtNombre.Clear();
                txtCantidad.Clear();
                txtEstado.Clear();                
            }else if(editar==true){
                TextBox[] datos = { txtNombre, txtCantidad, txtEstado };
                clasnegocio cn = new clasnegocio();
                string tabla = "MaMATERIAL";
                Boolean permiso = true;
                cn.EditarObjetos(tabla, permiso, datos, lblcod.Text, "ncodmaterial");
                txtNombre.Clear();
                txtCantidad.Clear();
                txtEstado.Clear(); 
            }
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {           
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("MaMATERIAL", "SELECT ncodmaterial AS 'Codigo', vnombre AS 'Nombre',ncantidad AS 'Cantidad',vestatus AS 'Estado' FROM MaMATERIAL", "consulta", dgvMaterial);
            dgvMaterial.Columns["Codigo"].Width = 0;
        }
        private void edit()
        {
            this.lblcod.Text = this.dgvMaterial.CurrentRow.Cells[0].Value.ToString();
            this.txtNombre.Text = this.dgvMaterial.CurrentRow.Cells[1].Value.ToString();
            this.txtCantidad.Text = this.dgvMaterial.CurrentRow.Cells[2].Value.ToString();
            this.txtEstado.Text = this.dgvMaterial.CurrentRow.Cells[3].Value.ToString();
        }
        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
            //asignacion de cada columna para el fomulario de edicion de los datos           
            edit();
        }
        private void permiso()
        {
            clasnegocio nuevo = new clasnegocio();
            nuevo.funactivarDesactivarBoton(btnnuevo, Convert.ToBoolean(Permisos.btnnuevo));
            nuevo.funactivarDesactivarBoton(btneditar, Convert.ToBoolean(Permisos.btneditar));
            nuevo.funactivarDesactivarBoton(btneliminar, Convert.ToBoolean(Permisos.btneliminar));
            nuevo.funactivarDesactivarBoton(btnguardar, Convert.ToBoolean(Permisos.btnguardar));
            nuevo.funactivarDesactivarBoton(btncancelar, Convert.ToBoolean(Permisos.btncancelar));
            nuevo.funactivarDesactivarBoton(btnrefrescar, Convert.ToBoolean(Permisos.btnrefrescar));
            nuevo.funactivarDesactivarBoton(btnimprimir, Convert.ToBoolean(Permisos.btnimprimir));
            nuevo.funactivarDesactivarBoton(btnbuscar, Convert.ToBoolean(Permisos.btnbuscar));
            nuevo.funactivarDesactivarBoton(btnirPrimero, Convert.ToBoolean(Permisos.btnirPrimiero));
            nuevo.funactivarDesactivarBoton(btnanterior, Convert.ToBoolean(Permisos.btnanterior));
            nuevo.funactivarDesactivarBoton(btnsiguiente, Convert.ToBoolean(Permisos.btnsiguiente));
            nuevo.funactivarDesactivarBoton(btnirUltimo, Convert.ToBoolean(Permisos.btnirUltimo));
            frmReceta Receta = new frmReceta();

        }
        private void frmBodega_Load(object sender, EventArgs e)
        {
            permiso();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("MaMATERIAL", "SELECT ncodmaterial AS 'Codigo', vnombre AS 'Nombre',ncantidad AS 'Cantidad',vestatus AS 'Estado'"
            +"FROM MaMATERIAL", "consulta", dgvMaterial);
            dgvMaterial.Columns["Codigo"].Width = 0;
            dgvMaterial.Columns["Codigo"].Frozen = true;
        }

        private void dgvMaterial_DoubleClick(object sender, EventArgs e)
        {
            edit();
            editar = true;
            nuevo = false;
        }

    }
}
