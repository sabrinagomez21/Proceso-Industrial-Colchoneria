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
using System.IO;


namespace prueba1
{
    #region inicio clase
    public partial class Frm_Reporte : Form
    {
        
        string sNombreReporteGrid;
        string SNombreReporte;
        public string SUsuario;
        string SFecha_Hora;
        string STiempo;
        string ruta;
        string tiporeporte;
        string puntoreporte;
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
            ruta = "C:\\Reportes";
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
        private void Fnc_Cargareporte()
        {
            // Cbox_Modulo.Text trae el nombre el reporte, tabla y modulo que se reporteara
            // string que trae la tabla para crear el reporte
            string Squery = "Select * from " + sNombreReporteGrid + "";
            //LLamada a la dll de conexion
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            MySqlCommand comd = new MySqlCommand(Squery, cConectar.SqlConexion);
            //Se limpia el datasource del reporte
            this.Rv_Reporte.LocalReport.DataSources.Clear();
            Rv_Reporte.Reset();
            //Se llama el reporte que se mostrara en el reportviewer
            Rv_Reporte.LocalReport.ReportEmbeddedResource = "prueba1." + sNombreReporteGrid + ".rdlc";
            //se crea el datatable que se llenara
            DataTable Dt_table = new DataTable();
            //Se cargan los valores en dt
            Dt_table.Load(comd.ExecuteReader());
            //Termina la conexion
            cConectar.SqlConexion.Close();
            //Se crea una nueva llamada al reporte por medio del DataSet (se utiliza solo como referencia no conexion)
            ReportDataSource RprtDS_Origen = new ReportDataSource();
            RprtDS_Origen.Name = "DataSet1";
            RprtDS_Origen.Value = Dt_table;
            //Se cargan los datos al reporte
            this.Rv_Reporte.LocalReport.DataSources.Add(RprtDS_Origen);
            //Refresca el reporte
            this.Rv_Reporte.RefreshReport();
            this.Size = new Size(1030, 401);
        }
        #endregion

        #region Crea Reporte
        private void CreaReporte()
        {
            //variable que contiene el tiempo en formato para guardar en nombre del archivo
            STiempo = DateTime.Now.ToString("yyyyMMddhhmmss");
            //String que lleva la direccion de la carpeta contenedora de los reportes 
            string SSave;
            //Condicion para crear la carpeta en disco c
            //si existe guarda los datos
            //lleva la direccion, nombre, fecha y hora, y el .pdf para crear el documento
            SSave = "C:/Reportes/" + sNombreReporteGrid + "_" + STiempo + puntoreporte + "";
            // crea el documento pdf
            byte[] Bytes = Rv_Reporte.LocalReport.Render(format: tiporeporte, deviceInfo: "");
            using (FileStream stream = new FileStream(SSave, FileMode.Create))
                {

                    stream.Write(Bytes, 0, Bytes.Length);
                }
            MessageBox.Show("Reporte Creado");
            //actualiza grid
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
            puntoreporte = ".doc";
            if (Directory.Exists(ruta))
            {
                CreaReporte();
            }
            else //si no existe
            {
                //crea carpeta para guardar.. y guarda documentos
                Directory.CreateDirectory(ruta);
                CreaReporte();
            }
            //envia el nombre del reporte
            SNombreReporte = Nreporte;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "PDF";
            puntoreporte = ".pdf";
            if (Directory.Exists(ruta))
            {
                CreaReporte();
            }
            else //si no existe
            {
                //crea carpeta para guardar.. y guarda documentos
                Directory.CreateDirectory(ruta);
                CreaReporte();
            }
            //envia el nombre del reporte
            SNombreReporte = Nreporte;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "Excel";
            puntoreporte = ".xls";
            if (Directory.Exists(ruta))
            {
                CreaReporte();
            }
            else //si no existe
            {
                //crea carpeta para guardar.. y guarda documentos
                Directory.CreateDirectory(ruta);
                CreaReporte();
            }
            //envia el nombre del reporte
            SNombreReporte = Nreporte;
        }

        #endregion

        #region Seleccion de datos del Grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //recupera el valor de la columna 0 para ser usado como referencia de nombre
            sNombreReporteGrid = Gv_Reporte[1, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
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
