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
using System.Data.Odbc;


namespace Login
{
    public partial class frmgeneraCompra : Form
    {
        public frmgeneraCompra()
        {
            InitializeComponent();
        }

        private void frmgeneraCompra_Load(object sender, EventArgs e)
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

            D_Aplicacion dt = new D_Aplicacion();
            dt.rellenarComboOrdenes(cmbidProveedor);
           
        }

       

        private void cmbidProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcCommand busqueda = new OdbcCommand(
                                string.Format("SELECT * FROM maordencompra WHERE ncodordencompra = '"+cmbidProveedor.Text+"'"),
                              ConexionODBC.Conexion.ObtenerConexion()
                            );

            OdbcDataReader _reader = busqueda.ExecuteReader();


            if (_reader.Read()== true)
            {
                this.txtCantidadProducto.Text = _reader["ncantidad"].ToString();
                this.txtCodigoArticulo.Text = _reader["ncodarticulo"].ToString();
                this.txtEstatusOrden.Text = _reader["vstatusorden"].ToString();
                this.txtDescripcion.Text = _reader["vdescripcioncompra"].ToString();
            }
            else
            {
                this.txtCantidadProducto.Text = "";
                 this.txtCodigoArticulo.Text = "";
                this.txtEstatusOrden.Text = "";
                this.txtDescripcion.Text = string.Empty;

            }
        }
    }
}
