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
    public partial class frmCrearCreditoDebito : Form
    {
        string sCodigoFactura;
        string sMontoFactura;
        string estado;
        public frmCrearCreditoDebito()
        {
            InitializeComponent();
            funLlenarCmbyTabla();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnEditar.Enabled = false;
        }

        void funLlenarCmbyTabla()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("trcreditodebito", "SELECT trcreditodebito.ncoddocumento as Numero, trcreditodebito.dfecha as Fecha, trcreditodebito.nmonto as Monto, matipotransaccion.vnombredocumento as Documento, ncodfactura as CodigoFactura FROM trcreditodebito, matipotransaccion WHERE trcreditodebito.ncodtipotransaccion=matipotransaccion.ncodtipotransaccion ", "consulta", grdDatos);
            cnegocio.funconsultarRegistrosCombo("ncodtipotransaccion", "SELECT concat(ncodtipotransaccion, '.', vnombredocumento) as Doc FROM matipotransaccion WHERE vnombredocumento='Credito' OR vnombredocumento='Debito'", "Doc", cmbDocumento);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtMonto, true);
            cnegocio.funactivarDesactivarTextbox(txtFactura, true);            
            cnegocio.funactivarDesactivarCombobox(cmbDocumento, true);
            dtNFecha.Enabled = true;
            //lblEstado.Visible = false;
            //txtBuscar.Visible = false;
            //lblAgregar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
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
            
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            funLlenarCmbyTabla();
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
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = true;
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
    }
}
