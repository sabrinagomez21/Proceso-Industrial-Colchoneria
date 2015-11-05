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
    public partial class Frm_MateriaPrima : Form
    {
        public Frm_MateriaPrima()
        {
            InitializeComponent();
        }

        private void Frm_MateriaPrima_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
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

        private void Txt_Producto_TextChanged(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from inventario where producto like ('" + Txt_Producto.Text + "%') ", cConectar.SqlConexion);
            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.DGV_Inventario.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("INSERT INTO inventario (producto, cantidad, descripcion) VALUES ('" + Txt_Producto.Text + "','" + Txt_Cantidad.Text + "','" + Txt_Descripcion.Text + "');", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            Fnc_Cargagrid();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            Txt_Producto.Clear();
            Txt_Cantidad.Clear();
            Txt_Descripcion.Clear();
        }
    }

}
