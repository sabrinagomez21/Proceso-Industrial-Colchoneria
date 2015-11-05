using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;


namespace Inventario{
    #region inicio de clase
    public partial class Frm_MateriaPrima : Form
    {
        public Frm_MateriaPrima()
        {
            InitializeComponent();
        }
    #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha:29/10/15
        #region load form
        private void Frm_MateriaPrima_Load(object sender, EventArgs e)
        {
            Fnc_CargaGrid();
        }
        #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Funcion CargaGrid
        private void Fnc_CargaGrid()
        {
            try
            {
                DGV_Inventario.DataSource = new N_Inventario().GetMateria(); //llamada a cargar grid
                //Headers de la Columnas
                DGV_Inventario.Columns[0].HeaderText = "Producto";
                DGV_Inventario.Columns[1].HeaderText = "Cantidad";
                DGV_Inventario.Columns[2].HeaderText = "Descripcion";
                DGV_Inventario.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha: 29/10/15
        #region Busca Text box
        //Variables de ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        private void Txt_Producto_TextChanged(object sender, EventArgs e)
        {
            DataTable dtGrid = new DataTable(); //Tabla de datos
            mySqlComando = new OdbcCommand(string.Format("Select * from inventario where producto like ('" + Txt_Producto.Text + "%') "), CAD.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(dtGrid); //llena la Tabla dtGrid
            this.DGV_Inventario.DataSource = dtGrid; //Envia los valores al Grid
            CAD.ObtenerConexion().Close();//Termina la conexion
        }
        #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha: 30/10/15
        #region Boton Inserta
        private void button1_Click(object sender, EventArgs e)
        {
            E_Inventario pInserta = new E_Inventario(); //constructor llamada de variables
            pInserta.producto = Txt_Producto.Text;
            pInserta.cantidad = Txt_Cantidad.Text;
            pInserta.descripcion = Txt_Descripcion.Text;
            new N_Inventario().Insert_Materia(pInserta); //envia las variables a capa para ingreso
            limpiar();
        }
        #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha: 31/10/15
        #region boton salir
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha: 31/10/15
        #region Limpiar
        public void limpiar()
        {
            Txt_Producto.Clear();
            Txt_Cantidad.Clear();
            Txt_Descripcion.Clear();
        }
        #endregion
    }}
