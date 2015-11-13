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
    public partial class frmEntregasParciales : Form
    {
        public frmEntregasParciales()
        {
            InitializeComponent();
        }
      
        //public DataTable CargarOrden()
        //{
        //    DataTable dt = new DataTable(); // se crea la variable para el datatable
        //    string query = "SELECT iidpelicula,vtitulo from MAPELICULA;"; // query de seleccion
        //    MySqlCommand comando = new MySqlCommand(query, dllConexion.dllConexion.Conexion()); //ejecucion del query
        //    MySqlDataAdapter da = new MySqlDataAdapter(comando); // ejecucion del comando
        //    cnombrePelicula.DisplayMember = "vtitulo"; // muestra el nombre de la pelicula
        //    cnombrePelicula.ValueMember = "iidpelicula"; // al momento de seleccionar la pelicula se seleccionara el ID
        //    da.Fill(dt); // llena cada columna
        //    dllConexion.dllConexion.Conexion().Close(); // ciere de conexion
        //    return dt;
        //}


        private void frmEntregasParciales_Load(object sender, EventArgs e)
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
            cbxNoOrden.ValueMember = "ncodordenes";
            cbxNoOrden.DisplayMember = "ncodordenes";
            cbxNoOrden.DataSource = new N_Aplicacion().Ordenes();
            dgvEntregasParciales.DataSource = new N_Aplicacion().GetEntregasParciales(); // llama los registros y los llena a la tabla
            dgvEntregasParciales.Refresh(); // refresca el datagrid

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //DateTime date = this.dFechaEntrega.Value;
            //this.txtfechaEntrega.Text = date.ToString("yyyy-mm-dd");
            //this.txtfechaEntrega.Tag = "ventregaproducto";
           
            //TextBox[] datos = { txtDocumento, txtCantidadaFabricar, txtfechaEntrega, txtProductoaFabricar };
            ////txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
            //string tabla = "MaORDEN";
            //Boolean permiso = true;
            //clasnegocio cn = new clasnegocio();
            //cn.AsignarObjetos(tabla, permiso, datos);
            //MessageBox.Show("");
        }

        private void cbxNoOrden_DropDownClosed(object sender, EventArgs e)
        {
            string NoOrden = this.cbxNoOrden.GetItemText(this.cbxNoOrden.SelectedItem);
            List<string> InfOrden = new N_Aplicacion().InfoOrdenes(NoOrden);
            int j  = 0;
            foreach (string IO in InfOrden)
            {
                if (j == 0)
                {
                    txtProductoaFabricar.Text = IO;
                }
                else if(j==1)
                {
                    txtCantidadaFabricar.Text = IO;
                }
                else if (j == 2)
                {
                    dFechaEntrega.Text = IO;
                }
                 j++;
            }

        }

        private void txtCostoUnitario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            DateTime date2 = this.ffechaMovimiento.Value;
            this.txtFechaMovimiento.Text = date2.ToString("yyyy-MM-dd");
            this.txtFechaMovimiento.Tag = "vultimomovimiento";
            //this.txtStatusOrden.Text = "1";
            string NoOrden = this.cbxNoOrden.GetItemText(this.cbxNoOrden.SelectedItem);
            int CantFabricar = new N_Aplicacion().CantidadFabricar(NoOrden);
            int CantTerminado = Convert.ToInt16(txtCantidadaEntregar.Text);
            int CantFaltante = CantFabricar - CantTerminado;
            TextBox txtProdFaltante = new TextBox();
            txtProdFaltante.Text = Convert.ToString(CantFaltante);
            txtProdFaltante.Tag = "ncantidadproductofaltante";
            TextBox[] datos = { txtDocumento, txtCantidadaEntregar, txtFechaMovimiento, txtProdFaltante};
            //txtProductoaFabricar, txtFechaMovimiento, txtDocumento, txtCantidadaEntregar, txtCostoUnitario, txtTotalDeLaEntrega
            string tabla = "MaORDEN";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.EditarObjetos(tabla, permiso, datos,NoOrden,"ncodordenes");
            MessageBox.Show("La orden a sido modificada");
            txtDocumento.Text = "";
            txtCantidadaEntregar.Text = "";
            txtCostoUnitario.Clear();
            txtTotalDeLaEntrega.Text = "";
        }


        private void txtTotalDeLaEntrega_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt16(txtCantidadaEntregar.Text);
            int costo = Convert.ToInt16(txtCostoUnitario.Text);
            int total = cantidad * costo;
            txtTotalDeLaEntrega.Text = Convert.ToString(total);
        }

       

        

    }
}
