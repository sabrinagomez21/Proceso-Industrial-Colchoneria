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
    ANALISTAS Y PROGRAMADORES: JOSUE REVOLORIO, DYLAN CORADO
 ---------------------------------------------------------------------------------------------------------------------------*/

namespace Login
{
    public partial class frmPrincipalCxC : Form
    {
        //Variables utilizadas para el manejo del reporteador
        string sFormulario;
        int iIdAplicacion;
        int iIdModulo;
        int iIdUsuario;
        string sPrivilegio;


        public frmPrincipalCxC()
        {
            InitializeComponent();

        }

        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: LOAD
            Ejecuta los procesos de la actualizacion del grid y de combobox alimentandolos directamente de la BD, ademas se encarga
            de aplicar los permisos de acceso otorgados por seguridad al navegador. 
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void frmPrincipalCxC_Load(object sender, EventArgs e)
        {
            //Actualizacion de grid y combobox
            funActualizarGrid();
            funActualizarCombo();
            funAgregarColumnas();
            //Aplicacion de permisos
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
            txtDocto.Enabled = txtCliente.Enabled = txtValor.Enabled = dtpFecha.Enabled = cmbTransaccion.Enabled = false;
            nuevo.funactivarDesactivarBoton(btneditar, false);
            nuevo.funactivarDesactivarBoton(btneliminar, false);

        }

        
        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: CANCELAR
            Deshabilita los textbox y el dateTimePiker ademas de ejecutar la funcion de Limpiar Textos
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funCancelar()
        {
            funLimpiarText();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCliente, false);
            cnegocio.funactivarDesactivarTextbox(txtDocto, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, false);
            cnegocio.funactivarDesactivarBoton(btnguardar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, true);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, true);
            cnegocio.funactivarDesactivarTextbox(txtValor, false);
            cnegocio.funactivarDesactivarBoton(btnbuscar, true);
            cnegocio.funactivarDesactivarBoton(btnimprimir, true);
            cnegocio.funactivarDesactivarCombobox(cmbTransaccion, false);
            cnegocio.funactivarDesactivarCombobox(cmbBanco, false);
            dtpFecha.Enabled = false;
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: DESBLOQUEO Y BLOQUEO DE BOTONES
            Deshabilita o habilita botones del navegador segun sea lo que corresponda
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funDesbloqueo()
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarBoton(btnguardar, false);
            cn.funactivarDesactivarBoton(btncancelar, false);
            cn.funactivarDesactivarBoton(btneliminar, true);
            cn.funactivarDesactivarBoton(btnrefrescar, true);
            cn.funactivarDesactivarBoton(btneditar, true);
            cn.funactivarDesactivarBoton(btnnuevo, true);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: HABILITACION DE TEXTBOX
            Habilita los textbox y el dateTimePiker 
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funHabilitarText()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtCliente, true);
            cnegocio.funactivarDesactivarTextbox(txtDocto, true);
            cnegocio.funactivarDesactivarTextbox(txtValor, true);
            cnegocio.funactivarDesactivarCombobox(cmbTransaccion, true);
            dtpFecha.Enabled = true;
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: LIMPIAR TEXTOS
            Limpia los textbox
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funLimpiarText()
        {
            txtCliente.Text = txtDocto.Text = "";
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: AGREGADO DE COLUMNAS
            Agrega dos columnas mas al grid. La primera es una columna de cuadros de textos vacios que se utilizara para ingresar 
            montos a cobrar, y la segunda es una columna de checkbox que permite seleccionar las facturas a cobrar.
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funAgregarColumnas()
        {
            //Agregado de columna de textos
            grdDocumentos.Columns.Add("Cantidad", "Monto Cobrar");
            //Agregado de columna de checkbox
            DataGridViewCheckBoxColumn myCheckedColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Cobrar",
                FalseValue = 0,
                TrueValue = 1,
                Visible = true
            };
            grdDocumentos.Columns.Add(myCheckedColumn);
        }

        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: ACTUALIZAR EL GIRD
            Ingresa al grid todos los datos mas recientes de la tabla de facturas a cobrar (mafacturacobro) en la BD
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, nnofactura, dfecha, dfechaexpiracion, ncodcliente, ntotal from mafacturacobro WHERE cestado='ACTIVO' AND cpagado='NO'", "consulta", grdDocumentos);
            
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            FUNCION: ACTUALIZAR EL GIRD
            Ingresa a los combobox los datos mas recientes de transacciones y de cuentas bancarias respectivamente
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void funActualizarCombo()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodtipotransaccion", "SELECT ncodtipotransaccion,vnombredocumento from matipotransaccion WHERE vestado = 'ACTIVO'", "vnombredocumento", cmbTransaccion);
            cnegocio.funconsultarRegistrosCombo("ncodcuenta", "SELECT ncodcuenta,nnocuenta from macuenta WHERE cestado = 'ACTIVO'", "nnocuenta", cmbBanco);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: SOLTAR UNA TECLA DE TXTCLIENTE
            Se utiliza para filtrar informacion en el grid basado en el cliente
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try{
                if (!String.IsNullOrEmpty(txtCliente.Text)){
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT mafacturacobro.ncodfactura, mafacturacobro.dfecha, mafacturacobro.ntotal from mafacturacobro, maclientecobro WHERE mafacturacobro.cestado='ACTIVO' AND maclientecobro.ncodcliente LIKE '" + txtCliente.Text + "%' AND maclientecobro.ncodcliente = mafacturacobro.ncodcliente", "consulta", grdDocumentos);
                }else{
                    funActualizarGrid();
                }
            }catch{
                    MessageBox.Show("Se produjo un error filtrando clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: SOLTAR UNA TECLA DE TXTDOCTO
            Se utiliza para filtrar informacion en el grid basado en el numero de factura
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtDocto_KeyUp(object sender, KeyEventArgs e)
        {
            try
                {
                    if (!String.IsNullOrEmpty(txtDocto.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, dfecha, ntotal from mafacturacobro WHERE cestado='ACTIVO' AND nnofactura = '" + txtDocto.Text + "%'", "consulta", grdDocumentos);
                    }
                    else
                    {
                        funActualizarGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error filtrando documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: CAMBIO DE VALOR DEL DATETIMEPIKER FECHA
            Se utiliza para filtrar informacion en el grid basado en la fecha de la factura
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            funLimpiarText();
            try
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("mafacturacobro", "SELECT ncodfactura, dfecha, ntotal from mafacturacobro WHERE cestado='ACTIVO' AND dfecha = '" + dtpFecha.Text + "%'", "consulta", grdDocumentos);
            }
            catch
            {
                MessageBox.Show("Se produjo un error filtrando documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: CAMBIO DE VALOR DEL COMBOBOX DE TRANSACCION
            Se utiliza para filtrar informacion en el grid basado en el tipo de la transaccion
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void cmbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            funActualizarGrid();
            funLimpiarText();
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: REFRESCAR
            Ejecuta las funciones de actualizar grid y actualizar combo
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
            funActualizarCombo();
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: COBRO
            Recorre el grid y verifica que filas estan checkeadas si cumplen con las validaciones se cobraran las facturas seleccionadas
            y se actualizaran sus valores en la BD, ademas ingresa un Recibo de cobro en la tabla de Documento (madocto) en la BD e 
            ingresa un registro de todos los cobros asociando el recibo con la factura en la tabla de Coboros (trcobro) en la BD
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnPagoCobro_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                Double dTotalCobro = 0;
                for (int i = 0; i <= grdDocumentos.RowCount - 1; i++)
                {

                    if (Convert.ToBoolean(grdDocumentos.Rows[i].Cells["Cobrar"].Value))
                    {
                        if (Convert.ToDouble(grdDocumentos.Rows[i].Cells["Cantidad"].Value) <= Convert.ToDouble(grdDocumentos.Rows[i].Cells[7].Value))
                        {
                            dTotalCobro = dTotalCobro + Convert.ToDouble(grdDocumentos.Rows[i].Cells["Cantidad"].Value);
                        }
                        else
                        {
                            MessageBox.Show("El monto a cobrar exede el monto total de la deuda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            break;
                        }
                        if (dTotalCobro > 0)
                        {
                            if (dTotalCobro > Convert.ToDouble(txtValor.Text))
                            {
                                MessageBox.Show("El monto total de la deuda exede el monto recibido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                break;
                            }
                            else
                            {
                                if (Convert.ToDouble(grdDocumentos.Rows[i].Cells["Cantidad"].Value) == Convert.ToDouble(grdDocumentos.Rows[i].Cells[7].Value))
                                {
                                    txtTempCodFact.Text = grdDocumentos.Rows[i].Cells[2].Value + "";
                                    txtPagado.Text = "SI";
                                    

                                    System.Console.WriteLine(txtTempCodFact.Text + " " + txtTempNo.Text + " " + txtFecha.Text + " "+ txtExpira.Text +" "+ txtTempTotal.Text+" "+txtEstado.Text+" "+txtPagado.Text+" "+txtTempCliente.Text);
                                    TextBox[] aDatos = { txtPagado };
                                    string sTabla = "mafacturacobro";
                                    string sCodigo = "ncodfactura";
                                    Boolean bPermiso = true;
                                    clasnegocio cn = new clasnegocio();
                                    cn.EditarObjetos(sTabla, bPermiso, aDatos, txtTempCodFact.Text, sCodigo);
                                }
                                else if (Convert.ToDouble(grdDocumentos.Rows[i].Cells["Cantidad"].Value) < Convert.ToDouble(grdDocumentos.Rows[i].Cells[7].Value))
                                {
                                    txtTempCodFact.Text = grdDocumentos.Rows[i].Cells[2].Value + "";
                                    Double total = Convert.ToDouble(grdDocumentos.Rows[i].Cells[7].Value + "");
                                    Double pago = Convert.ToDouble(grdDocumentos.Rows[i].Cells[0].Value + "");
                                    
                                    Double resta = total - pago;
                                    txtTempTotal.Text = resta + "";

                                    System.Console.WriteLine(total+" "+pago+" "+resta);

                                    TextBox[] aDatos = { txtTempTotal };
                                    string sTabla = "mafacturacobro";
                                    string sCodigo = "ncodfactura";
                                    Boolean bPermiso = true;
                                    clasnegocio cn = new clasnegocio();
                                    cn.EditarObjetos(sTabla, bPermiso, aDatos, txtTempCodFact.Text, sCodigo);
                                    
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No hay monto a cobrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            break;
                        }
                    }
                }
                //funActualizarGrid();
                clasnegocio cnDoc = new clasnegocio();
                txtFecha.Text = dtpFecha.Text;
                txtTotalCobro.Text = dTotalCobro + "";
                cnDoc.funconsultarRegistrosCombo("ncodcuenta", "SELECT ncodcuenta from macuenta WHERE cestado = 'ACTIVO' AND nnocuenta = '"+cmbBanco.Text+"'", "nnocuenta", cmbCuenta);
                System.Console.WriteLine("Combo"+cmbBanco.Text);
                txtTemporalCuenta.Text = cmbBanco.Text;
                System.Console.WriteLine("Texto"+txtTemporalCuenta.Text);
                cnDoc.funconsultarRegistrosCombo("ncodtipotransaccion", "SELECT ncodtipotransaccion from matipotransaccion WHERE vestado = 'ACTIVO' AND vnombredocumento = 'Cobro'", "ncodtipotransaccion", cmbTrans);
                txtTransaccion.Text = cmbTrans.Text;
                TextBox[] aDatosDoc = { txtFecha, txtTotalCobro, txtTemporalCuenta, txtTransaccion};
                string sTablaDoc = "trdocumentos";
                Boolean bPermisoDoc = true;
                cnDoc.AsignarObjetos(sTablaDoc, bPermisoDoc, aDatosDoc);
                for (int x = 0; x <= grdDocumentos.RowCount - 1; x++)
                {
                    if (Convert.ToBoolean(grdDocumentos.Rows[x].Cells["Cobrar"].Value))
                    {
                        Double pago = Convert.ToDouble(grdDocumentos.Rows[x].Cells[0].Value + "");
                        Double total = Convert.ToDouble(grdDocumentos.Rows[x].Cells[7].Value + "");

                        Double resta = total - pago;
                        System.Console.WriteLine(x + " " + total + " " + pago + " " + resta);
                        txtPago.Text = pago + "";
                        txtSaldo.Text = resta + "";
                        txtFechaCobro.Text = dtpFecha.Text;
                        txtMora.Text = "0";
                        txtFacDoc.Text = grdDocumentos.Rows[x].Cells[2].Value + "";

                        cnDoc.funconsultarRegistrosCombo("ncoddocumento", "SELECT MAX(ncoddocumento) as codigo from trdocumentos", "codigo", cmbcodDocu);
                        System.Console.WriteLine(cmbcodDocu.Text);
                        txtDoc.Text = cmbcodDocu.Text;
                        TextBox[] aDatosCob = { txtPago, txtSaldo, txtFechaCobro, txtMora, txtDoc, txtFacDoc };
                        string sTablaCob = "trcobro";
                        Boolean bPermisoCob = true;
                        cnDoc.AsignarObjetos(sTablaCob, bPermisoCob, aDatosCob);
                    }
                }
                funActualizarGrid();
            }
            else
            {
                MessageBox.Show("El campo del valor esta vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: ENTRAR AL TEXTBOX
            si se entra al textbox de cliente se limpian los demas textbos ya que solo se pude filtrar con un parametro a la vez
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtCliente_Enter(object sender, EventArgs e)
        {
            funLimpiarText();
            funActualizarGrid();
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: ENTRAR AL TEXTBOX DE NO FACTURA
            si se entra al textbox de no factura se limpian los demas textbos ya que solo se pude filtrar con un parametro a la vez
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtDocto_Enter(object sender, EventArgs e)
        {
            funLimpiarText();
            funActualizarGrid();
        }

        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: PRECIONAR TEXTBOX DE CLIENTE
            si se entra al textbox de cliente se limpian los demas textbos ya que solo se pude filtrar con un parametro a la vez
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: PRECIONAR TEXTBOX DE NO FACTURA
            si se entra al textbox de no factura se limpian los demas textbos ya que solo se pude filtrar con un parametro a la vez
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            EVENTO: PRECIONAR TEXTBOX DE VALOR
            si se entra al textbox de cliente se limpian los demas textbos ya que solo se pude filtrar con un parametro a la vez
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: NUEVO
            habilita los cuadros de texto
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtValor, true);
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
            cnegocio.funactivarDesactivarBoton(btnbuscar, false);
            cnegocio.funactivarDesactivarBoton(btnimprimir, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarCombobox(cmbBanco, true);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: EDITAR
            habilita los cuadros de texto y coloca una bandera en modo edicion
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btneditar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: ELIMINAR
            habilita los cuadros de texto y coloca una bandera en modo eliminacion
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btneliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarBoton(btnguardar, true);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: GUARDAR
            no tiene funcionabilidad en este form
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: CANCELAR
            ejecuta la funcion cancelar y funactualizar
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btncancelar_Click(object sender, EventArgs e)
        {
            funCancelar();
            funActualizarGrid();
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: BUSCAR
            habilita los cuadros de texto para busqueda
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            funHabilitarText();
            cnegocio.funactivarDesactivarCombobox(cmbBanco, true);
            cnegocio.funactivarDesactivarBoton(btnguardar, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, true);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btnrefrescar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
            cnegocio.funactivarDesactivarBoton(btnimprimir, false);
        }

        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: PRIMERO
            mueve el grid a la primer fila
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnirPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdDocumentos);
        }

        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: ANTERIOR
            mueve el grid a la fila antenrior
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdDocumentos);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: SIGUIENTE
            mueve el grid a la fila siguiente
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDocumentos);
        }


        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: ULTIMO
            mueve el grid a la ultima fila
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnirUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDocumentos);
        }

        /*---------------------------------------------------------------------------------------------------------------------------
            BOTON: IMPRIMIR
            ejecuta el reporteador
         ---------------------------------------------------------------------------------------------------------------------------*/
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            sFormulario = "Cobros";
            iIdAplicacion = 1;
            iIdModulo = 1;
            iIdUsuario = 1;
            sPrivilegio = "Superusuario";
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(sFormulario,iIdAplicacion, iIdModulo, iIdUsuario, sPrivilegio);
            FormCarga.Show();

        }

    }
}
