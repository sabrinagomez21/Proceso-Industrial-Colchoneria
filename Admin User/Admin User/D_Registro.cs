//Modulo de Registro de un nuevo usuario.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo
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
        private static OdbcCommand comprobacion;

        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Insertar Rol Usuario
        public static int AgregarUser(E_Registro eUser)
        {
            int iValorRetorno = 0;

           //realizaremos una compracion en nuestra base de datos en caso de que el usuario ya exita dentro del sistema.
            comprobacion = new OdbcCommand(
                string.Format("SELECT vusuario FROM MAUSUARIO where vusuario = '" + eUser.User + "'"),ConexionODBC.Conexion.ObtenerConexion());
            
            OdbcDataReader reader = comprobacion.ExecuteReader();

        

            if (reader.ToString() == eUser.User)
            {
                MessageBox.Show("El usuario ya existe en la base de datos", "Error de datos", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); 
            }
                     
            
            
            else { 
                //se realizara la insercion de los datos que fueron ingresados en las cajas de texto, enviando la contraseña del usuario encriptada en un metodo SHA1
                mySqlComando = new OdbcCommand(
                    string.Format("Insert into MaUSUARIO (vnombreUsuario,vapellidoUsuario,vemailUsuario,vusuario,vpassword) values ('{0}','{1}','{2}','{3}',SHA1('{4}'))",
                    eUser.NombreUser, eUser.ApellidoUser, eUser.EmailUser, eUser.User, eUser.Password),
                    ConexionODBC.Conexion.ObtenerConexion()
                );

                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }
                return iValorRetorno;// Retorno del resultado obtenido en nuestro query
            
        #endregion
        }
    }
}
