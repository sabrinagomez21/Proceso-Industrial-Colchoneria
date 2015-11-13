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
using prueba1;
//using login;

/*
 * Programador: Manuel Chuquiej
 * Carnet: 0901-12-9129
 * Descripcin: Busca Estados de Cuenta;
 * Asignado por: Josue Revolorio
 */

namespace Login
{
    public partial class frmEstadoCuenta : Form
    {
        string actualizador;
        string sFormulario;
        int iIdAplicacion;
        int iIdModulo;
        int iIdUsuario;
        string sPrivilegio;
        public frmEstadoCuenta()
        {
            InitializeComponent();
            rbHistorico.Select();
            
        }

        #region funcin para actualizar el grid
        private void funActualizarGrid()
        {
            actualizador = txtCuentaDebitar.Text;
            //-------USO DEL NAVEGADOR----------------------
            clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistros("maempleado", "SELECT vnombreempleado as nombre, vapellidoempleado as apellido from maempleado where ncodempleado LIKE '" + txtCuentaDebitar + "%' ", "consulta", grdEmpleador);
            cnegocio.funconsultarRegistros("macuenta","SELECT mabanco.vnombrebanco as Banco,macuenta.ncodcuenta as Cuenta,maempleado.vnombreempleado as Nombre,maempleado.vapellidoempleado as Apellido, trpagos.dfechapago as Fecha, trpagos.vdescripcion as Transaccion, trpagos.ncoddocumento as Documento from maempleado,trpagos,macuenta,mabanco WHERE macuenta.ncodcuenta=maempleado.nnumcuenta and macuenta.ncodcuenta=trpagos.ncodcuenta and macuenta.ncodbanco=mabanco.ncodbanco AND macuenta.ncodcuenta = '"+txtCuentaDebitar.Text+"'", "consulta", grdEstados);
            //-------USO DEL NAVEGADOR----------------------
        }

        private void funActualizarGridfecha()
        {

            string fecha = dtpFecha.Text;
            System.Console.WriteLine("fecha---" + fecha);
            char[] delimitador = { '/' };
            string[] cortafecha = fecha.Split(delimitador);

            string dia = cortafecha[0];
            string mes = cortafecha[1];
            string año = cortafecha[2];

            System.Console.WriteLine("fecha---" + dia + "-" + "-" + mes + "-" + año);

            //MessageBox.Show("cuenta por mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //actualizador = txtCuentaDebitar.Text;
            //-------USO DEL NAVEGADOR----------------------
            clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistros("maempleado", "SELECT vnombreempleado as nombre, vapellidoempleado as apellido from maempleado where ncodempleado LIKE '" + txtCuentaDebitar + "%' ", "consulta", grdEstados);
            cnegocio.funconsultarRegistros("macuenta", "SELECT mabanco.vnombrebanco as Banco,macuenta.ncodcuenta as Cuenta,maempleado.vnombreempleado as Nombre,maempleado.vapellidoempleado as Apellido, trpagos.dfechapago as Fecha, trpagos.vdescripcion as Transaccion, trpagos.ncoddocumento as Documento from maempleado,trpagos,macuenta,mabanco WHERE macuenta.ncodcuenta=maempleado.nnumcuenta and macuenta.ncodcuenta=trpagos.ncodcuenta and macuenta.ncodbanco=mabanco.ncodbanco AND macuenta.ncodcuenta = '" + txtCuentaDebitar.Text + "' AND Year(trpagos.dfechapago)='" + año + "' AND month(trpagos.dfechapago)='" + mes + "'", "consulta", grdEstados);
            //-------USO DEL NAVEGADOR----------------------
            funActualizarGridfecha();
        
        }
        #endregion

        #region boton imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*sFormulario = "Cobros";
            iIdAplicacion = 1;
            iIdModulo = 1;
            iIdUsuario = 1;
            sPrivilegio = "Superusuario";
            prueba1.Frm_Reporte form = new prueba1.Frm_Reporte(sFormulario, iIdAplicacion, iIdModulo, iIdUsuario, sPrivilegio);
            form.Show();*/
            
            
        }
        #endregion


        #region funcion que se utiliza cuando se presiona el boton buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grdEstados.Columns.Clear();
            if(txtCuentaDebitar.Text.Equals("")){
                 MessageBox.Show("El campo cuenta es requerido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 txtCuentaDebitar.Select();

        }else if (rbHistorico.Checked == true)
            {
                actualizador = txtCuentaDebitar.Text;
                //-------USO DEL NAVEGADOR----------------------
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("maempleado", "SELECT mabanco.vnombrebanco AS Banco, trdocumentos.dfecha as Fecha,trdocumentos.dmonto as Cantidad,matipotransaccion.vnombredocumento as TipoDoc from mabanco,macuenta,trdocumentos,matipotransaccion WHERE macuenta.ncodbanco=mabanco.ncodbanco and macuenta.ncodcuenta=trdocumentos.ncodcuenta AND trdocumentos.ncodtipotransaccion=matipotransaccion.ncodtipotransaccion AND macuenta.ncodcuenta= '"+txtCuentaDebitar.Text+"' ", "consulta", grdEstados);
                //cnegocio.funconsultarRegistros("macuenta", "SELECT mabanco.vnombrebanco, maempleadobanco.cnombre AS Pago_A, trdocumentos.ncoddocumento as NoDocumento,trdocumentos.dfecha as Fecha, trdocumentos.dmonto as Total,matipotransaccion.vnombredocumento as Documento,matipotransaccion.vbincdec as Descripcion FROM maempleadobanco,mabanco,trpagoempleado,trdocumentos,matipotransaccion,macuenta WHERE trpagoempleado.ncodempleado=maempleadobanco.nnocuenta AND macuenta.ncodbanco=mabanco.ncodbanco and trdocumentos.ncoddocumento=trpagoempleado.ncoddocumento and trdocumentos.ncodtipotransaccion=matipotransaccion.ncodtipotransaccion and macuenta.nnocuenta='"+txtCuentaDebitar.Text+"'", "consulta", grdEstados);
                //-------USO DEL NAVEGADOR----------------------
                //funActualizarGrid();
            }
            else if (rbMensual.Checked==true)
            {
                string fecha = dtpFecha.Text;
                System.Console.WriteLine("fecha---" + fecha);
                char[] delimitador = { '/' };
                string[] cortafecha = fecha.Split(delimitador);

                string dia = cortafecha[0];
                string mes = cortafecha[1];
                string año = cortafecha[2];

                System.Console.WriteLine("fecha---" + dia + "-" + "-" + mes + "-" + año);

                //MessageBox.Show("cuenta por mes", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //actualizador = txtCuentaDebitar.Text;
                //-------USO DEL NAVEGADOR----------------------
                clasnegocio cnegocio = new clasnegocio();
                //cnegocio.funconsultarRegistros("maempleado", "SELECT vnombreempleado as nombre, vapellidoempleado as apellido from maempleado where ncodempleado LIKE '" + txtCuentaDebitar + "%' ", "consulta", grdEstados);
                cnegocio.funconsultarRegistros("macuenta", "SELECT mabanco.vnombrebanco AS Banco, trdocumentos.dfecha,trdocumentos.dmonto,matipotransaccion.vnombredocumento from mabanco,macuenta,trdocumentos,matipotransaccion WHERE macuenta.ncodbanco=mabanco.ncodbanco and macuenta.ncodcuenta=trdocumentos.ncodcuenta AND trdocumentos.ncodtipotransaccion=matipotransaccion.ncodtipotransaccion AND macuenta.ncodcuenta= '"+txtCuentaDebitar.Text+"' and Year(trdocumentos.dfecha)='" + año + "' and month(trdocumentos.dfecha)='" + mes + "'", "consulta", grdEstados);
                //-------USO DEL NAVEGADOR----------------------
            }
        }
        #endregion

        #region funcion del load para seguridad
        private void frmEstadoCuenta_Load(object sender, EventArgs e)
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


        #region uso navegador flechas
        private void btnirPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdEstados);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdEstados);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdEstados);
        }

        private void btnirUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdEstados);
        }

        #endregion






        //-----------------------funcion para implementar con seguridad----------------------
       


    }
}
