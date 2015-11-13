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
    public partial class frmExplosionMateriales : Form
    {
        public frmExplosionMateriales()
        {
            InitializeComponent();
            cargarBox();
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
        private void cargarBox()
        {
            cmbProducto.DataSource = new cNegocioMateriales().obtenerProducto();
            cmbProducto.Refresh();
            cmbProducto.ValueMember = "ncodreceta";
            cmbProducto.DisplayMember = "vnombrereceta";
            cmbProducto.SelectedValue=0;
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {   
               dgvDetalle.DataSource = new cNegocioMateriales().Explotar(Convert.ToInt32(cmbProducto.SelectedValue));
               dgvDetalle.Refresh();
            }
            catch
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExplosionMateriales_Load(object sender, EventArgs e)
        {
            permiso();
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            cargarBox();

        }
    }
}
