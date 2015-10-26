//Clase en la que se ejecutaran los query de la edicion y eliminacion.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo
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
            int retorno = 0;//varialbe que nos indicara si la modificacion se ha realizado con exito.
            try
            {
                //query en el cual se realizara la modificacion de los datos que fueron obtenidos en la busqueda.
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
            int iValorRetorno = 0;//Variable que nos indicara el resultado de la eliminacion.

            try
            {
                //query en el cual se realizara la eliminacion del registro buscado cuando coincida con el id del usuario.
                OdbcCommand comando = new OdbcCommand(string.Format("Delete From MaUSUARIO where iidUsuario ={0}", pIdUser), ConexionODBC.Conexion.ObtenerConexion());
                iValorRetorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Eliminar el Registro", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return iValorRetorno;//aca ya tenemos el resultado de la ejecucion de nuestro query.

        }
        #endregion


    }
}
