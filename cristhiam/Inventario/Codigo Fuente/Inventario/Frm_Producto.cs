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
    //Fecha de Entrega: 09/11/2015
    //Realiza Mantenimiento a la tabla MaProducto
    public partial class Frm_Producto : Form
    {
        #region Variables
        string tablaviene;
        string datos;
        string nomformulario;
        int idaplicacion; //id que se le asigno al formulario 
        int idmodulo;
        int idusuario;
        string privilegio;
        #endregion

        #region inicializacion
        public Frm_Producto(int idtoma, string priv)
        {
            idusuario = idtoma;
            privilegio = priv;
            InitializeComponent();
        }
        #endregion

        #region Form Load
        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region Funcion para cargar grid

        public void Fnc_Cargagrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maproducto", "SELECT * from maproducto ", "consulta", DGV_producto);
        }
        #endregion

        #region Btn Refresca
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region CellContent
        private void DGV_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ncodarticulo.Text = DGV_producto[0, DGV_producto.CurrentCell.RowIndex].Value.ToString();
            Txt_nexistencia.Text = DGV_producto[1, DGV_producto.CurrentCell.RowIndex].Value.ToString();
            Txt_nprecio.Text = DGV_producto[2, DGV_producto.CurrentCell.RowIndex].Value.ToString();
            Txt_vmarca.Text = DGV_producto[3, DGV_producto.CurrentCell.RowIndex].Value.ToString();
            Txt_vnombre.Text = DGV_producto[4, DGV_producto.CurrentCell.RowIndex].Value.ToString();
            Txt_vdescripcion.Text = DGV_producto[5, DGV_producto.CurrentCell.RowIndex].Value.ToString();
            btnIrPrimero.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnIrUltimo.Enabled = true;
            btnEliminar.Enabled = true;
        }
        #endregion

        #region Btn Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextBox[] aDatos = { Txt_nexistencia, Txt_nprecio, Txt_vmarca, Txt_vnombre, Txt_vdescripcion };
            string sTabla = "maproducto";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();
            limpiar();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nexistencia, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nprecio, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcion, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vmarca, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vnombre, false);
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            Cancela();
        }
        #endregion

        #region Limpiar
        public void limpiar()
        {
            Txt_ncodarticulo.Clear();
            Txt_nexistencia.Clear();
            Txt_nprecio.Clear();
            Txt_vdescripcion.Clear();
            Txt_vmarca.Clear();
            Txt_vnombre.Clear();
        }
        #endregion

        #region Btn Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, true);
            cnegocio.funactivarDesactivarTextbox(Txt_nexistencia, true);
            cnegocio.funactivarDesactivarTextbox(Txt_nprecio, true);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcion, true);
            cnegocio.funactivarDesactivarTextbox(Txt_vmarca, true);
            cnegocio.funactivarDesactivarTextbox(Txt_vnombre, true);
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        #endregion

        #region Btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { Txt_nexistencia, Txt_nprecio, Txt_vmarca, Txt_vnombre, Txt_vdescripcion };
            clasnegocio cn = new clasnegocio();
            string tabla = "maproducto";
            Boolean permiso = true;
            string codigo = Txt_ncodarticulo.Text;
            cn.EditarObjetos("maproducto", permiso, arraytexto, codigo, "ncodarticulo");
            MessageBox.Show("Registro Actualizado");
            Fnc_Cargagrid();
            limpiar();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nexistencia, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nprecio, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcion, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vmarca, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vnombre, false);
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            Cancela();
        }
        #endregion

        #region Btn Eliminar
        private static OdbcCommand mySqlComando;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand(string.Format("Delete From maproducto where ncodarticulo='" + Txt_ncodarticulo.Text + "'"), ConexionODBC.Conexion.ObtenerConexion());
            mySqlComando.ExecuteNonQuery();
            ConexionODBC.Conexion.ObtenerConexion().Close();
            Fnc_Cargagrid();
            limpiar();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nexistencia, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nprecio, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcion, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vmarca, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vnombre, false);
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            Cancela();
        }
        #endregion

        #region Cancela
        public void Cancela()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nexistencia, false);
            cnegocio.funactivarDesactivarTextbox(Txt_nprecio, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcion, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vmarca, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vnombre, false);
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
        #endregion

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancela();
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

        #region Btn Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tablaviene = "maproducto";
            datos = "ncodarticulo,nexistencia,nprecio,vmarca,vnombre,vdescripcion";
            buscar busc = new buscar(tablaviene, datos);
            busc.Show(); 
        }
        #endregion

        #region Btns Grid
        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(DGV_producto); 
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(DGV_producto); 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(DGV_producto); 
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(DGV_producto); 
        }
        #endregion

        #region Btn Salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
