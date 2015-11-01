using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ConexionODBC;
using System.Data.Odbc;

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

        #region Acualizar Form
        private void ActualizarForm()
        {
            try
            {
                Gv_Reporte.DataSource = new N_Reporte().GetAll();
                Gv_Reporte.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void Frm_AdminReporte_Load(object sender, EventArgs e)
        {
            ActualizarForm();
            toolStripStatusLabel1.Text = "Usuario: " + SUsuario;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Fecha y Hora: " + DateTime.Now.ToString("G");
        }

        private void Btn_AReporte_Click(object sender, EventArgs e)
        {
            E_Reporte pReporte = new E_Reporte();
            pReporte.nom_reporte = Txt_Nombre.Text.Trim();
            pReporte.usuario = SUsuario;
            pReporte.fecha_hora = toolStripStatusLabel2.Text;
            new N_Reporte().Insert_Reporte(pReporte);
            ActualizarForm();
            Txt_Nombre.Clear();
        }

        private void Btn_EReporte_Click(object sender, EventArgs e)
        {
            E_Reporte pReporte = new E_Reporte();
            if (!string.IsNullOrWhiteSpace(Txt_Nombre.Text))
            {
                pReporte.id = Txt_Nombre.Text.Trim();
                new N_Reporte().Delete_Reporte(pReporte);
            }
            else
            {
                MessageBox.Show("No hay Codigo Disponible", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ActualizarForm();
            Txt_Nombre.Clear();

        }

        private void Gv_Reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Nombre.Text = Gv_Reporte[0, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
        }
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            DataTable dtGrid = new DataTable();
            mySqlComando = new OdbcCommand(string.Format("Select * from reportes where nom_reporte like ('" + Txt_Nombre.Text + "%') "), CAD.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(dtGrid);
            this.Gv_Reporte.DataSource = dtGrid;
            CAD.ObtenerConexion().Close();
        }
    }
}
