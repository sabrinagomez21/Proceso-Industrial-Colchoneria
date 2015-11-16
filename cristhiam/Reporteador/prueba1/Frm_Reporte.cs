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


namespace prueba1{

    //Autor: Ricardo Von-Raynts
    //Fecha: 15/10/15
    #region Variables
    public partial class Frm_Reporte : Form
    {
        //Variables
        string sNombreReporteGrid;
        string filter;
        string title;
        string tiporeporte;
        string usuario;
        string vnomreporte;
        string dfechareporte;
        int ncodaplicacion;
        int ncodmodulo;
        public int ncodusuario;

        #endregion

        //Autor: David Barrios
        //Fecha: 30/10/15
        #region Cambio DLL a NO DLL
        //public Frm_Reporte()
        //public Frm_Reporte(string reporte, int aplicacion, int modulo, int usuario)
        public Frm_Reporte()
        {
            InitializeComponent();
            /*vnomreporte = reporte;
            ncodaplicacion = aplicacion;
            ncodmodulo = modulo;
            ncodusuario = usuario;*/
            
        }
        #endregion 

        //Autor: Cristhiam Duarte
        //Fecha:19/10/15
        #region Carga de Form
        public void Form1_Load(object sender, EventArgs e)
        {
            //Variables para uso de proyecto no DLL
            vnomreporte = "productos";
            ncodaplicacion = 1;
            ncodmodulo = 1;
            ncodusuario = 1;
            //Condicion para mostrar boton de Administrar Reportes
            if(ncodusuario == 1){
                Btn_AReporte.Visible = true;
                Lbl_Admin.Visible = true;
            }else{Btn_AReporte.Visible = false;}
            Fnc_CargaUsuario();
            dfechareporte = DateTime.Now.ToString("G"); //Fecha y hora en ToolStrip
            toolStripStatusLabel1.Text = "Usuario: "+usuario; //Usuario en ToolStrip
            Fnc_CargaGrid(); //llamada de datos Grid
        }
        #endregion

        //Autor: Dennys Choy
        //Fecha: 20/10/15
        #region Funcion CargaGrid
        private void Fnc_CargaGrid()
        {
            try
            {
                Gv_Reporte.DataSource = new N_Reporte().GetAll(); //llamada a cargar grid
                //Headers de la Columnas
                Gv_Reporte.Columns[0].HeaderText = "Reporte";
                Gv_Reporte.Columns[1].HeaderText = "Fecha de Creacion";
                Gv_Reporte.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion


        //Autor: Cristhiam Duarte
        //Fecha:1/11/15
        #region Consulta Usuario
        private void Fnc_CargaUsuario()
        {
            try { 
            DataTable dtUsuario = new DataTable(); //Tabla de Datos
            //Query
            mySqlComando = new OdbcCommand(string.Format("SELECT vusuario FROM MaUsuario where ncodusuario = " + ncodusuario + ""), CAD.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            object objeto = mySqlComando.ExecuteScalar();
            usuario = Convert.ToString(objeto);
            CAD.ObtenerConexion().Close(); //Termina Conexion
            }
            catch (Exception Ex)
            {
                //Muestra Error si el Reporte no Existe Fisicamente
                MessageBox.Show("Error al Referir Usuario", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion


        //Autor: Cristhiam Duarte
        //Fecha:1/11/15
        #region Consulta Carga Rol
        private void Fnc_CargaRol()
        {
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT MaROLUSUARIO.vnombreRole FROM MaUSUARIO" +
                                    " INNER JOIN TrUSUARIOTOROLE ON MaUSUARIO.ncodUsuario = TrUSUARIOTOROLE.ncodUsuario" +
                                    " INNER JOIN MaROLUSUARIO ON MaROLUSUARIO.ncodRole = TrUSUARIOTOROLE.ncodRole" +
                                    " WHERE MaUSUARIO.ncodUsuario ='" + ncodusuario + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        Name = Convert.ToString(mySqlDLector["vnombreRole"]);
                    }
                }
            }
            catch (Exception Ex)
            {
                //Muestra Error si el Reporte no Existe Fisicamente
                MessageBox.Show("Error al Referir Usuario", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        //Autor: Dennys Choy
        //Fecha: 20/10/15
        #region Carga Reporte
        //Variables de ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        private void Fnc_Cargareporte()
        {
            try{
                DataTable dtReporte = new DataTable(); //Tabla de Datos
                //Query
                mySqlComando = new OdbcCommand(string.Format("SELECT * FROM " + sNombreReporteGrid + ""), CAD.ObtenerConexion());
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtReporte); //LLena la Tabla de Datos
                CAD.ObtenerConexion().Close(); //Termina Conexion
                this.Rv_Reporte.LocalReport.DataSources.Clear();//Se limpia el datasource del reporte
                Rv_Reporte.Reset();
                //Se llama el reporte que se mostrara en el reportviewer
                Rv_Reporte.LocalReport.ReportPath = "..\\..\\"+ sNombreReporteGrid +".rdlc";
                //Rv_Reporte.LocalReport.ReportEmbeddedResource = ""+ nombreSolucion + "" + sNombreReporteGrid + ".rdlc";
                ReportDataSource RprtDS_Origen = new ReportDataSource(); //Origen de Datos
                RprtDS_Origen.Name = "DataSet1"; //Unicamente nombre no utiliza DATASET en el proyecto
                RprtDS_Origen.Value = dtReporte; //Valores del Reporte
                this.Rv_Reporte.LocalReport.DataSources.Add(RprtDS_Origen);//Se cargan los datos al reporte
                this.Rv_Reporte.RefreshReport();//Refresca el reporte
                this.Size = new Size(1118, 471);//Cambia Tamaño del Form para Mostrar Reporte
            }catch (Exception Ex){
                //Muestra Error si el Reporte no Existe Fisicamente
                MessageBox.Show("El Reporte No Existe, Contacte con el Administrador", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        //Autor: Enrique Arredondo
        //Fecha 21/10/15
        #region Crea Reporte
        private void Fnc_CreaReporte()
        {
            SaveFileDialog saveFileDialog1; //Cuadro de Dialogo para Guardar
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = title; //Trae el nombre del Guardar como (word,pdf,excel)           
            saveFileDialog1.Filter = filter; //lleva el punto del documento (.doc, .pdf, .xls)
 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK){ //Si se guarda un nombre
                string ruta = saveFileDialog1.FileName; // Direccion donde se guardara
                byte[] Bytes = Rv_Reporte.LocalReport.Render(format: tiporeporte, deviceInfo: "");
                using (FileStream stream = new FileStream(ruta, FileMode.Create)){ //crea el guardar
                    MessageBox.Show("Reporte Creado","Creacion De Reporte");//mensaje de creacion de reporte
                    stream.Write(Bytes, 0, Bytes.Length);}
                this.Size = new Size(464, 471);//Cambia el valor del Form a pequeño nuevamente
            }
            else
            {
                MessageBox.Show("Reporte Cancelado", "Creacion De Reporte");
            }
            Fnc_CargaGrid();//Actualiza el Grid
        }
        #endregion

        //Autor: Enrique Arredondo
        //Fecha:30/10/15
        #region timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mantiene el Tiempo actualizado para ver la variacion de segundos
            toolStripStatusLabel2.Text = "Fecha y Hora: "+DateTime.Now.ToString("G");
        }

        #endregion

        //Autor: David Barrios
        //Fecha: 25/10/15
        #region Botones
        private void Btn_Word_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "Word"; //Tipo del Reporte a Guardar
            title = "Guardar Reporte Word"; //Titulo del dialogo de guardar
            filter = "Word |*.doc"; //Extencion del Archivo
            Fnc_CreaReporte();//LLamada a Funcion para crear Reporte
           
            }


        private void Btn_Pdf_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "PDF";
            title = "Guardar Reporte PDF";
            filter = "PDF |*.pdf";
            Fnc_CreaReporte();
        }

        private void Btn_Excel_Click_1(object sender, EventArgs e)
        {
            tiporeporte = "Excel";
            title = "Guardar Reporte Excel";
            filter = "Excel |*.xls";
            Fnc_CreaReporte();
        }
        
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 20/10/15
        #region Seleccion de datos del Grid
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //recupera el valor de la columna 0 para ser usado como referencia de nombre
            sNombreReporteGrid = Gv_Reporte[0, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
            Fnc_Cargareporte(); //llama a funcion para Cargar el Reporte con SNombreReporteGrid como variable
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Llamada a Formulario Administrador de Reportes
        private void Btn_AReporte_Click(object sender, EventArgs e)
        {   //LLamada a Formulario Administrador de Reportes
            Frm_AdminReporte FrmAdmin = new Frm_AdminReporte(usuario, ncodaplicacion,ncodmodulo,ncodusuario);
            FrmAdmin.Show();
        }
        #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha: 23/10/15
        #region Boton Actualizar
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Fnc_CargaGrid();//Actualiza el Grid
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 02/11/15
        #region Boton Salir
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }}
