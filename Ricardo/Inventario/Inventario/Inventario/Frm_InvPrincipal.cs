using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Inventario
{
    public partial class Frm_InvPrincipal : Form
    {
        string producto;
        string cantidad;
        string descripcion;
        string id;
        public Frm_InvPrincipal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = producto = DGV_Inventario[0, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            producto = DGV_Inventario[1, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            cantidad = DGV_Inventario[2, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            descripcion = DGV_Inventario[3, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            Frm_Edicion form = new Frm_Edicion(id, producto, cantidad, descripcion);

            form.Show();
            this.Close();

        }
        #region Funcion para cargar grid
        public void Fnc_Cargagrid()
        {
            //conexion por dll
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            //query de llamada de datos al grid
            cConectar.sqlData = new MySqlDataAdapter("Select id, producto, cantidad, descripcion from inventario", cConectar.SqlConexion);
            DataTable DT_Table = new DataTable();
            //Carga el grid
            cConectar.sqlData.Fill(DT_Table);
            DGV_Inventario.DataSource = DT_Table;
            //Se renombran los headers de las columnas
            DGV_Inventario.Columns[0].HeaderText = "Id";
            DGV_Inventario.Columns[1].HeaderText = "Producto";
            DGV_Inventario.Columns[2].HeaderText = "Cantidad";
            DGV_Inventario.Columns[3].HeaderText = "Descripcion";
            //Termina la conexion
            cConectar.SqlConexion.Close();
        }
        #endregion

        public void Frm_InvPrincipal_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from inventario where producto like ('" + Txt_Buscar.Text + "%') ", cConectar.SqlConexion);

            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.DGV_Inventario.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
