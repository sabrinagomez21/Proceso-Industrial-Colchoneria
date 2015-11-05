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

    #region inicia clase y variables
    public partial class Frm_InvPrincipal : Form
    {
        string producto;
        string cantidad;
        string descripcion;
        public Frm_InvPrincipal()
        {
            InitializeComponent();
        }
    #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Selecciona datos del Grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = DGV_Inventario[0, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            cantidad = DGV_Inventario[1, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            descripcion = DGV_Inventario[2, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            Frm_Edicion form = new Frm_Edicion(producto, cantidad, descripcion);
            form.Show();
            this.Close();
        }
        #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Funcion CargaGrid
        private void Fnc_CargaGrid()
        {
            try
            {
                DGV_Inventario.DataSource = new N_Inventario().GetAll(); //llamada a cargar grid
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

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region load form
        public void Frm_InvPrincipal_Load(object sender, EventArgs e)
        {
            Fnc_CargaGrid();
        }
        #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Text Buscar
        //Variables de ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dtGrid = new DataTable(); //Tabla de datos
            mySqlComando = new OdbcCommand(string.Format("Select * from inventario where producto like ('" + Txt_Buscar.Text + "%') "), CAD.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(dtGrid); //llena la Tabla dtGrid
            this.DGV_Inventario.DataSource = dtGrid; //Envia los valores al Grid
            CAD.ObtenerConexion().Close();//Termina la conexion
        }
        #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Boton cerrar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
