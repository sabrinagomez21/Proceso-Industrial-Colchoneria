using System;
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

namespace CuentasPorCobrar
{
    public partial class Mdi_Form : Form
    {
        int iduser;
        string privilegio;
        public Mdi_Form(int id)
        {
            iduser = id;
            InitializeComponent();
        }

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

        private void Mdi_Form_Load(object sender, EventArgs e)
        {
            toma_rol();
            if(privilegio=="Superusuario" || privilegio == "Administrador")
            {
                seguridadToolStripMenuItem.Visible = true;
            }
        }

        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalCxC form = new frmPrincipalCxC(iduser,privilegio);
            form.MdiParent = this;
            form.Show();

            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmantenimientoProveedores form = new frmmantenimientoProveedores(iduser, privilegio);
            form.MdiParent = this;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Logueo Login = new Frm_Logueo();
            Login.Show();
        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DllSeguridad.frmRegistro registro = new DllSeguridad.frmRegistro();
            registro.Show();
        }

        private void manejoDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DllSeguridad.frmManejoRol registro = new DllSeguridad.frmManejoRol();
            registro.Show();
            
        }

        private void productoTerminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTransaccion form = new MantenimientoTransaccion(iduser,privilegio);
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoDeDocsDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocumentodepago form = new frmDocumentodepago(iduser,privilegio);
            form.MdiParent = this;
            form.Show();
        }

        private void mantenimientoDeTipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDoc form = new frmTipoDoc(iduser,privilegio);
            form.MdiParent = this;
            form.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //proc.StartInfo.FileName = "C:\\Program Files\\Campeonato\\Manual de Usuario.pdf";
            proc.StartInfo.FileName = "C:\\Manual de usuario - Documentos por pagar\\ManualUsuario-CuentasPorPagar.pdf";
            proc.Start();
            proc.Close();
        }
    }
}
