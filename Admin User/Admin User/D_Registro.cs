using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace Admin_User
{
    public class D_Registro
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Insertar Rol Usuario
        public static int AgregarUser(E_Registro eUser)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("Insert into MaUSUARIO (vnombreUsuario,vapellidoUsuario,vemailUsuario,vusuario,vpassword) values ('{0}','{1}','{2}','{3}','{4}')",
                eUser.NombreUser, eUser.ApellidoUser,eUser.EmailUser,eUser.User,eUser.Password),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion
    }
}
