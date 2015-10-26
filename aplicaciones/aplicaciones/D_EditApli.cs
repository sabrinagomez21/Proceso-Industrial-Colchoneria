//Clase en la cual se encuentran los query para realizar una edicion o eliminacion de una aplicacion.
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
using ConexionODBC;
using System.Windows.Forms;

namespace aplicaciones
{
    class D_EditApli
    {

        public static int Actualizar(E_RegistroAp pUser)
        {
            int retorno = 0;//variable que nos entregara el resultado del query
            try
            {
                //query que nos permitira realizar la modificacion de los datos que fueron encontrados en la busqueda.
                OdbcCommand comando = new OdbcCommand(string.Format("Update MaAPLICACION set iidAplicacion='{0}', vnombreAplicacion ='{1}', vformulario= '{2}' where iidAplicacion={3}",
                pUser.Idapli, pUser.NombreAplicacion, pUser.NormbreForm,pUser.Idapli), ConexionODBC.Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();               
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Actualizar el Registro", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return retorno;//variable que retornara el resultado de nuestro query
        }


        #region Eliminar Registro
        public static int Eliminar(int pIdUser)
        {
            int iValorRetorno = 0;//Resultado de la ejecucion de nuestro query

            try
            {
                //si se desea eliminar el registro que ha sido buscado se ejecutara el query que tenemos a continuacion.
                OdbcCommand comando = new OdbcCommand(string.Format("Delete From MaAPLICACION where iidAplicacion ={0}", pIdUser), ConexionODBC.Conexion.ObtenerConexion());
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
