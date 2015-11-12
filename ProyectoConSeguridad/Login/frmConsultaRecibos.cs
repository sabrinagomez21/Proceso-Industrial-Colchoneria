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
    public partial class frmConsultaRecibos : Form
    {
        public frmConsultaRecibos()
        {
            InitializeComponent();
            funActualizar();
        }

        private void frmConsultaRecibos_Load(object sender, EventArgs e)
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
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnimprimir.Enabled = false;

        }
        void funActualizar()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Recibo, trdocumentos.dfecha as Fecha , trdocumentos.nmonto as Monto from mafacturacobro,trdocumentos, matipotransaccion, trcobro WHERE matipotransaccion.vnombredocumento = 'Cobro'", "consulta", grdRecibos);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            btncancelar.Enabled = true;
            btnbuscar.Enabled = false;
            txtBuscar.Enabled = true;
        }

        private void btnirPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdRecibos);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdRecibos);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdRecibos);
        }

        private void btnirUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdRecibos);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha , trdocumentos.nmonto as Monto from trdocumentos, matipotransaccion WHERE matipotransaccion.vnombredocumento = 'Cobro' AND trdocumentos.ncoddocumento LIKE '" + txtBuscar.Text + "%'", "consulta", grdRecibos);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btncancelar.Enabled = false;
            btnbuscar.Enabled = true;
            txtBuscar.Enabled = false;
        }
    }
}
