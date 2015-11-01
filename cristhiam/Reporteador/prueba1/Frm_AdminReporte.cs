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
        }

        private void Btn_EReporte_Click(object sender, EventArgs e)
        {
            E_Reporte pReporte = new E_Reporte();
            if (!string.IsNullOrWhiteSpace(label2.Text))
            {
                pReporte.id = Convert.ToInt32(label2.Text);
                new N_Reporte().Delete_Reporte(pReporte);
            }
            else
            {
                MessageBox.Show("No hay Codigo Disponible", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            ActualizarForm();

        }

        private void Gv_Reporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = Gv_Reporte[0, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
            Txt_Nombre.Text = Gv_Reporte[1, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
        }
    }
}
