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
    public partial class frmProductosTerminados : Form
    {
        public frmProductosTerminados()
        {
            InitializeComponent();
        }
        private void frmProductosTerminados_Load(object sender, EventArgs e)
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
            cmbOrden.ValueMember = "ncodordenes";
            cmbOrden.DisplayMember = "ncodordenes";
            cmbOrden.DataSource = new N_Aplicacion().Ordenes();
        }
        private void lProductoTerminado_Click(object sender, EventArgs e)
        {

        }

       

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string NoOrden = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //MessageBox.Show(NoOrden);
        }


        
        private void btnSi_Click(object sender, EventArgs e)
        {
            string NoOrden = this.cmbOrden.GetItemText(this.cmbOrden.SelectedItem);
            int CantFabricar = new N_Aplicacion().CantidadFabricar(NoOrden);
            int CantFaltante = CantFabricar - CantFabricar;
            TextBox txtProdFaltante = new TextBox();
            txtProdFaltante.Text = Convert.ToString(CantFaltante);
            txtProdFaltante.Tag = "ncantidadproductofaltante";
            TextBox txtProdTerminado = new TextBox();
            txtProdTerminado.Text = Convert.ToString(CantFabricar);
            txtProdTerminado.Tag = "ncantidadnoproductoterminado";
            TextBox[] datos = { txtProdTerminado, txtProdFaltante};
            //txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
            string tabla = "MaORDEN";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.EditarObjetos(tabla, permiso, datos, NoOrden, "ncodordenes");
            MessageBox.Show("La orden a sido Terminada");
        }
    }
}
