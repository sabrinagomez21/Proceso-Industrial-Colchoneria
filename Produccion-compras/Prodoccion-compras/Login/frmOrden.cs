//analista programador Walter Flores 0901-12-62
//ventana ordenes de produccion
//este formulario disminuye las materia prima para aumentar los productos terminados.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Navegador;
using DllSeguridad;

namespace Login
{
    public partial class frmOrden : Form
    {
        bool nuevo=false;
        bool editar = false;
        bool eliminar = false;
        public frmOrden()
        {
            InitializeComponent();
        }
        //habilitarmos los permisos del formulario
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
            
        }
        //crear nuevo documento
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            txtEntrega.Enabled = true;
            txtFabricar.Enabled = true;
            txtInicio.Enabled = true;
            txtstatus.Enabled = true;
            txtOrden.Text =Convert.ToString( cNegocioMateriales.producto());
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
      
        }
        //envia un mensaje si es que hay algun articulo que este bajo de produccion
        private void frmOrden_Load(object sender, EventArgs e)
        {
            //permiso();
            cargarBox();
            grid();
            OdbcDataReader read = cNegocioMateriales.numProducto();
            while(read.Read()){
                if(Convert.ToInt32( read.GetInt32(0))<5)
                {
                    string producto = Convert.ToString(read.GetString(1));
                    MessageBox.Show("Se necesita producir " + read.GetString(1), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
             
        }
        //llena de datos el selccionador de productos
        private void cargarBox()
        {
            cmbProducto.DataSource = new cNegocioMateriales().obtenerProducto();
            cmbProducto.Refresh();
            cmbProducto.ValueMember = "ncodreceta";
            cmbProducto.DisplayMember = "vnombrereceta";
            cmbProducto.SelectedValue = 0;
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            cargarBox();
            grid();
        }
        private void grid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maordenproduccion", "SELECT `ncodordenes`,`vreferenciaproducto`,`vinicioproduccion`,`ventregaproducto`, `ncantidadproductoafabricar`,`ncantidadnoproductoterminado`,`ncantidadproductofaltante`,`vestatusorden`, `ncodreceta` FROM maordenproduccion", "consulta", dgvDetalle);
            dgvDetalle.Columns["ncodordenes"].Width = 0;
        }
        private void txtFabricar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            editar = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //guarda el cambio (editar, nuevo registro)
        private void btnguardar_Click(object sender, EventArgs e)
        {
            //guardar
            if (nuevo == true)
            {
                try
                {
                    TextBox[] datos = { txtEntrega, txtFabricar, txtInicio, txtstatus, txtreferencia, txtcodreceta };
                    string tabla = "MaORDENPRODUCCION";
                    Boolean permiso = true;
                    clasnegocio cn = new clasnegocio();
                    cn.AsignarObjetos(tabla, permiso, datos);
                    txtOrden.Clear();
                    txtEntrega.Clear();
                    txtFabricar.Clear();
                    txtInicio.Clear();
                    txtstatus.Clear();
                    MessageBox.Show("Orden Creada Exitosamente"," ",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    //bitacora
                    E_Bitacora bita = new E_Bitacora();
                    bita.Id= E_Usuario.id;
                    bita.Accion=2;
                    //bita.Aplicacion=;
                    bita.detalle="Orden "+txtreferencia.Text+" "+txtOrden.Text;
                    N_Bitacora.Agregar(bita);
                }
                catch
                {
                    cError error = new cError();
                    error.iIdUsuario = E_Usuario.id;
                    error.iTipo=2;
                    error.sAccion="Orden "+txtreferencia.Text+" "+txtOrden.Text;
                    //error.iAplicacion = ;
                    cErrorN neg = new cErrorN();
                    neg.insert(error);
                }

            }
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            txtreferencia.Text = cmbProducto.Text;
            txtcodreceta.Text = Convert.ToString( cmbProducto.SelectedValue);
        }
    }
}
