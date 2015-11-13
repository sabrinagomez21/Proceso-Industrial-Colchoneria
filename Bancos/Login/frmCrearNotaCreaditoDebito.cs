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
    public partial class frmCrearNotaCreaditoDebito : Form
    {
        string sCodigoFactura;
        string sMontoFactura;
        string estado;
        public frmCrearNotaCreaditoDebito()
        {
            InitializeComponent();
            funLlenarCmbyTabla();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btneditar.Enabled = false;
            //funLlenarcmbBancos();
            //funLlenarTabla();
        }

        private void lblNit_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtMonto, true);
            cnegocio.funactivarDesactivarTextbox(txtFactura, true);
            //cnegocio.funactivarDesactivarTextbox(txtMonto, true); 
            //cnegocio.funactivarDesactivarCombobox(cmbCliente, true);
            //cnegocio.funactivarDesactivarCombobox(cmbNit, true);
            //cnegocio.funactivarDesactivarCombobox(cmbMontoFact, true);
            cnegocio.funactivarDesactivarCombobox(cmbDocumento, true);
            dtNFecha.Enabled = true;
            //lblEstado.Visible = false;
            //txtBuscar.Visible = false;
            //lblAgregar.Enabled = true;
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        void funLlenarCmbyTabla()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("trcreditodebito", "SELECT trcreditodebito.ncoddocumento as Numero, trcreditodebito.dfecha as Fecha, trcreditodebito.nmonto as Monto, matipotransaccion.vnombredocumento as Documento, ncodfactura as CodigoFactura FROM trcreditodebito, matipotransaccion WHERE trcreditodebito.ncodtipotransaccion=matipotransaccion.ncodtipotransaccion ", "consulta", grdDatos);
            cnegocio.funconsultarRegistrosCombo("ncodtipotransaccion", "SELECT concat(ncodtipotransaccion, '.', vnombredocumento) as Doc FROM matipotransaccion WHERE vestado='Activo'", "Doc", cmbDocumento);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sTabla = "trcreditodebito";
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            TextBox txtFecha = new TextBox();
            txtFecha.Text = dtNFecha.Text;            
            txtFecha.Tag = "dfecha";

            string sCadena = cmbDocumento.Text;
            
            TextBox txtTipoTransaccion = new TextBox();
            txtTipoTransaccion.Text = sCadena.Substring(0, 1);
            txtTipoTransaccion.Tag = "ncodtipotransaccion";

            txtCodFact.Text = sCodigoFactura;
            System.Console.WriteLine(sCadena);
            
            TextBox[] datos = { txtFecha, txtMonto, txtTipoTransaccion, txtCodFact };

            cn.AsignarObjetos(sTabla, bPermiso, datos);

            estado = "";
            cn.funactivarDesactivarTextbox(txtFactura, false);
            cn.funactivarDesactivarTextbox(txtMonto, false);
            cn.funactivarDesactivarCombobox(cmbDocumento, false);
            
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
        }

        private void txtFactura_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            
            cnegocio.funconsultarRegistrosCombo("mafacturacobro", "SELECT ncodfactura as CodFactura from mafacturacobro WHERE nnofactura LIKE '" + txtFactura.Text + "%'", "CodFactura", cmbCFact);
            
            sCodigoFactura = cmbCFact.Text;
            System.Console.WriteLine("Codigo de la factura------"+ sCodigoFactura);
            
            cnegocio.funconsultarRegistrosCombo("mafacturacobro", "SELECT ntotal as Total from mafacturacobro WHERE nnofactura LIKE '" + txtFactura.Text + "%'", "Total", cmbMontoFact);            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtFactura, false);
            cn.funactivarDesactivarTextbox(txtMonto, false);
            cn.funactivarDesactivarCombobox(cmbDocumento, false);
            dtNFecha.Enabled = false;            
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdDatos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDatos);
        }

        private void frmCrearNotaCreaditoDebito_Load(object sender, EventArgs e)
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
    }
}
