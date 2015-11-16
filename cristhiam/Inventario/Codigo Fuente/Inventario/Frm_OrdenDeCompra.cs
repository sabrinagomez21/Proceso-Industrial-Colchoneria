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
    //Programador y Analista: Cristhiam Noe Duarte Herrera
    //Fecha de Asignación: 06/11/2015
    //Fecha de Entrega: 09/11/2015
    //Realiza Mantenimiento a la tabla MaOrdendecompra
    public partial class Frm_OrdenDeCompra : Form
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

        #region Inicia Variables
        public Frm_OrdenDeCompra(int idtoma, string priv)
        {
            idusuario = idtoma;
            privilegio = priv;
            InitializeComponent();
        }
        #endregion

        #region Form Load
        private void Frm_OrdenDeCompra_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
            Fnc_CargaboxProveedor();
            Fnc_CargaboxArticulo();
        }
        #endregion

        #region cargaboxArticulo
        public void Fnc_CargaboxArticulo()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodarticulo", "SELECT ncodarticulo,vnombre from maproducto", "vnombre", Cmb_ncodarticulo);
        }
        #endregion

        #region cargaboxProveedor();
        public void Fnc_CargaboxProveedor()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodproveedor", "SELECT ncodproveedor,vnombre from maproveedor", "vnombre", Cmb_ncodproveedor);
        }
        #endregion

        #region Funcion para cargar grid

        public void Fnc_Cargagrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maordencompra", "SELECT ncodordencompra,ncodproveedor,vdescripcioncompra,ncantidad,ncostototal,ncodarticulo,vstatusorden from maordencompra WHERE vstatus='ACTIVO'", "consulta", DGV_OrdenCompra);
        }
        #endregion

        #region Btn Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Txt_vstatusorden.Text = Cmb_Statusorden.Text;
            Txt_vstatus.Text = "ACTIVO";
            TextBox[] aDatos = { Txt_ncodordencompra, Txt_vstatusorden, Txt_ncodproveedor,Txt_vdescripcioncompra,Txt_ncantidad,Txt_ncostototal,Txt_ncodarticulo,Txt_vstatus };
            string sTabla = "maordencompra";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();
            limpiar();
            cancelar();
        }
        #endregion

        #region Carga ComboBox Proveedor
        private static OdbcCommand mySqlComando;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand("SELECT ncodproveedor FROM maproveedor WHERE vnombre = '" + Cmb_ncodproveedor.Text.Trim() + "';", ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader MyReader3;
            MyReader3 = mySqlComando.ExecuteReader();
            while (MyReader3.Read())
            {
                Txt_ncodproveedor.Text = MyReader3.GetInt32(0).ToString();
            }
            ConexionODBC.Conexion.ObtenerConexion().Close();
        }
        #endregion

        #region Carga ComboBox Producto
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand("SELECT ncodarticulo FROM maproducto WHERE vnombre = '" + Cmb_ncodarticulo.Text.Trim() + "';", ConexionODBC.Conexion.ObtenerConexion());
            Txt_ncodarticulo.Text = Convert.ToString( mySqlComando.ExecuteScalar());
            ConexionODBC.Conexion.ObtenerConexion().Close();
        }
        #endregion

        #region Btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { Txt_ncodproveedor, Txt_vdescripcioncompra, Txt_ncantidad, Txt_ncostototal, Txt_ncodarticulo, Txt_vstatusorden };
            clasnegocio cn = new clasnegocio();
            string tabla = "maordencompra";
            Boolean permiso = true;
            string codigo =  Txt_ncodordencompra.Text;
            cn.EditarObjetos("maordencompra", permiso, arraytexto, codigo, "ncodordencompra");
            MessageBox.Show("Registro Actualizado");
            Fnc_Cargagrid();
            limpiar();
            cancelar();
        }
        #endregion

        #region Limpiar
        public void limpiar()
        {
            Cmb_ncodproveedor.Text = "";
            Cmb_ncodarticulo.Text = "";
            Cmb_Statusorden.Text = "";
            Txt_ncodarticulo.Clear();
            Txt_ncodproveedor.Clear();
            Txt_vstatusorden.Clear();
            Txt_ncodordencompra.Clear();
            Txt_vdescripcioncompra.Clear();
            Txt_ncantidad.Clear();
            Txt_ncostototal.Clear();
        }
        #endregion

        #region cancelar
        public void cancelar()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, false);
            cnegocio.funactivarDesactivarTextbox(Txt_ncodproveedor, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vstatusorden, false);
            cnegocio.funactivarDesactivarTextbox(Txt_ncodordencompra, false);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcioncompra, false);
            cnegocio.funactivarDesactivarTextbox(Txt_ncantidad, false);
            cnegocio.funactivarDesactivarTextbox(Txt_ncostototal, false);
            Cmb_ncodproveedor.Enabled = false;
            Cmb_ncodarticulo.Enabled = false;
            Cmb_Statusorden.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
        #endregion

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }
        #endregion

        #region Btn Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            Cmb_ncodproveedor.Enabled = true;
            Cmb_ncodarticulo.Enabled = true;
            Cmb_Statusorden.Enabled = true; 
            cnegocio.funactivarDesactivarTextbox(Txt_ncodarticulo, true);
            cnegocio.funactivarDesactivarTextbox(Txt_ncodproveedor, true);
            cnegocio.funactivarDesactivarTextbox(Txt_vstatusorden, true);
            cnegocio.funactivarDesactivarTextbox(Txt_ncodordencompra, true);
            cnegocio.funactivarDesactivarTextbox(Txt_vdescripcioncompra, true);
            cnegocio.funactivarDesactivarTextbox(Txt_ncantidad, true);
            cnegocio.funactivarDesactivarTextbox(Txt_ncostototal, true);
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        #endregion

        #region CellContent
        private void DGV_OrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_ncodordencompra.Text = DGV_OrdenCompra[0, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_ncodproveedor.Text = DGV_OrdenCompra[1, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            mySqlComando = new OdbcCommand("SELECT vnombre FROM maproveedor WHERE ncodproveedor = '" + Txt_ncodproveedor.Text.Trim() + "';", ConexionODBC.Conexion.ObtenerConexion());
            Cmb_ncodproveedor.Text = Convert.ToString(mySqlComando.ExecuteScalar());
            ConexionODBC.Conexion.ObtenerConexion().Close();
            Txt_vdescripcioncompra.Text = DGV_OrdenCompra[2, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_ncantidad.Text = DGV_OrdenCompra[3, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_ncostototal.Text = DGV_OrdenCompra[4, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_ncodarticulo.Text = DGV_OrdenCompra[5, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_vstatusorden.Text = DGV_OrdenCompra[6, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            mySqlComando = new OdbcCommand("SELECT vnombre FROM maproducto WHERE ncodarticulo = '" + Txt_ncodarticulo.Text.Trim() + "';", ConexionODBC.Conexion.ObtenerConexion());
            Cmb_ncodarticulo.Text = Convert.ToString(mySqlComando.ExecuteScalar());
            ConexionODBC.Conexion.ObtenerConexion().Close();
            Cmb_Statusorden.Text = DGV_OrdenCompra[6, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            btnIrPrimero.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnIrUltimo.Enabled = true;
            btnEliminar.Enabled = true;
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

        #region Carga ComboBox Estatus
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_vstatusorden.Text = Cmb_Statusorden.Text;
        }
        #endregion

        #region Btn Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "maordencompra";
            codEliminar = Txt_ncodordencompra.Text;
            campoLlavePrimaria = "ncodordencompra";
            campoEstado = "vstatus";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            Fnc_Cargagrid();
            limpiar();
            cancelar();
        }

        #endregion

        #region Btn Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region Btn Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tablaviene = "maordencompra";
            datos = "ncodordencompra,ncodproveedor,vdescripcioncompra,ncantidad,ncostototal,ncodarticulo,vstatusorden,vstatus";
            buscar busc = new buscar(tablaviene, datos);
            busc.Show();
        }
        #endregion

        #region Btn IrPrimero
        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(DGV_OrdenCompra); 
        }
        #endregion

        #region Btn Anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(DGV_OrdenCompra);
        }
        #endregion

        #region Btn Siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(DGV_OrdenCompra);
        }
        #endregion

        #region Btn IrUltimo
        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(DGV_OrdenCompra);
        }
        #endregion

        #region Btn Salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Txt_ncodordencompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_ncostototal_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_ncantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_vdescripcioncompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
