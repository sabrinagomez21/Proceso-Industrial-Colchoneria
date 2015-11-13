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

/*---------------------------------------------------------------------------------------------------------------------------
    MODULULO: CUENTAS POR COBRAR
    APLICACION: COBRO DE FACTURAS
    ANALISTAS Y PROGRAMADORES: DYLAN CORADO
 ---------------------------------------------------------------------------------------------------------------------------*/

namespace Login
{
    public partial class MantenimientoTransaccion : Form
    {
        string sFormulario;
        int iIdAplicacion;
        int iIdModulo;
        int iIdUsuario;
        string sPrivilegio;
        string estado="";
        string sCod;
        public MantenimientoTransaccion()
        {
            InitializeComponent();
            funActualizarGrid();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;

        }

        private void MantenimientoTransaccion_Load(object sender, EventArgs e)
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

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("matipotransaccion", "SELECT ncodtipotransaccion as Codigo, vnombredocumento as Nombre ,vbincdec as Operacion, vestado as Estado  from matipotransaccion WHERE vestado = 'ACTIVO'", "consulta", grdTransaccion);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombreTr, true);
            cnegocio.funactivarDesactivarCombobox(cmbOperacionTr, true);
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNombreTr.Clear();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombreTr, false);
            cn.funactivarDesactivarCombobox(cmbOperacionTr, false);
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            btnanterior.Enabled = false;
            btnirPrimero.Enabled = false;
            btnsiguiente.Enabled = false;
            btnirUltimo.Enabled = false;
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            
            if(estado.Equals("editar")){
                txtOperacionTr.Text = cmbOperacionTr.SelectedItem.ToString();
                TextBox[] aDatosEdit = { txtOperacionTr, txtNombreTr };
                string sTabla = "matipotransaccion";
                string  sCodigo = "ncodtipotransaccion";
            
                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
               
                
            }
            else if (estado.Equals("eliminar"))
            {
                string sTabla = "matipotransaccion";
                string sCampoLlavePrimaria = "ncodtipotransaccion";
                string sCampoEstado = "vestado";
                System.Console.WriteLine("----"+sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {
                txtOperacionTr.Text = cmbOperacionTr.SelectedItem.ToString();
                TextBox[] aDatos = { txtOperacionTr, txtNombreTr, txtEstado };
                string sTabla = "matipotransaccion";
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                funActualizarGrid();
                txtNombreTr.Clear();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtNombreTr, false);
            cn.funactivarDesactivarCombobox(cmbOperacionTr, false);
            txtNombreTr.Clear();
            cmbOperacionTr.SelectedIndex = -1;
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
            funActualizarGrid();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombreTr, false);
            cn.funactivarDesactivarCombobox(cmbOperacionTr, false);
            txtBuscar.Visible = false;
            lblBuscar.Visible = false;
            lblOperacion.Visible = true;
            lblNombreTransaccion.Visible = true;
            txtNombreTr.Visible = true;
            cmbOperacionTr.Visible = true;
            txtNombreTr.Clear();
            txtBuscar.Clear();
            cmbOperacionTr.SelectedIndex = -1;


            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funPrimero(grdTransaccion);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funSiguiente(grdTransaccion);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funSiguiente(grdTransaccion);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funUltimo(grdTransaccion);
        }

        private void grdTransaccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtNombreTr, true);
                cn.funactivarDesactivarCombobox(cmbOperacionTr, true);
                sCod = grdTransaccion.Rows[grdTransaccion.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNombreTr.Text = grdTransaccion.Rows[grdTransaccion.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string sCmb = grdTransaccion.Rows[grdTransaccion.CurrentCell.RowIndex].Cells[2].Value.ToString();
                if (sCmb.Equals("Incremento"))
                {
                    cmbOperacionTr.SelectedIndex = 0;
                }
                else if (sCmb.Equals("Decremento"))
                {
                    cmbOperacionTr.SelectedIndex = 1;
                }

            } if (estado.Equals("eliminar"))
            {
                sCod = grdTransaccion.Rows[grdTransaccion.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombreTr.Visible = false;
            lblNombreTransaccion.Visible = false;
            cmbOperacionTr.Visible=false;
            lblOperacion.Visible = false;
            txtBuscar.Visible = true;
            lblBuscar.Visible = true;
            
            btnguardar.Enabled = false;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("matipotransaccion", "SELECT ncodtipotransaccion as Codigo, vnombredocumento as Nombre ,vbincdec as Operacion, vestado as Estado  from matipotransaccion WHERE vestado = 'ACTIVO' AND vnombredocumento LIKE '" + txtBuscar.Text + "%'", "consulta", grdTransaccion);
             
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            sFormulario = "Cobros";
            iIdAplicacion = 1;
            iIdModulo = 1;
            iIdUsuario = 1;
            sPrivilegio = "Superusuario";
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(sFormulario, iIdAplicacion, iIdModulo, iIdUsuario, sPrivilegio);
        }

        
    }
}
