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
            cnegocio.funconsultarRegistrosCombo("ncodarticulo", "SELECT ncodarticulo,vnombre from maproducto", "vnombre", comboBox2);
        }
        #endregion

        #region cargaboxProveedor();
        public void Fnc_CargaboxProveedor()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodproveedor", "SELECT ncodproveedor,vnombre from maproveedor", "vnombre", comboBox1);
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
            Txt_Status.Text = comboBox3.Text;
            Txt_Status2.Text = "ACTIVO";
            TextBox[] aDatos = { textBox1, Txt_Codproveedor,textBox3,textBox4,textBox5,Txt_Codarticulo,Txt_Status,Txt_Status2 };
            string sTabla = "maordencompra";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();
            limpiar();
        }
        #endregion

        #region Carga ComboBox Proveedor
        private static OdbcCommand mySqlComando;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand("SELECT ncodproveedor FROM maproveedor WHERE vnombre = '" + comboBox1.Text.Trim() + "';", CAD.obtenerConexion());
            OdbcDataReader MyReader3;
            MyReader3 = mySqlComando.ExecuteReader();
            while (MyReader3.Read())
            {
                Txt_Codproveedor.Text = MyReader3.GetInt32(0).ToString();
            }
            CAD.obtenerConexion().Close();
        }
        #endregion

        #region Carga ComboBox Producto
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand("SELECT ncodarticulo FROM maproducto WHERE vnombre = '" + comboBox2.Text.Trim() + "';", CAD.obtenerConexion());
            Txt_Codarticulo.Text = Convert.ToString( mySqlComando.ExecuteScalar());
            CAD.obtenerConexion().Close();
        }
        #endregion

        #region Btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { Txt_Codproveedor, textBox3, textBox4, textBox5, Txt_Codarticulo, Txt_Status };
            clasnegocio cn = new clasnegocio();
            string tabla = "maordencompra";
            Boolean permiso = true;
            string codigo =  textBox1.Text;
            cn.EditarObjetos("maordencompra", permiso, arraytexto, codigo, "ncodordencompra");
            MessageBox.Show("Registro Actualizado");
            Fnc_Cargagrid();
            limpiar();
        }
        #endregion

        #region Limpiar
        public void limpiar()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            Txt_Codarticulo.Clear();
            Txt_Codproveedor.Clear();
            Txt_Status.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        #endregion

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_Codarticulo, false);
            cnegocio.funactivarDesactivarTextbox(Txt_Codproveedor, false);
            cnegocio.funactivarDesactivarTextbox(Txt_Status, false);
            cnegocio.funactivarDesactivarTextbox(textBox1, false);
            cnegocio.funactivarDesactivarTextbox(textBox3, false);
            cnegocio.funactivarDesactivarTextbox(textBox4, false);
            cnegocio.funactivarDesactivarTextbox(textBox5, false);
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
        #endregion

        #region Btn Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true; 
            cnegocio.funactivarDesactivarTextbox(Txt_Codarticulo, true);
            cnegocio.funactivarDesactivarTextbox(Txt_Codproveedor, true);
            cnegocio.funactivarDesactivarTextbox(Txt_Status, true);
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
            cnegocio.funactivarDesactivarTextbox(textBox3, true);
            cnegocio.funactivarDesactivarTextbox(textBox4, true);
            cnegocio.funactivarDesactivarTextbox(textBox5, true);
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        #endregion

        #region CellContent
        private void DGV_OrdenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = DGV_OrdenCompra[0, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_Codproveedor.Text = DGV_OrdenCompra[1, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            mySqlComando = new OdbcCommand("SELECT vnombre FROM maproveedor WHERE ncodproveedor = '" + Txt_Codproveedor.Text.Trim() + "';", CAD.obtenerConexion());
            comboBox1.Text = Convert.ToString(mySqlComando.ExecuteScalar());
            CAD.obtenerConexion().Close();
            textBox3.Text = DGV_OrdenCompra[2, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            textBox4.Text = DGV_OrdenCompra[3, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            textBox5.Text = DGV_OrdenCompra[4, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            Txt_Codarticulo.Text = DGV_OrdenCompra[5, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
            mySqlComando = new OdbcCommand("SELECT vnombre FROM maproducto WHERE ncodarticulo = '" + Txt_Codarticulo.Text.Trim() + "';", CAD.obtenerConexion());
            comboBox2.Text = Convert.ToString(mySqlComando.ExecuteScalar());
            CAD.obtenerConexion().Close();
            comboBox3.Text = DGV_OrdenCompra[6, DGV_OrdenCompra.CurrentCell.RowIndex].Value.ToString();
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
            Txt_Status.Text = comboBox3.Text;
        }
        #endregion

        #region Btn Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "maordencompra";
            codEliminar = textBox1.Text;
            campoLlavePrimaria = "ncodordencompra";
            campoEstado = "vstatus";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            Fnc_Cargagrid();
            limpiar();
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

    }
}
