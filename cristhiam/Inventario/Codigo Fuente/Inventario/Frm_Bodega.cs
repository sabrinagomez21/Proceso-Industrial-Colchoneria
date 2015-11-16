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
using prueba1;

namespace Inventario
{
    //Programador y Analista: Ricardo Von-Raynts
    //Fecha de Asignación: 06/11/2015
    //Fecha de Entrega: 10/11/2015
    //Realiza Mantenimiento a la tabla MaBodega
    public partial class Frm_Bodega : Form
    {
        #region Variables
        string tablaviene;
        string datos;
        int idusuario;
        string nomformulario;
        int idaplicacion;
        int idmodulo;
        string id;
        string privilegio;
        #endregion

        #region Toma Variables e inicializa
        public Frm_Bodega(int idtoma, string priv)
        {
            idusuario = idtoma;
            privilegio = priv;
            InitializeComponent();
        }
        #endregion

        #region Form load
        private void Frm_Bodega_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
            Fnc_CargaboxArticulo();
        }
        #endregion

        #region Btn Salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funcion para cargar grid

        public void Fnc_Cargagrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mabodega", "SELECT ncodbodega,vnombrebodega,vdireccionbodega from mabodega WHERE vstatus='ACTIVO'", "consulta", DGV_Bodega);
        }
        #endregion

        #region Btn Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Txt_vstatus.Text = "ACTIVO";
            TextBox[] aDatos = { Txt_vnombrebodega, Txt_vdireccionbodega, Txt_vstatus };
            string sTabla = "mabodega";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);

            mySqlComando = new OdbcCommand("SELECT MAX(ncodbodega) FROM mabodega;", ConexionODBC.Conexion.ObtenerConexion());
            Txt_ncodbodeganuevo.Text = Convert.ToString(mySqlComando.ExecuteScalar());
            ConexionODBC.Conexion.ObtenerConexion().Close();

            TextBox[] aDatos2 = { Txt_ncodbodeganuevo, Txt_ncodarticulo };
            string sTabla2 = "trexistencia";
            Boolean bPermiso2 = true;
            clasnegocio cn2 = new clasnegocio();
            cn.AsignarObjetos(sTabla2, bPermiso2, aDatos2);


            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();
            limpiar();
            Cancelar();

            
            

        }
        #endregion

        #region Limpiar
        public void limpiar()
    {
            Txt_ncodbodega.Clear();
            Txt_vnombrebodega.Clear();
            Txt_vdireccionbodega.Clear();
            Txt_vstatus.Clear();
    }
        #endregion

        #region Btn Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_vnombrebodega, true);
            cnegocio.funactivarDesactivarTextbox(Txt_vdireccionbodega, true);
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        #endregion

        #region Cancelar
        public void Cancelar()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_vnombrebodega, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vdireccionbodega, false);
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
        #endregion

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        #endregion

        #region Btn Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region Btn Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "mabodega";
            codEliminar = Txt_ncodbodega.Text;
            campoLlavePrimaria = "ncodbodega";
            campoEstado = "vstatus";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            Fnc_Cargagrid();
            limpiar();
            Cancelar();
        }
        #endregion

        #region Btn Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tablaviene = "mabodega";
            datos = "ncodbodega,vnombrebodega,vdireccionbodega,vstatus";
            buscar busc = new buscar(tablaviene, datos);
            busc.Show();
        }
        #endregion

        #region Btn Imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            nomformulario = "nombre de su formulario";
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario, idaplicacion, idmodulo, idusuario, privilegio);
            FormCarga.Show();
        }
        #endregion

        #region Btn IrPrimero
        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(DGV_Bodega);
        }
        #endregion

        #region Btn Anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(DGV_Bodega);
        }
        #endregion

        #region Btn Siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(DGV_Bodega);
        }
        #endregion

        #region Btn IrUltimo
        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(DGV_Bodega);
        }
        #endregion

        #region CellContent
        private void DGV_Bodega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ncodbodega.Text = DGV_Bodega[0, DGV_Bodega.CurrentCell.RowIndex].Value.ToString();
            Txt_vnombrebodega.Text = DGV_Bodega[1, DGV_Bodega.CurrentCell.RowIndex].Value.ToString();
            Txt_vdireccionbodega.Text = DGV_Bodega[2, DGV_Bodega.CurrentCell.RowIndex].Value.ToString();
            btnIrPrimero.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnIrUltimo.Enabled = true;
            btnEliminar.Enabled = true;
        }
        #endregion

        #region Btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { Txt_vnombrebodega, Txt_vdireccionbodega };
            clasnegocio cn = new clasnegocio();
            string tabla = "mabodega";
            Boolean permiso = true;
            string codigo = Txt_ncodbodega.Text;
            cn.EditarObjetos("mabodega", permiso, arraytexto, codigo, "ncodbodega");
            MessageBox.Show("Registro Actualizado");
            Fnc_Cargagrid();
            limpiar();
            Cancelar();
        }
        #endregion

        #region cargaboxArticulo
        public void Fnc_CargaboxArticulo()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodarticulo", "SELECT ncodarticulo,vnombre from maproducto", "vnombre", Cmb_ncodarticulo);
        }
        #endregion

        #region Carga box ncodarticulo

        private static OdbcCommand mySqlComando;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand("SELECT ncodarticulo FROM maproducto WHERE vnombre = '" + Cmb_ncodarticulo.Text.Trim() + "';", ConexionODBC.Conexion.ObtenerConexion());
            Txt_ncodarticulo.Text = Convert.ToString(mySqlComando.ExecuteScalar());
            ConexionODBC.Conexion.ObtenerConexion().Close();
        }
        #endregion

        private void Txt_vnombrebodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_vdireccionbodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-1234567890 " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
