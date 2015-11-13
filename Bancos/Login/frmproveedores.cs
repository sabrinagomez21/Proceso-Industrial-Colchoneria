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
    public partial class frmproveedores : Form
    {
        public frmproveedores()
        {
            InitializeComponent();
        }

        private void frmproveedores_Load(object sender, EventArgs e)
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
            ActualizarForm();

            nuevo.funactivarDesactivarBoton(btnguardar, false);

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            TextBox[] datos = { txtDescripcion, txtTelefono, txtCiudad, txtNombreProveedor, txtDireccion, txtNit, txtsaldo };
            string tabla = "maproveedor";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            
            txtDescripcion.Text = "";
            txtTelefono.Text = "";
            txtCiudad.Text = "";
            txtNombreProveedor.Text = "";
            txtDireccion.Text = "";
            txtNit.Text = "";
            txtsaldo.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCiudad, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtNit, true);
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtsaldo, true);
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmbuscarProveedor busc = new frmbuscarProveedor();
            busc.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCiudad, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtNit, false);
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtsaldo, false);

            txtCiudad.Text = "";
            txtCodigoProveedor.Text = "";
            txtDescripcion.Text = "";
            txtNit.Text = "";
            txtNombreProveedor.Text = "";
            txtsaldo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void ActualizarForm()
        {
            try
            {
                dgProveedores.DataSource = new N_Aplicacion().GetAll(); // tiene todos los registro del datatable
                dgProveedores.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {

            ActualizarForm();
            //dgProveedores.DataSource = null;
            dgProveedores.Refresh();

            txtCiudad.Text = "";
            txtCodigoProveedor.Text = "";
            txtDescripcion.Text = "";
            txtNit.Text = ""; 
            txtNombreProveedor.Text = "";
            txtsaldo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }




        private void BuscarRegistro(int Llave)
        {
            E_Aplicacion pCliente = new N_Aplicacion().GetSingle_Cliente(Llave); // busca los atributos de la llave y los obtiene para cada registro 
            txtCodigoProveedor.Text = Convert.ToString(pCliente.Idproveedor);
            txtNombreProveedor.Text = pCliente.nombreproveedor;
            txtDireccion.Text = pCliente.direccionproveedor;
            txtNit.Text = pCliente.nitproveedor;
            txtsaldo.Text = Convert.ToString(pCliente.saldoproveedor);
            txtTelefono.Text = pCliente.telefonoproveedor;
            txtDescripcion.Text = pCliente.descripcionproveedor;
            txtCiudad.Text = pCliente.ciudadproveedor;
        }


        private void dgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }

            DataGridViewRow row = dgProveedores.Rows[e.RowIndex];

            int valor = (int)row.Cells[0].Value;
            BuscarRegistro(valor);


            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCiudad, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcion, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtNit, true);
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtsaldo, true);

            cnegocio.funactivarDesactivarBoton(btnguardar, false);


        }        
        private void tmrActualizar_Tick(object sender, EventArgs e)
        {
            ActualizarForm();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { txtDescripcion, txtTelefono, txtCiudad, txtNombreProveedor, txtDireccion, txtNit, txtsaldo };

            clasnegocio cn = new clasnegocio();
            string tabla = "maproveedor";
            Boolean permiso = true;
            string codigo = Convert.ToString(txtCodigoProveedor.Text);
            cn.EditarObjetos("maproveedor", permiso, arraytexto, codigo, "ncodproveedor");
           
            txtCiudad.Text = "";
            txtCodigoProveedor.Text = "";
            txtDescripcion.Text = "";
            txtNit.Text = "";
            txtNombreProveedor.Text = "";
            txtsaldo.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        
        {
            string id = " ";
            int valor = 0;

            eliminacion(valor);
            id = Convert.ToString(valor);
            
            //clasnegocio cnegocio = new clasnegocio();
            //string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            //tabla = "maproveedor";
            //codEliminar = Convert.ToString(txtCodigoProveedor.Text);
            //campoLlavePrimaria = "ncodproveedor";
            //campoEstado = "Estado";
            //cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria,campoEstado);
        }


        private static int eliminacion(int pvariable)
        {
            int idusuario = 0;
            
            try
            {
                //si se desea eliminar el registro que ha sido buscado se ejecutara el query que tenemos a continuacion.
                OdbcCommand comando = new OdbcCommand(string.Format("Delete From maproveedor where ncodproveedor ={0}", pvariable),
                    ConexionODBC.Conexion.ObtenerConexion());
                
                idusuario = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Eliminar el Registro", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return idusuario;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }


    }
}
