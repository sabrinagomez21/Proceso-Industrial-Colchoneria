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
 *Formulario Tipo Documento
 *Autor: Dennys Choy
 */

namespace CuentasPorCobrar
{
    public partial class frmTipoDoc : Form
    {
        int idusuario;
        string privilegio;
        string nomformulario;
        int idaplicacion;
        int idmodulo;
        public frmTipoDoc(int id, string priv)
        {
            InitializeComponent();
            idusuario = id;
            privilegio = priv;
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

        private void frmTipoDoc_Load(object sender, EventArgs e)
        {
            funActualizarGrid();
            funInicioBotones();

            txtEstado.Enabled = false;
            txtDescripcion.Enabled = false;
            txtNombredoc.Enabled = false;
            txtcodtipodoc.Text = "n";
           
        }
        private void funActualizarGrid()
        {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("matipodocumento", "select ncodtipodocumento, vtipodocumento, vdescripciondocumento from matipodocumento where vestado = 'ACTIVO';", "consulta", grdTipodoc);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtcodtipodoc.Text == "n")
            {
                string sTabla = "matipodocumento";
                Boolean bPermiso = true;
                TextBox[] aDatos = { txtNombredoc, txtDescripcion, txtEstado };               
                clasnegocio cn = new clasnegocio();
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                MessageBox.Show("Registro Guardado");
            }
            else
            {
                TextBox[] datos = { txtNombredoc, txtEstado, txtDescripcion, txtcodtipodoc };
                clasnegocio cn = new clasnegocio();
                string tabla = "matipodocumento";
                Boolean permiso = true;
                string codigo = txtcodtipodoc.Text;
                cn.EditarObjetos(tabla, permiso, datos, codigo, "ncodtipodocumento");                

                MessageBox.Show("Registro Editado");
            }

            txtEstado.Text = "";
            txtDescripcion.Text = "";
            txtNombredoc.Text = "";
            txtDescripcion.Enabled = false;
            txtNombredoc.Enabled = false;            
            txtcodtipodoc.Clear();
            funInicioBotones();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            nomformulario = "nombre de su formulario";
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario, idaplicacion, idmodulo, idusuario, privilegio);
            FormCarga.Show();
        }

        private void grdTipodoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ncodtipodocumento, vtipodocumento, vdescripciondocumento
            txtcodtipodoc.Text = grdTipodoc[0, grdTipodoc.CurrentCell.RowIndex].Value.ToString();
            txtDescripcion.Text = grdTipodoc[2, grdTipodoc.CurrentCell.RowIndex].Value.ToString();
            txtNombredoc.Text = grdTipodoc[1, grdTipodoc.CurrentCell.RowIndex].Value.ToString();

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            funbtnEditar();
            txtNombredoc.Enabled = true;
            txtDescripcion.Enabled = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "matipodocumento";
            codEliminar = txtcodtipodoc.Text;
            campoLlavePrimaria = "ncodtipodocumento";
            campoEstado = "vestado";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funPrimero(grdTipodoc); 
            // parámetro que envía es nombre del GridView el cual desea recorrer 
            //(dataGridView1) en este caso.
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdTipodoc); 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdTipodoc); 
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdTipodoc); 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            funbtnNuevo();
            txtDescripcion.Enabled = true;
            txtNombredoc.Enabled = true;
            txtDescripcion.Clear();
            txtNombredoc.Clear();
            txtcodtipodoc.Text = "n";
            txtEstado.Text = "ACTIVO";
                 

      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funInicioBotones();
            txtDescripcion.Enabled = false;
            txtNombredoc.Enabled = false;
            txtcodtipodoc.Text = "n";
        }

        private void txtNombredoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz123456789,0.- " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
