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

/*
 *formulario documento de pago 
 *Autor: Dennys Choy
 */

namespace CuentasPorCobrar
{
    public partial class frmDocumentodepago : Form
    {
        int idusuario;
        string privilegio;
        string nomformulario;
        int idaplicacion;
        int idmodulo;
        public frmDocumentodepago(int id, string priv)
        {
            InitializeComponent();
            idusuario = id;
            privilegio = priv;
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcodproveedor.Text = cmbProveedor.SelectedValue.ToString();
        }

        /**
      * HABILITAR Y DESHABILITAR BOTONES
      * */
        #region
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
        public void funbtnNuevo()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
            btnImprimir.Enabled = false;
            btnRefrescar.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnIrPrimero.Enabled = true;
            btnIrUltimo.Enabled = true;
        }
        public void funbtnEditar()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;
            btnImprimir.Enabled = false;
            btnRefrescar.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnIrPrimero.Enabled = true;
            btnIrUltimo.Enabled = true;
        }

        #endregion
        /*
         * DESHABILITAR Y HABILITAR BOTONES
         * */

        #region Comportamiento de txtbox
        private void funlimpiartextos()
        {
            txtDescripcioncompra.Clear();
            txtDeuda.Clear();
            txtReferencia.Clear();
            txtCoddoc.Text = "n";
        }

        private void deshabilitartxt()
        {
            cmbProveedor.Enabled = false;
            cmbTipodoc.Enabled = false;
            dateEmision.Enabled = false;
            txtDescripcioncompra.Enabled = false;
            txtDeuda.Enabled = false;
            txtReferencia.Enabled = false;
            //txtCoddoc.Text = "n";
        }
        private void habilitartxt()
        {
            cmbProveedor.Enabled = true;
            cmbTipodoc.Enabled = true;
            dateEmision.Enabled = true;
            txtDescripcioncompra.Enabled = true;
            txtDeuda.Enabled = true;
            txtReferencia.Enabled = true;
        }

        #endregion

        private void funActualizarCombo()
        {
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistrosCombo("ncodproveedor", "Select ncodproveedor, vnombre from MaPROVEEDOR", "vnombre", cmbProveedor);
            cn.funconsultarRegistrosCombo("ncodtipodocumento", "select ncodtipodocumento, vtipodocumento from matipodocumento where vestado = 'ACTIVO'", "vtipodocumento", cmbTipodoc);
            
        }
        private void funActualizarGrid()
        {
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistros("madocporpagar", "select ndocumento, vdescripcioncompra, vnumerodocfisico, ntotalpago, ndeudaactual, vfechaemision, ncodproveedor, ncodtipodocumento from madocporpagar where vestado = 'ACTIVO'", "consulta", dgvDocumentosdepago);
  
        }

        private void frmDocumentodepago_Load(object sender, EventArgs e)
        {
            funActualizarCombo();
            funActualizarGrid();
            funInicioBotones();
            deshabilitartxt();
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCoddoc.Text == "n")
            {
                string tabla = "madocporpagar";
                Boolean permiso = true;
                TextBox[] datos = { txtcodproveedor, txtTipodoc, txtFechaEmision, txtDescripcioncompra, txtDeuda, txtdeudactual, txtEstado, txtReferencia };
                clasnegocio neg2 = new clasnegocio();
                neg2.AsignarObjetos(tabla, permiso, datos);
                MessageBox.Show("Registro Guardado");
            }
            else
            {
                TextBox[] datos = { txtcodproveedor, txtTipodoc, txtFechaEmision, txtDescripcioncompra, txtDeuda, txtdeudactual, txtEstado, txtReferencia, txtCoddoc };
                clasnegocio cn = new clasnegocio();
                string tabla = "madocporpagar";
                Boolean permiso = true;
                string codigo = txtCoddoc.Text;
                cn.EditarObjetos(tabla, permiso, datos, codigo, "ndocumento");
  
                MessageBox.Show("Registro Editado");
            }
            funInicioBotones();
            deshabilitartxt();
            funlimpiartextos();

        }

        private void cmbTipodoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            txtTipodoc.Text = cmbTipodoc.SelectedValue.ToString();
            
          
        }

        private void dateEmision_ValueChanged(object sender, EventArgs e)
        {
            txtFechaEmision.Text = dateEmision.Text;
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
            funActualizarCombo();

        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            txtdeudactual.Text = txtDeuda.Text;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            funbtnNuevo();
            habilitartxt();
            funlimpiartextos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funInicioBotones();
            
            deshabilitartxt();
        }

        private void dgvDocumentosdepago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
           //ndocumento, vdescripcioncompra, vnumerodocfisico, ntotalpago, ndeudaactual, vfechaemision, ncodproveedor, ncodtipodocumento 
           txtDescripcioncompra.Text = dgvDocumentosdepago[1, dgvDocumentosdepago.CurrentCell.RowIndex].Value.ToString();
           txtcodproveedor.Text = dgvDocumentosdepago[6, dgvDocumentosdepago.CurrentCell.RowIndex].Value.ToString();
           txtDeuda.Text = dgvDocumentosdepago[3, dgvDocumentosdepago.CurrentCell.RowIndex].Value.ToString();
           txtReferencia.Text = dgvDocumentosdepago[2, dgvDocumentosdepago.CurrentCell.RowIndex].Value.ToString();
           txtCoddoc.Text = dgvDocumentosdepago[0, dgvDocumentosdepago.CurrentCell.RowIndex].Value.ToString();
           txtFechaEmision.Text = dgvDocumentosdepago[4, dgvDocumentosdepago.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            funbtnEditar();
            habilitartxt();
             /*TextBox[] datos = { txtcodproveedor, txtTipodoc, txtFechaEmision, txtDescripcioncompra, txtDeuda, txtdeudactual, txtEstado, txtReferencia };
            clasnegocio cn = new clasnegocio();
            string tabla = "madocporpagar";
            Boolean permiso = true;
            string codigo = txtCoddoc.Text; 
             * */
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            nomformulario = "nombre de su formulario";
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario, idaplicacion, idmodulo, idusuario, privilegio);
            FormCarga.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "madocporpagar";
            codEliminar = txtCoddoc.Text;
            campoLlavePrimaria = "ndocumento";
            campoEstado = "vestado";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvDocumentosdepago); 
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvDocumentosdepago); 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvDocumentosdepago); 
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvDocumentosdepago); 
        }

        private void txtDescripcioncompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890.,:;-() " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890." + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890._;-: " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscardocumentos frmbuscar = new buscardocumentos();
            frmbuscar.Show();
        }
    }
}
