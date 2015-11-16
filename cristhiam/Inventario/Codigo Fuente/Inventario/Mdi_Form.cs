using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace Inventario
{
    //Programador y Analista: Cristhiam Noe Duarte Herrera
    //Fecha de Asignación: 06/11/2015
    //Fecha de Entrega: 09/11/2015
    //Utiliza Datos de Login y Botones para llamada de Formularios
    public partial class Mdi_Form : Form
    {
        #region Variables
        int iduser;
        string privilegio;
        #endregion

        #region Inicializa y Toma Variables
        public Mdi_Form(int id)
        {
            iduser = id;
            InitializeComponent();
        }
        #endregion

        private static OdbcCommand mySqlComando;

        #region toma rol
        private void toma_rol()
        {
            //declaramos una variable string inicializandola con una cadena vacia
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT MaROLUSUARIO.vnombreRole FROM MaUSUARIO" +
                                    " INNER JOIN TrUSUARIOTOROLE ON MaUSUARIO.ncodUsuario = TrUSUARIOTOROLE.ncodUsuario" +
                                    " INNER JOIN MaROLUSUARIO ON MaROLUSUARIO.ncodRole = TrUSUARIOTOROLE.ncodRole" +
                                    " WHERE MaUSUARIO.ncodUsuario ='" + iduser + "'"),
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
                        privilegio = Convert.ToString(mySqlDLector["vnombreRole"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
        }
        #endregion

        #region Form Load y Condicion Usuario
        private void Mdi_Form_Load(object sender, EventArgs e)
        {
            toma_rol();
            if(privilegio=="Superusuario" || privilegio == "Administrador")
            {
                seguridadToolStripMenuItem.Visible = true;
            }
        }
        #endregion

        #region Btn Form Inventario
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_InvPrincipal form = new Frm_InvPrincipal(iduser,privilegio);
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        #region Btn Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Logueo Login = new Frm_Logueo();
            Login.Show();
        }
        #endregion

        #region Btn Form Registro
        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DllSeguridad.frmRegistro registro = new DllSeguridad.frmRegistro();
            registro.Show();
        }
        #endregion

        #region Btn Form Roles
        private void manejoDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DllSeguridad.frmManejoRol registro = new DllSeguridad.frmManejoRol();
            registro.Show();
        }
        #endregion

        #region Btn Orden de Compra
        private void productoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OrdenDeCompra form = new Frm_OrdenDeCompra(iduser, privilegio);
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        #region Btn Bodega
        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Bodega form = new Frm_Bodega(iduser, privilegio);
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        #region Btn Manual de usuario
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Manual de Usuario Inventario.pdf");
            Process.Start(pdfPath);
        }
        #endregion

        #region Btn Manual Reporteador
        private void manualDeUsuarioReporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Manual de Uso Reporteador.pdf");
            Process.Start(pdfPath);
        }
#endregion

        private void mantenimientoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Producto form = new Frm_Producto(iduser, privilegio);
            form.MdiParent = this;
            form.Show();
        }
    }
}
