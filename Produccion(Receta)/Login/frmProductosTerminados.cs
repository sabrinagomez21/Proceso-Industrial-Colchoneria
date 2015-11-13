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
            dgvProductoTerminado.DataSource = new N_Aplicacion().GetProductosTerminados(); // llama los registros y los llena a la tabla
            dgvProductoTerminado.Refresh(); 
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
            string nombreProd = new N_Aplicacion().NombreProd(NoOrden);
            string nombreProd2 = new N_Aplicacion().NombreProd2(nombreProd);
            string idProd2 = new N_Aplicacion().idProd2(nombreProd);
           
            int CantFabricar = new N_Aplicacion().CantidadFabricar(NoOrden);
            int CantFaltante = CantFabricar - CantFabricar;
            TextBox txtProdFaltante = new TextBox();
            txtProdFaltante.Text = Convert.ToString(CantFaltante);
            txtProdFaltante.Tag = "ncantidadproductofaltante";
            TextBox txtProdTerminado = new TextBox();
            txtProdTerminado.Text = Convert.ToString(CantFabricar);
            txtProdTerminado.Tag = "ncantidadnoproductoterminado";
            TextBox statusOrden = new TextBox();
            statusOrden.Text = "Entregado";
            statusOrden.Tag = "vestatusorden";
            if (nombreProd == nombreProd2)
            {
                TextBox nexistencia = new TextBox();
                nexistencia.Text = Convert.ToString(CantFabricar);
                nexistencia.Tag = "nexistencia";
                TextBox[] datos1 = { nexistencia };
                //txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
                string tabla1 = "maproducto";
                Boolean permiso1 = true;
                clasnegocio cn1 = new clasnegocio();
                cn1.EditarObjetos(tabla1, permiso1, datos1, idProd2, "ncodarticulo");
            }
            TextBox[] datos = { txtProdTerminado, txtProdFaltante, statusOrden };
            //txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
            string tabla = "maordenproduccion";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.EditarObjetos(tabla, permiso, datos, NoOrden, "ncodordenes");
            MessageBox.Show("La orden a sido Terminada");
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            dgvProductoTerminado.DataSource = new N_Aplicacion().GetProductosTerminados(); // llama los registros y los llena a la tabla
            dgvProductoTerminado.Refresh(); 
        }
    }
}
