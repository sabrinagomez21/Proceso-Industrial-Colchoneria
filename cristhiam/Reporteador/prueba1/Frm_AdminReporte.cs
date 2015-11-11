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

//Autor: Cristhiam Duarte
//Fecha: 30/10/15 Todo el Form
namespace prueba1{

    #region Inicio de Class y Carga de Variable Usuario
    public partial class Frm_AdminReporte : Form
    {
        string vnomreporte;
        string dfechareporte;
        int ncodaplicacion;
        int ncodmodulo;
        public int ncodusuario;
        string username;
        public Frm_AdminReporte(string user, int aplicacion, int modulo, int usuario)
        {
            ncodaplicacion = aplicacion;
            ncodmodulo = modulo;
            ncodusuario = usuario;
            username = user;
            InitializeComponent();
            
        }
    #endregion

        #region Cierra Formulario
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funcion CargaGrid
        private void Fnc_CargaGrid()
        {
            try{
                Gv_Reporte.DataSource = new N_Reporte().GetAll(); //Carga todos los datos del grid
                Gv_Reporte.Columns[0].HeaderText = "Reporte";
                Gv_Reporte.Columns[1].HeaderText = "Fecha de Creacion";
                Gv_Reporte.Refresh();
            }catch (Exception Ex){MessageBox.Show(Ex.Message);}
        }
        #endregion

        #region Load Form
        private void Frm_AdminReporte_Load(object sender, EventArgs e)
        {
            Fnc_CargaGrid(); //Carga Grid
            toolStripStatusLabel1.Text = "Usuario: " + username; //Nombre de Usuario en ToolStrip
        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {   //Fecha y hora en toolstrip con timer para actualizacion
            toolStripStatusLabel2.Text = "Fecha y Hora: " + DateTime.Now.ToString("G");
        }
        #endregion

        #region Agregar Reporte
        private void Btn_AReporte_Click(object sender, EventArgs e)
        {
            E_Reporte pReporte = new E_Reporte(); //constructor llamada de variables
            pReporte.vnomreporte = Txt_Nombre.Text.Trim(); //trim envia el texto sin espacios o basura
            pReporte.ncodusuario = ncodusuario;
            pReporte.ncodaplicacion = ncodaplicacion;
            pReporte.ncodmodulo = ncodmodulo;
            pReporte.dfechareporte = DateTime.Now.ToString("G");
            new N_Reporte().Insert_Reporte(pReporte); //envia las variables a capa para ingreso
            Fnc_CargaGrid(); //Carga variables al Grid (actualiza el Grid)
            Txt_Nombre.Clear(); //limpia el textbox
        }
        #endregion

        #region Elimina Reporte
        private void Btn_EReporte_Click(object sender, EventArgs e)
        {
            try { //Pregunta de Seguridad
            if (MessageBox.Show("¿Está seguro de Eliminar el Reporte? Nombre del Reporte: " + Txt_Nombre.Text, "Eliminar Reporte", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            E_Reporte pReporte = new E_Reporte(); //Constructor
            if (!string.IsNullOrWhiteSpace(Txt_Nombre.Text)){ //Si el Textbox no esta en blanco
                pReporte.vnomreporte = Txt_Nombre.Text.Trim(); //variable sin basura
                new N_Reporte().Delete_Reporte(pReporte); //llamada a eliminacion
            }else{
                MessageBox.Show("No Ingreso Nombre del Reporte", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Fnc_CargaGrid();// Actualiza el grid
            Txt_Nombre.Clear();//limpia el textbox
            }else{
            Fnc_CargaGrid();// Actualiza el grid
            Txt_Nombre.Clear();//limpia el textbox
            }}catch{MessageBox.Show("Problema en BD");} //Catch
        }
        #endregion

        #region Datos seleccionados del Grid
        private void Gv_Reporte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Nombre.Text = Gv_Reporte[0, Gv_Reporte.CurrentCell.RowIndex].Value.ToString();
        }
        #endregion

        #region Buscador de TextBox Nombre
        //Variables de ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            DataTable dtGrid = new DataTable(); //Tabla de datos
            mySqlComando = new OdbcCommand(string.Format("Select * from TrREPORTE where vnomreporte like ('" + Txt_Nombre.Text + "%') "), CAD.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(dtGrid); //llena la Tabla dtGrid
            this.Gv_Reporte.DataSource = dtGrid; //Envia los valores al Grid
            CAD.ObtenerConexion().Close();//Termina la conexion
        }
        #endregion
    }}
