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
    public partial class frmReceta : Form
    {
        public frmReceta()
        {
            InitializeComponent();
        }
        public int idReceta;
        private void frmReceta_Load(object sender, EventArgs e)
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
            cmbMaterial.ValueMember = "ncodmaterial";
            cmbMaterial.DisplayMember = "vnombre";
            cmbMaterial.DataSource = new N_Aplicacion().Materiales();
            cmbMaterial.Enabled = false;
            txbCantidad.Enabled = false;
            btnAñadir.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            TextBox[] datos = { txbNombreReceta,txbHoraHombre };
            //txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
            string tabla = "MaRECETA";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            MessageBox.Show("Receta Ingresada Exitosamente");
            idReceta = new N_Aplicacion().UltimoID();
            
            this.txbNombreReceta.Enabled = false;
            this.txbHoraHombre.Enabled = false;
            cmbMaterial.Enabled = true;
            txbCantidad.Enabled = true;
            btnAñadir.Enabled = true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

            string NoMaterial = this.cmbMaterial.SelectedValue.ToString();
            TextBox Materia = new TextBox();
            Materia.Text = NoMaterial;
            Materia.Tag = "ncodmaterial";
            TextBox Receta = new TextBox();
            Receta.Text = Convert.ToString(idReceta);
            Receta.Tag = "ncodreceta";
            //MessageBox.Show(Convert.ToString(idReceta));
            TextBox[] datos = { Receta, txbCantidad, Materia };
            //txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
            string tabla = "TrDETALLERECETA";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            MessageBox.Show("Detalle Receta Ingresada Exitosamente");
            txbCantidad.Text = "";
        }

       

      
    }
}
