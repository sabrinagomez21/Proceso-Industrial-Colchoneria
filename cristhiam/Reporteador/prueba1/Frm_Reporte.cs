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
using System.IO;
using ConexionODBC;
using System.Data.Odbc;


namespace prueba1
{
    #region inicio clase
    public partial class Frm_Reporte : Form
    {
        
        string sNombreReporteGrid;
        public string SUsuario;
        string SFecha_Hora;
        string filter;
        string title;
        string tiporeporte;
        string Nreporte;

        #endregion
        //public Frm_Reporte(string reporte, int modulo, string usuario, int form)

        #region Variables
        //public Frm_Reporte()
        //public Frm_Reporte(string reporte, string usuario)
        public Frm_Reporte()
        {
            InitializeComponent();
            //Nreporte = reporte;
            //SUsuario = usuario;
        }
        #endregion 

        #region Carga de Form
        public void Form1_Load(object sender, EventArgs e)
        {
            Nreporte = "productos";
            SUsuario = "criss";
            
            if(SUsuario=="Administrador")
            {
                Btn_AReporte.Visible = false;
            }
            else
            {
                Btn_AReporte.Visible = true;
            }

            SFecha_Hora = DateTime.Now.ToString("G");
            //ruta para guardar los reportes
            ActualizarForm();
            panel1.Visible = true;
            toolStripStatusLabel1.Text = "Usuario: "+SUsuario;
            

        }
        #endregion

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

        #region Carga Reporte
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        private void Fnc_Cargareporte()
        {
            try
            {
                DataTable dtReporte = new DataTable();
                mySqlComando = new OdbcCommand(string.Format("SELECT * FROM " + sNombreReporteGrid + ""), CAD.ObtenerConexion());
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtReporte);
                CAD.ObtenerConexion().Close();
                //Se limpia el datasource del reporte
                this.Rv_Reporte.LocalReport.DataSources.Clear();
                Rv_Reporte.Reset();
                //Se llama el reporte que se mostrara en el reportviewer
                Rv_Reporte.LocalReport.ReportEmbeddedResource = "prueba1." + sNombreReporteGrid + ".rdlc";
                ReportDataSource RprtDS_Origen = new ReportDataSource();
                RprtDS_Origen.Name = "DataSet1";
                RprtDS_Origen.Value = dtReporte;
                //Se cargan los datos al reporte
                this.Rv_Reporte.LocalReport.DataSources.Add(RprtDS_Origen);
                //Refresca el reporte
                this.Rv_Reporte.RefreshReport();
                this.Size = new Size(1030, 401);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("El Reporte No Existe, Contacte con el Administrador", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        #endregion

        #region Crea Reporte
        private void CreaReporte()
        {
             SaveFileDialog saveFileDialog1;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = title;            
            saveFileDialog1.Filter = filter;
 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = saveFileDialog1.FileName;
                byte[] Bytes = Rv_Reporte.LocalReport.Render(format: tiporeporte, deviceInfo: "");
                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {

                    stream.Write(Bytes, 0, Bytes.Length);
                }
            }
            MessageBox.Show("Reporte Creado");
            this.Size = new Size(390, 401);
            ActualizarForm();
        }
        #endregion

        #region timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Fecha y Hora: "+DateTime.Now.ToString("G");
        }

        #endregion

        #region Botones
        private void Btn_Word_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "Word";
            title = "Guardar Reporte Word";
            filter = "Word |*.doc";
            CreaReporte();
           
            }


        private void button2_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "PDF";
            title = "Guardar Reporte PDF";
            filter = "PDF |*.pdf";
                CreaReporte();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "Excel";
            title = "Guardar Reporte Excel";
            filter = "Excel |*.xls";
                CreaReporte();
        }
        
        #endregion

        #region Seleccion de datos del Grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //recupera el valor de la columna 0 para ser usado como referencia de nombre
            sNombreReporteGrid = Gv_Reporte[0, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
            Fnc_Cargareporte();
        }
        #endregion

        private void Btn_AReporte_Click(object sender, EventArgs e)
        {
            Frm_AdminReporte FrmAdmin = new Frm_AdminReporte(SUsuario);
            FrmAdmin.Show();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            ActualizarForm();
        }






    }
}
