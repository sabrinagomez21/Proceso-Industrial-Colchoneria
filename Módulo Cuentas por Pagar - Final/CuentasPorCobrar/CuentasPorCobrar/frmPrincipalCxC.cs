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

/*
 *Formulario Mantenimiento Proveedor
 *Autor: Dennys Choy, José Arredondo
 *Fecha: 13 de noviembre 2015
 */

namespace CuentasPorCobrar
{
    
    public partial class frmPrincipalCxC : Form
    {

        //Variables para usuarios del Sistema y privilegios
        int idusuario;
        string privilegio;
        string nomformulario;
        int idaplicacion;
        int idmodulo;
       


        public frmPrincipalCxC(int id, string priv)
        {
            InitializeComponent();
            idusuario = id;
            privilegio = priv;

         
        }   
       

        private void frmPrincipalCxC_Load(object sender, EventArgs e)
        {
            funActualizarGrid();
            funActualizarCombo();
            funAgregarCheckBox();
            funDesTextBox();
            funInicioBotones();
        }


        private void funAgregarCheckBox()
        {
            // Create new Checkbox Column
            DataGridViewCheckBoxColumn myCheckedColumn = new DataGridViewCheckBoxColumn()
            {
                Name = "Checked Column",
                FalseValue = 0,
                TrueValue = 1,
                Visible = true
            };
            // add the new column to your dataGridView 
            grdDocumentos.Columns.Add(myCheckedColumn);
        }

        private void funActualizarGrid()
        {
            //Se Actualiza el grid según el tipo de transacción.
            if ( txtTipotransac.Text == "Incremento")
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("mafactura", "select ncodfactura, vserie, ntotal, dfecha, ncodcliente, ncodvendedor from mafactura where vestado = 'ACTIVO'", "consulta", grdDocumentos);
                //SELECT (ncoddocumento) AS ncoddocumento FROM trdocumentos
                btnPagar.Enabled = false;
                btnCobro.Enabled = true;
            }
            else if (txtTipotransac.Text == "Decremento")
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("madocporpagar", "select ndocumento, vnumerodocfisico, vdescripcioncompra, ntotalpago, ndeudaactual, vfechaemision, ncodproveedor, ncodtipodocumento from madocporpagar where vestado = 'ACTIVO'; ", "consulta", grdDocumentos);
                //SELECT (ncoddocumento) AS ncoddocumento FROM trdocumentos
                btnPagar.Enabled = true;
                btnCobro.Enabled = false;
            } else if (txtTipotransac.Text == "Orden de Compra")
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("trcompra", "select *from trcompra; ", "consulta", grdDocumentos);
                btnPagar.Enabled = true;
                btnCobro.Enabled = false;
            }
        }

        //Función para actualizar comboBox
        private void funActualizarCombo()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("vbincdec", "SELECT vbincdec,vnombredocumento from matipotransaccion", "vnombredocumento", cmbTransac);
            cnegocio.funconsultarRegistrosCombo("ncodbanco", "select ncodbanco, vnombrebanco from mabanco where cestado = 'ACTIVO'", "vnombrebanco", cmbBanco);
            
        }
            

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
        //Boton de refrescar
            funActualizarGrid();
            funActualizarCombo();
        }

        #region PORDEFECTO
        private void txtCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbTransaccion.Text == "Cobro")
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtCliente.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafactura", "SELECT mafactura.ncodfactura, mafactura.dfecha, mafactura.ntotal from mafactura, macliente WHERE mafactura.vestado='ACTIVO' AND macliente.ncodcliente LIKE '" + txtCliente.Text + "%' AND macliente.ncodcliente = mafactura.ncodcliente", "consulta", grdDocumentos);
                    }
                    else
                    {
                        funActualizarGrid();
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error filtrando clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtDocto_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbTransaccion.Text == "Cobro")
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtDocto.Text))
                    {
                        clasnegocio cnegocio = new clasnegocio();
                        cnegocio.funconsultarRegistros("mafactura", "SELECT mafactura.ncodfactura, mafactura.dfecha, mafactura.ntotal from mafactura WHERE mafactura.vestado='ACTIVO' AND mafactura.ncodfactura LIKE '" + txtDocto.Text + "%'", "consulta", grdDocumentos);
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
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (cmbTransaccion.Text == "Cobro")
            {
                try
                {
                    clasnegocio cnegocio = new clasnegocio();
                    cnegocio.funconsultarRegistros("mafactura", "SELECT mafactura.ncodfactura, mafactura.dfecha, mafactura.ntotal from mafactura WHERE mafactura.vestado='ACTIVO' AND mafactura.dfecha = '" + dtpFecha.Text + "%'", "consulta", grdDocumentos);
                }
                catch
                {
                    MessageBox.Show("Se produjo un error filtrando documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
        
        private void cmbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {    
            funActualizarGrid();
        }

        private void btnPagoCobro_Click(object sender, EventArgs e)
        {
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            txtDocto.Text = "";
            funActualizarGrid();
        }

        private void txtDocto_Enter(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            funActualizarGrid();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void cmbTransac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Actualiza el Grid según el tipo de transacción
             txtTipotransac.Text = cmbTransac.SelectedValue.ToString();
             funActualizarGrid();
         
        }

        private void grdDocumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carga de los datos del grid a textbox

            if (txtTipotransac.Text == "Decremento")
            {            
            txtNodoc.Text = grdDocumentos[1, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            txtReferencia.Text = grdDocumentos[2, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            txtDescripcion.Text = grdDocumentos[3, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            txtTotal.Text = grdDocumentos[4, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            txtDeuda.Text = grdDocumentos[5, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            txtFechaemision.Text = grdDocumentos[6, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            txtCodproveedor.Text = grdDocumentos[7, grdDocumentos.CurrentCell.RowIndex].Value.ToString();            
            }
            else if (txtTipotransac.Text == "Orden de Compra")
            {
                          
                txtNodoc.Text = grdDocumentos[7, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
                txtTotal.Text = grdDocumentos[4, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
                txtDeuda.Text = grdDocumentos[6, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
                txtCodproveedor.Text = grdDocumentos[2, grdDocumentos.CurrentCell.RowIndex].Value.ToString();
            
            }
       }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand("update madocporpagar set ndeudaactual = '" + txtDeuda.Text + "', ntotalpago = '"+txtTotal.Text+"' where ndocumento= " + txtNodoc.Text + ";", CAD.obtenerConexion());
                OdbcDataReader MyReader2;
                MyReader2 = mySqlComando.ExecuteReader();
                MessageBox.Show("Registro Modificado");
                while (MyReader2.Read())
                {
                }
                CAD.obtenerConexion().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            funDesTextBox();
            funInicioBotones();
            funLimpiarTextos();
            funActualizarGrid();
         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            nomformulario = "nombre de su formulario";
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario, idaplicacion, idmodulo, idusuario, privilegio);
            FormCarga.Show();
        }

        


        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocto_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            funInicioBotones();
            funLimpiarTextos();
        }




        #region Habilitar, Deshabilitar TextBox
        public void funDesTextBox()
        {
            txtNodoc.Enabled = false;
            txtReferencia.Enabled = false;
            txtDescripcion.Enabled = false;
            txtTotal.Enabled = false;
            txtDeuda.Enabled = false;
            txtFechaemision.Enabled = false;
            txtCodproveedor.Enabled = false;

        }
        public void funInicioBotones()
        {
            btnAnterior.Enabled = true;
            btnBuscar.Enabled = true;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = true;
            btnIrPrimero.Enabled = true;
            btnIrUltimo.Enabled = true;
            btnNuevo.Enabled = true;
            btnRefrescar.Enabled = true;
            btnSiguiente.Enabled = true;
        }
        public void funLimpiarTextos()
        {
            txtNodoc.Clear();
            txtReferencia.Clear();
            txtDescripcion.Clear();
            txtTotal.Clear();
            txtDeuda.Clear();
            txtFechaemision.Clear();
            txtCodproveedor.Clear();
        }

        #endregion

        private void btnPagar_Click(object sender, EventArgs e)
        {
            

              decimal valorpago, deuda, dbpago;
          //  valorpago = Convert.ToInt32(txtValor.Text);
            valorpago = System.Convert.ToDecimal(txtValor.Text);
            deuda = System.Convert.ToDecimal(txtDeuda.Text);
            //deuda = int.Parse(txtDeuda.Text);

            if (valorpago > deuda)
            {
                MessageBox.Show("La cantidad que desea pagar es mayor a la deuda");
            }
            else if (deuda > 0)
            {
                    dbpago = deuda - valorpago;
                   
                   try
                    {

                       
                      //ACTUALIZA LA DEUDA ACTUAL SEGUN LA CANTIDAD DE PAGO QUE SE REALIZA
                       
                        OdbcCommand mySqlComando = new OdbcCommand("update madocporpagar set ndeudaactual = '" + dbpago + "'where ndocumento= " + txtNodoc.Text + ";", ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader MyReader2;
                        MyReader2 = mySqlComando.ExecuteReader();
            //            MessageBox.Show("Pago Realizado en madocporpagar");
                        while (MyReader2.Read())
                        {
                        }
                        ConexionODBC.Conexion.ObtenerConexion().Close();
                       
                      //********************************
                         //Registra el pago en trdocumentos -> Tabla de Bancos
                         //*************************************                       
                        TextBox[] aDatos = { txtFechapago, txtValor, txtCodtipotransaccion, txtCuenta, txtNodoc};
                        string sTabla = "trdocumentos";
                        Boolean bPermiso = true;
                        clasnegocio cn = new clasnegocio();
                        cn.AsignarObjetos(sTabla, bPermiso, aDatos);
              //          MessageBox.Show("Registro Guardado en trdocumento");
                                             
                       //--Fin de pago en trdocumentos

                        //*************************************************
                       //Selecciona ncodddocumento de trdocumentos para insertarlo despues en trpagoproveedor
                                OdbcCommand mySqlComand = new OdbcCommand("SELECT MAX(ncoddocumento) AS ncoddocumento FROM trdocumentos;", ConexionODBC.Conexion.ObtenerConexion());
                                OdbcDataReader MyReader3;
                                MyReader3 = mySqlComand.ExecuteReader();
                                while (MyReader3.Read())
                                {
                                    textBox3.Text = MyReader3.GetInt32(0).ToString();
                                }
                                ConexionODBC.Conexion.ObtenerConexion().Close();           
                       //Fin del select

                       /*
                        * INSERTA EN TRPAGOPROVEEDOR EL CODIGO DEL NUEVO DOCUEMENTO Y EL CODIGO DEL PROVEEDOR
                        * 
                        **/ 
                        OdbcCommand cmd = new OdbcCommand("insert into trpagoproveedor (ncodproveedor, ncoddocumento) values ('"+txtCodproveedor.Text +"','"+textBox3.Text +"');", ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader rd2;
                        rd2 = cmd.ExecuteReader();
                        //MessageBox.Show("Pago Realizado en trpagoproveedor");
                        while (rd2.Read())
                        {
                        }
                        ConexionODBC.Conexion.ObtenerConexion().Close();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   funLimpiarTextos();
                   funActualizarGrid();
                   MessageBox.Show("Pago realizado");

            
            }else if (deuda == 0){
            MessageBox.Show("El documento ya ha sido pagado en su totalidad");
            }
           

                       
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNodoc.Enabled = false;
            txtReferencia.Enabled = false;
            txtDescripcion.Enabled = false;
            txtTotal.Enabled = false;
            txtDeuda.Enabled = false;
            txtFechaemision.Enabled = false;
            txtCodproveedor.Enabled = false;

            txtTotal.Enabled = true;
            txtDeuda.Enabled = true;

            btnGuardar.Enabled = true;

        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            if (txtDeuda.Text != "")
            {
              /*  int total, deuda, dbpago;
                total = Convert.ToInt32(txtTotal.Text);
                deuda = int.Parse(txtDeuda.Text);*/

                decimal total, deuda, dbpago;
                total = System.Convert.ToDecimal(txtTotal.Text);
                deuda = System.Convert.ToDecimal(txtDeuda.Text);

                if (deuda > total)
                {
                    MessageBox.Show("El campo de deuda no puede ser mayor al de total");
                    txtDeuda.Text = "";
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funInicioBotones();
            funLimpiarTextos();
        }

        private void txtTipotransac_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateFechaPago_ValueChanged(object sender, EventArgs e)
        {
            txtFechapago.Text = dateFechaPago.Text;            
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdDocumentos); 
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdDocumentos); 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDocumentos); 
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDocumentos); 
        }

        private void txtCodtipotransaccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBanco.Text = cmbBanco.SelectedValue.ToString();
            
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodcuenta", "SELECT ncodcuenta,nnocuenta from macuenta where ncodbanco = '"+ txtBanco.Text +"';", "nnocuenta", cmbCuenta);
            
        }

        private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCuenta.Text = cmbCuenta.SelectedValue.ToString();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string cadena = "1234567890." + (char)8;

                if (!cadena.Contains(e.KeyChar))
                {

                    e.Handled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo puede escribir números y punto .");
            }
            
        }
    }
}
