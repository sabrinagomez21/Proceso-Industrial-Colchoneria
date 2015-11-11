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
    public partial class Frm_OrdenDeCompra : Form
    {
        int valorBoxproveedor;
        int valorBoxarticulo;
        public Frm_OrdenDeCompra()
        {
            InitializeComponent();
        }

        private void Frm_OrdenDeCompra_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
            Fnc_CargaboxProveedor();
            Fnc_CargaboxArticulo();
        }
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
            cnegocio.funconsultarRegistros("maordencompra", "SELECT * from maordencompra", "consulta", DGV_OrdenCompra);
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Txt_Status.Text = comboBox3.Text;

            TextBox[] aDatos = { Txt_Codproveedor,textBox3,textBox4,textBox5,Txt_Codarticulo,Txt_Status };
            string sTabla = "maordencompra";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();

        }

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlComando = new OdbcCommand("SELECT ncodarticulo FROM maproducto WHERE vnombre = '" + comboBox2.Text.Trim() + "';", CAD.obtenerConexion());
            OdbcDataReader MyReader3;
            MyReader3 = mySqlComando.ExecuteReader();
            while (MyReader3.Read())
            {
                Txt_Codarticulo.Text = MyReader3.GetInt32(0).ToString();
            }

            CAD.obtenerConexion().Close();
        }

    }
}
