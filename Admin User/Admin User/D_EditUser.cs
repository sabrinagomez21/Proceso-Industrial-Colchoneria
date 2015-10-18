using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Admin_User
{
    public class D_EditUser
    {
        public static int Actualizar(E_Registro pUser)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Update MaUSUARIO set vnombreUsuario='{0}',vapellidoUsuario ='{1}', vemailUsuario = '{2}', vusuario = '{3}', vpassword='{4}' where iidUsuario={5}",
                pUser.NombreUser,pUser.ApellidoUser,pUser.EmailUser,pUser.User,pUser.Password, pUser.IdUser), ConexionODBC.Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Actualizar el Registro", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return retorno;
        }


        #region Eliminar Registro
        public static int Eliminar(int pIdUser)
        {
            int iValorRetorno = 0;

            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Delete From MaUSUARIO where iidUsuario ={0}", pIdUser), ConexionODBC.Conexion.ObtenerConexion());
                iValorRetorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Eliminar el Registro", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return iValorRetorno;

        }
        #endregion


    }
}
