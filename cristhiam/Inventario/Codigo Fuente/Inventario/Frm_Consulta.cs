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
    //Programador y Analista: Jose David Yool Barrios
    //Fecha de Asignación: 06/11/2015
    //Fecha de Entrega: 11/11/2015
    //Realiza Consulta de Existentes y cambios
    public partial class Frm_Consulta : Form
    {
        #region Variables e Inicializa
        int total;
        public Frm_Consulta()
        {
            InitializeComponent();
        }
        #endregion

        #region Form load
        private void Frm_Consulta_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region Funcion para cargar grid

        public void Fnc_Cargagrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mamaterial", "SELECT vnombre, ncantidad, nconsulta from mamaterial WHERE vestatus='ACTIVO'", "consulta", dataGridView1);
        }
        #endregion

        #region Cellcontent
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            total = Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox2.Text);
            textBox1.Text = Convert.ToString(total);
        }
        #endregion

        #region Actualiza Valores Consulta
        private static OdbcCommand mysqlComando;
        private void actualizar_Click(object sender, EventArgs e)
        {
            mysqlComando = new OdbcCommand(string.Format("UPDATE mamaterial set nconsulta = ncantidad;"), ConexionODBC.Conexion.ObtenerConexion());
            mysqlComando.ExecuteNonQuery();
            ConexionODBC.Conexion.ObtenerConexion().Close();
            MessageBox.Show("Consulta Actualizada");
            Fnc_Cargagrid();
        }
        #endregion

        #region Btn Salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
