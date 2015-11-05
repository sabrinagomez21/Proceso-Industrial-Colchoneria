using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using Microsoft.Reporting.WinForms;

namespace prueba1
{
    public partial class Frm_AdminReporte : Form
    {
        string SUsuario;
        public Frm_AdminReporte(string usuario)
        {
            SUsuario = usuario;
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AdminReporte_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
            toolStripStatusLabel1.Text = "Usuario: " + SUsuario;

        }

        #region Cargar Grid
        private void Fnc_Cargagrid()
        {
            //conexion por dll
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            //query de llamada de datos al grid
            cConectar.sqlData = new MySqlDataAdapter("Select nom_reporte, usuario, fecha_hora from reportes", cConectar.SqlConexion);
            DataTable DT_Table = new DataTable();
            //Carga el grid
            cConectar.sqlData.Fill(DT_Table);
            Gv_Reporte.DataSource = DT_Table;
            //Se renombran los headers de las columnas
            Gv_Reporte.Columns[0].HeaderText = "Reporte";
            Gv_Reporte.Columns[1].HeaderText = "Usuario";
            Gv_Reporte.Columns[2].HeaderText = "Fecha de Creacion";
            //Termina la conexion
            cConectar.SqlConexion.Close();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Fecha y Hora: " + DateTime.Now.ToString("G");
        }

        private void Btn_AReporte_Click(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("INSERT INTO reportes (nom_reporte, usuario, fecha_hora) VALUES ('" + Txt_Nombre.Text + "','" + SUsuario + "','" + toolStripStatusLabel2.Text + "');", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            Fnc_Cargagrid();
            Txt_Nombre.Clear();
            MessageBox.Show("Reporte Ingresado");
        }

        private void Btn_EReporte_Click(object sender, EventArgs e)
        {
            //llamada a conexion dll
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            //query de eliminacion segun el nombre del archivo o reporte
            cConectar.sqlCmd = new MySqlCommand("DELETE FROM reportes WHERE nom_reporte='" + Txt_Nombre.Text + "'", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            Fnc_Cargagrid();
            Txt_Nombre.Clear();
            //confirmacion de eliminacion
            MessageBox.Show("Reporte Eliminado");
        }

        private void Gv_Reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Nombre.Text = Gv_Reporte[0, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
