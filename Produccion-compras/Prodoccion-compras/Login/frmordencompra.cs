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
using Graficador;
using prueba1;


namespace Login
{
    public partial class frmordencompra : Form
    {

        string nomformulario;
        int idapp;
        int idmod;
        int id;
            string privilegio;

        public frmordencompra()
        {
            InitializeComponent();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {

        }

        private void frmordecompra_Load(object sender, EventArgs e)
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


            Random numero = new Random();
            int a = numero.Next(100, 200);
           

            txtNoDocumento.Text = a.ToString();

            
            
            D_Aplicacion dt = new D_Aplicacion();
            dt.rellenarComboOrdenes(cmbordenes);


            try
            {
                // carga todas apps que se le pueden asignar al usuario

                cmbProveedor.DataSource = D_Aplicacion.buscarproveedor();
                cmbProveedor.DisplayMember = "vnombre"; // muestra los nombre de los roles
                // valuemember es el valor del list
                cmbProveedor.ValueMember = "ncodproveedor";  // cada rol obtiene su id


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }


        private void contador()
        {
            OdbcCommand mySqlComando = new OdbcCommand(
                string.Format("SELECT COUNT(ncodcompra) FROM contador"),
                ConexionODBC.Conexion.ObtenerConexion()
                );

            int contar = Convert.ToInt32(mySqlComando.ExecuteScalar());
            
            int resultado;
            resultado = contar - 1;

            String sql = "select ncodcompra from contador ";
            OdbcCommand COMAND = new OdbcCommand(sql, ConexionODBC.Conexion.ObtenerConexion());
            DataTable tabla = new DataTable();
            OdbcDataAdapter adaptadortabla = new OdbcDataAdapter(sql, ConexionODBC.Conexion.ObtenerConexion());
            adaptadortabla.Fill(tabla);

            string ID_PACIENTE = tabla.Rows[resultado]["ncodcompra"].ToString();

            int number = Convert.ToInt32(ID_PACIENTE) + 1;
            ID_PACIENTE = number.ToString();
            txtNoDocumento.Text = ID_PACIENTE;



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcCommand busqueda = new OdbcCommand(
                               string.Format("SELECT * FROM maordencompra WHERE ncodordencompra = '" + cmbordenes.Text + "'"),
                             ConexionODBC.Conexion.ObtenerConexion()
                           );

            OdbcDataReader _reader = busqueda.ExecuteReader();


            if (_reader.Read() == true)
            {
                this.txtCantidad.Text = _reader["ncantidad"].ToString();
                this.txtarticulo.Text = _reader["ncodarticulo"].ToString();
                this.txtstatusactual.Text = _reader["vstatusorden"].ToString();
                this.txtDescripcion.Text = _reader["vdescripcioncompra"].ToString();
                this.txtPrecio.Text = _reader["ncostototal"].ToString();
            
            }
            else
            {
                this.txtCantidad.Text = "";
                this.txtarticulo.Text = "";
                this.txtstatusactual.Text = "";
                this.txtDescripcion.Text = string.Empty;
                this.txtPrecio.Text = "";
                this.txtSaldoPagar.ResetText();


            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //insercion por medio de navegador
            txtfecha.Text = dtpFecha.Text;
            txtorden.Text = cmbordenes.Text;
            txtproveedor.Text = cmbProveedor.SelectedValue.ToString();
            txtcondicionpago.Text = cmbCondicionPago.Text;
            txtstatusnuevo.Text = cmbstatusnuevo.Text;

            E_EditOrden pEdit = new E_EditOrden(); // intancia a la capa de 
            pEdit.Id_orden = Convert.ToInt16(cmbordenes.Text); // asignacion de varible id_rol al textbox
            pEdit.Id_Proveedor = Convert.ToInt16(cmbProveedor.SelectedValue); // asignacion de variable nombre rol al textobx
            pEdit.descripcionCompra = txtDescripcion.Text;
            pEdit.cantidad = Convert.ToInt32(txtCantidad.Text);
            pEdit.costototal = Convert.ToInt32(txtPrecio.Text);
            pEdit.id_articulo = Convert.ToInt32(txtarticulo.Text);
            pEdit.status = cmbstatusnuevo.Text;

            E_Compra pCompra = new E_Compra();
            pCompra.nodocumento = Convert.ToInt32(txtNoDocumento.Text);
            pCompra.descripcionC = txtDescripcion.Text;
            pCompra.cantidad = Convert.ToInt32(txtCantidad.Text);
            pCompra.costototal = Convert.ToInt32(txtTotalPagar.Text);
          
            string fecha;
            fecha = dtpFecha.Value.Year + "/" + dtpFecha.Value.Month + "/" + dtpFecha.Value.Day;
            pCompra.fecha = fecha;
            new N_Compra().Insert_Compra(pCompra);



            new N_EditOrden().Update_Orden(pEdit);
            
            
            
            txtfecha.Text = dtpFecha.Text;
            txtorden.Text = cmbordenes.Text;
            txtproveedor.Text = cmbProveedor.Text;
            txtcondicionpago.Text = cmbCondicionPago.Text;
            txtstatusnuevo.Text = cmbstatusnuevo.Text;


            TextBox[] datos = { txtarticulo , txtproveedor,txtCantidad, txtTotalPagar,txtSaldoPagar,txtSaldoPendiente,txtNoDocumento,txtcondicionpago };
            string tabla = "trcompra";
            Boolean permiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(tabla, permiso, datos);
            MessageBox.Show("Se insertaron correctamente Todos los Datos");

            txtDescripcion.Text = "";
            txtarticulo.Text = "";
            txtCantidad.Text = "";
            txtproveedor.Text = "";
            txtcondicionpago.Text = "";
            txtSaldoPendiente.Text = "";

            txtTotalPagar.Text = "";
            txtorden.Text = "";
            txtPrecio.Text = "";
            txtstatusactual.Text = "";
            txtstatusnuevo.Text = "";
            txtSaldoPagar.ResetText();



        }

       
        private void txtNoDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graficador.Form1 graficador = new Graficador.Form1();
            graficador.Show();
        }

        private void txtSaldoPagar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int pagar = Convert.ToInt32(txtTotalPagar.Text);
                int saldo = Convert.ToInt32(txtSaldoPagar.Text);
                string saldoo = Convert.ToString(pagar - saldo);
                txtSaldoPendiente.Text = saldoo;
            }
            catch { }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            nomformulario = "ORDENES DE COMPRA";
            idapp = 1;
            idmod = 1;
            id = 1;
            privilegio = "Superusuario";
            prueba1.Frm_Reporte formcarga = new prueba1.Frm_Reporte(nomformulario, idapp, idmod, id, privilegio);
            formcarga.Show();


        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            Random numero = new Random();
            int a = numero.Next(100, 200);


            txtNoDocumento.Text = a.ToString();
        }

    
    
    }
}