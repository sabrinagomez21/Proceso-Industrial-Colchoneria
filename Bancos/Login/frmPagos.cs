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
using ConexionODBC;
using System.Data.Odbc;

/*
 * Programador: Manuel Alejandro Chuquiej Buch
 * Carnet: 0901-12-9129
 * Modulo: pago de Empleados
 * Asignado por: Josue Daniel Revolorio Menendez
 */ 

namespace Login
{
    public partial class frmPagos : Form
    {
        #region Declaracion de Variables

        string retornosueldo,tipodcocumento,retornocodigo,retornosaldo,transa; //varibles para tomar textos de los TextBox
        string numero,numero2; // variables para rellenar los grids
        // comando para ejecucion de query
        private static OdbcCommand mySqlComando;
        //comando para el adaptador

        #endregion

        public frmPagos()
        {
            InitializeComponent();
            txtCuentaDebitar.Select();
            BloqueoBotones();
            llenarcombobox();

        }

        #region navegacion entre componentes y validaciones

        public void BloqueoBotones(){
            btnanterior.Enabled = false;
            btnirPrimero.Enabled = false;
            btnirUltimo.Enabled = false;
            btnsiguiente.Enabled = false;
            btnrefrescar.Enabled = false;
            btneditar.Enabled = false;
            btnimprimir.Enabled = false;
            btneliminar.Enabled = false;
            btnbuscar.Enabled = false;
    
        }
       public void LimpiarTexBox() {
           txtCuentaEmpleado.Text = "";
           txtCuentaDebitar.Text = "";
           txtTotalPago.Text = "";
       
       }

       public void restablecer() {
           lblCuenta.Visible = true;
           txtCuentaDebitar.Visible = true;
           lblCuentaEmpleador.Visible = true;
           txtCuentaDebitar.Visible = true;
           lblCuentaEmpleador.Visible = true;
           txtCuentaEmpleado.Visible = true;
           lblTotalPago.Visible = true;
           txtTotalPago.Visible = true;
           lblTotalPago.Text = "Total Pago";
           txtCuentaDebitar.Select();
           rbCheque.Checked = false;
           LimpiarTexBox();
       }
        //------cambia el foco decendiendo entre componentes-------
        private void txtCuentaDebitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13))
            {
                MessageBox.Show("Solo se permiten numeros y punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }else  if (e.KeyChar == 13)
            {
                rbCheque.Select();
                e.Handled = true;
            }
        }


        private void rbCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmbTipoTransaccion.Select();
                //cmbTipoTransaccion.DroppedDown = true;
                e.Handled = true;
            }
        }

        private void cmbTipoTransaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 68) {
                cmbTipoTransaccion.DroppedDown = true;
                e.Handled = true;

            }else if (e.KeyChar == 100)
            {
                //cmbTipoTransaccion.Select();
                cmbTipoTransaccion.DroppedDown = true;
                e.Handled = true;
            } else if (e.KeyChar == 13 ) {
                txtCuentaEmpleado.Select();
                e.Handled = true;
            
            }
        }

        private void txtCuentaEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
                    //---------------------
                    if (rbCheque.Checked == true)
                    {
                        if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13))
                        {
                            MessageBox.Show("Solo se permiten numeros y punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            e.Handled = true;
                            return;
                        } if (e.KeyChar == 13)
                        {
                            txtTotalPago.Select();
                            e.Handled = true;
                        }
                    }
                    
        }

        
        private void txtTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar.ToString() != ".") && !(e.KeyChar == 13))
            {
                MessageBox.Show("Solo se permiten numeros y punto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == 13)
            {

                btnguardar.Focus();
                e.Handled = true;
            }
        }



        private void rbCheque_Click(object sender, EventArgs e)
        {
                lblTotalPago.Visible = true;
                lblTotalPago.Text = "Total Pago";
                txtTotalPago.Visible = true;
                txtCuentaDebitar.Visible = true;
                lblCuentaEmpleador.Visible = true;
        }


        private void btnGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            funPrincipal();
        }

        private void btnNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            restablecer();
            
        }
        private void btnCancelar_KeyPress(object sender, KeyPressEventArgs e)
        {
            restablecer();
        }
        #endregion 

        #region funciones para actualizar el grids
        private void funActualizarGrid()
        {
                numero = txtCuentaDebitar.Text;
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("mabanco", "SELECT mabanco.vnombrebanco as Banco from mabanco,macuenta WHERE mabanco.ncodbanco=macuenta.ncodbanco and macuenta.ncodcuenta='" + txtCuentaDebitar + "' ", "consulta", grdEmpleador);
                
        }

        private void funActualizarGridEmpleado()
        {
            numero2 = txtCuentaEmpleado.Text;
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maempleado", "SELECT vdpi AS DPI, vnombreempleado AS NOMBRE, vapellidoempleado AS APELLIDO, vcargo AS PUESTO FROM maempleado WHERE nnumcuenta = '" + numero2 + "' ", "consulta", grdEmpleado);

        }
        #endregion

        #region Implementacion de funciones

        public string CodigoTransaccion(string codigo ){
            mySqlComando = new OdbcCommand(
               string.Format("SELECT ncodtipotransaccion FROM matipotransaccion WHERE vnombredocumento='"+codigo+"'"),
               ConexionODBC.Conexion.ObtenerConexion()
               );

            OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader(); //ejecucion query

            if (mySqlDLector.Read()) //lector, el cual obtiene registros
            {
                retornocodigo = mySqlDLector.GetString(0);
            }

            return retornocodigo;
        }
        public void llenarcombobox() {
            mySqlComando = new OdbcCommand(
               string.Format("SELECT vnombredocumento from matipotransaccion"),
               ConexionODBC.Conexion.ObtenerConexion()
               );

            OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader(); //ejecucion query

            while (mySqlDLector.Read()) //lector, el cual obtiene registros
            {
                tipodcocumento = mySqlDLector.GetString(0);
                //System.Console.WriteLine("resultadooooooo" + retornoctapago);
                cmbTipoTransaccion.Items.Add(tipodcocumento);

            }
        }

        #region Funcion Principal
        private void funPrincipal() {
            //MessageBox.Show("Presiono Guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (rbCheque.Checked == false)
            {
                MessageBox.Show("Elija un Tipo de Pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //txtCuentaDebitar.Select();
                txtCuentaDebitar.Visible = true;
                lblCuentaEmpleador.Visible = true;
                txtCuentaDebitar.Select();
            }
            else
            {
                //------------if cuando sueldo este activo----------------------
               
                    //-------------if cuando cheque este activo----------------------
                
                if (rbCheque.Checked == true)
                {

                    if (txtCuentaDebitar.Text.Equals("") || txtCuentaEmpleado.Text.Equals("") || txtTotalPago.Text.Equals(""))
                    {
                        MessageBox.Show("Todos los campos son requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCuentaDebitar.Select();
                    }
                    else
                    {
                        //--------llamado de funcion para que page al empleado con CHEQUE--------------------
                        MessageBox.Show("pago con cheque", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //-------------------------purueba---------------
                        string cuentaBanco=txtCuentaDebitar.Text;
                        string pagoSueldo=txtTotalPago.Text;
                       
                        TraerSaldoBanco(cuentaBanco);
                        actualizarcuentabanco(retornosaldo, cuentaBanco);
                        


                        
                        //------------------------------------------------------------------------
                        LimpiarTexBox();
                        btnnuevo.Select();
                    }

                }

            }
        
        }
        #endregion

        #region Funciones para consultas
        public void actualizarcuentabanco(string saldo,string cuentaempresa) {
            float convsaldo = float.Parse(saldo);
            float convsalod = float.Parse(txtTotalPago.Text);
            Object selectedItem = cmbTipoTransaccion.SelectedItem;
            string tomacombo=Convert.ToString(selectedItem);
            string pagoempleado=txtCuentaEmpleado.Text;

            trercodtansaccion(tomacombo);


            if(tomacombo.Equals("")){ 
                MessageBox.Show("Seleccione un Valor en el combo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTipoTransaccion.Select();
            }else if (convsalod>convsaldo){
                MessageBox.Show("La cuenta no posee fondos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else if(MessageBox.Show("¿Desea Realizar el Pago?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

            float resta = convsaldo - convsalod;
             try {
                mySqlComando = new OdbcCommand(
                  string.Format("UPDATE macuenta SET nsaldo='"+resta+"' WHERE ncodcuenta='"+cuentaempresa+"'"),
                 ConexionODBC.Conexion.ObtenerConexion()
              );
                mySqlComando.ExecuteNonQuery();
                  MessageBox.Show("El Pago se realizo con Exito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  DateTime fe = DateTime.Today;
                  String fecha = fe.Year + "-" + fe.Month + "-" + fe.Day;
                 //-----------------inserta en documento-----------------
                  DateTime date = DateTime.Today;
                  String formato = fe.Year + "-" + fe.Month + "-" + fe.Day;
                  String pago = txtTotalPago.Text;
                  string empleado = txtCuentaEmpleado.Text;
                  System.Console.WriteLine("el puto codigo de transaccion"+tomacombo);
                 
                  InsertaTrdocumentosPago(formato,pago,transa,cuentaempresa);
                  trpagoempleado(empleado);
                 //----------------------------------
            
            }catch{
                 MessageBox.Show("La cuenta no se actualizo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);         
            }
                     
        }
        }

        public void trpagoempleado(string codempleado) {
            mySqlComando = new OdbcCommand(
              string.Format("SELECT MAX(ncoddocumento) FROM trdocumentos"),
              ConexionODBC.Conexion.ObtenerConexion()
              );

            OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader(); //ejecucion query

            if (mySqlDLector.Read()) //lector, el cual obtiene registros
            {
                string maximoid = mySqlDLector.GetString(0);
                mySqlComando = new OdbcCommand(
                  string.Format("INSERT INTO trpagoempleado (ncodempleado,ncoddocumento) VALUES ('" + codempleado + "','" + maximoid + "')"),
                 ConexionODBC.Conexion.ObtenerConexion()
              );
                mySqlComando.ExecuteNonQuery();

            }
               

        }

        public string TraerSaldoBanco(string nocuenta) {
              mySqlComando = new OdbcCommand(
              string.Format("SELECT nsaldo FROM macuenta WHERE ncodcuenta='"+nocuenta+"'"),
              ConexionODBC.Conexion.ObtenerConexion()
              );

            OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader(); //ejecucion query

            if (mySqlDLector.Read()) //lector, el cual obtiene registros
            {
                retornosaldo = mySqlDLector.GetString(0);
                //System.Console.WriteLine("resultado debito   " + retorctadebito);

            }
            return retornosaldo;
        }
        public string trercodtansaccion(string nomdoc)
        {
            mySqlComando = new OdbcCommand(
            string.Format("SELECT ncodtipotransaccion from matipotransaccion WHERE vnombredocumento='"+nomdoc+"'"),
            ConexionODBC.Conexion.ObtenerConexion()
            );

            OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader(); //ejecucion query

            if (mySqlDLector.Read()) //lector, el cual obtiene registros
            {
                transa = mySqlDLector.GetString(0);
                //System.Console.WriteLine("resultado debito   " + retorctadebito);

            }
            return transa;
        }
        public void InsertaTrdocumentosPago(string dfecha,string nmonto,string transaccion, string cuenta) {
            try {
                mySqlComando = new OdbcCommand(
                  string.Format("INSERT INTO trdocumentos (dfecha,dmonto,ncodtipotransaccion,ncodcuenta) VALUES ('" + dfecha + "','" + nmonto + "','" + transaccion + "','"+cuenta+"')"),
                 ConexionODBC.Conexion.ObtenerConexion()
              );
                mySqlComando.ExecuteNonQuery();

            }catch{
                 MessageBox.Show("La transaccion no fue Guardada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);         
            }   
        }

       


        public string TraerSalario(String salario){
            mySqlComando = new OdbcCommand(
              string.Format("SELECT nsalario FROM maempleadobanco WHERE nnocuenta='" + salario + "'"),
              ConexionODBC.Conexion.ObtenerConexion()
              );

            OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader(); //ejecucion query

            if (mySqlDLector.Read()) //lector, el cual obtiene registros
            {
                retornosueldo = mySqlDLector.GetString(0);
                //System.Console.WriteLine("resultado sueldo cuenta2   " + retornosueldo);

            }
            lblTotalPago.Text = "Sueldo Empleado: Q." + retornosueldo;
            lblTotalPago.Visible = true;
            return retornosueldo;
        }


        #endregion

        #endregion

        #region funciones de autollenado de grids
        //------------funcion que permite rellenar el grid con informacion del que pagara al empleado-------- 
        private void txtCuentaDebitar_KeyUp(object sender, KeyEventArgs e)
        {
                //-------USO DEL NAVEGADOR----------------------
                clasnegocio cnegocio = new clasnegocio();
                //cnegocio.funconsultarRegistros("maempleado", "SELECT vnombreempleado as nombre, vapellidoempleado as apellido from maempleado where ncodempleado LIKE '" + txtCuentaDebitar + "%' ", "consulta", grdEmpleador);
                cnegocio.funconsultarRegistros("mabanco", "SELECT mabanco.vnombrebanco as Banco from mabanco,macuenta WHERE mabanco.ncodbanco=macuenta.ncodbanco and macuenta.ncodcuenta='"+txtCuentaDebitar.Text+"'", "consulta", grdEmpleador);
                //-------USO DEL NAVEGADOR----------------------
                //funActualizarGrid();
            
        }

        private void txtCuentaEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistros("maempleado", "SELECT vnombreempleado as nombre, vapellidoempleado as apellido from maempleado where ncodempleado LIKE '" + txtCuentaDebitar + "%' ", "consulta", grdEmpleador);
            cnegocio.funconsultarRegistros("maempleadobanco", "SELECT cnombre from maempleadobanco WHERE nnocuenta='"+txtCuentaEmpleado.Text+"'", "consulta", grdEmpleado);
            //-------USO DEL NAVEGADOR----------------------
            string consultasaldo = txtCuentaEmpleado.Text;
            TraerSalario(consultasaldo);
            //lblSueldo.Text = retornosueldo;
            //funActualizarGridEmpleado();
            
        }
       
        #endregion

        #region Funcion cuando Pulse click en boton
        //------------funcion que permite hacer el pago cuando se haga click en el boton-------- 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            funPrincipal();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            restablecer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restablecer();
        }
        //-----------------------------------------

        #endregion

        #region Funcion para el modulo de seguridad

        private void frmPagos_Load(object sender, EventArgs e)
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
        #endregion
    }
}
