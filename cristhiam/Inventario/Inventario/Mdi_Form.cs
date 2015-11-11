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

namespace Inventario
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
            

            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_InvPrincipal form = new Frm_InvPrincipal(iduser,privilegio);
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
            Frm_OrdenDeCompra form = new Frm_OrdenDeCompra();
            form.MdiParent = this;
            form.Show();
        }
    }
}
