//Capa donde se ejecutara el query para la insercion de una nueva aplicacion.
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
    class D_RegistroAp
    {
        private static OdbcCommand mySqlComando;
        private static OdbcCommand comprobacion;

        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Insertar Rol Usuario
        public static int AgregarApli(E_RegistroAp eUser)
        {
            int iValorRetorno = 0;

           
            //comprobacion = new OdbcCommand(
            //    string.Format("SELECT vusuario FROM MAUSUARIO where vusuario = '" + eUser.User + "'"),ConexionODBC.Conexion.ObtenerConexion());
            
            //OdbcDataReader reader = comprobacion.ExecuteReader();

        

            //if (reader.ToString() == eUser.User)
            //{
            //    MessageBox.Show("El usuario ya existe", "Error de credenciales", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); 
            //}
                     
            
            
            //else { 
               
            mySqlComando = new OdbcCommand( 
                //query que nos permitira insertar los valores que se encuentran en las cajas de texto.
                    string.Format("Insert into MAAPLICACION (vnombreAplicacion,vformulario) values ('{0}','{1}')",
                    eUser.NombreAplicacion, eUser.NormbreForm),
                    ConexionODBC.Conexion.ObtenerConexion()
                );

                iValorRetorno = mySqlComando.ExecuteNonQuery();
            
                return iValorRetorno;//variable que permitira retornar el resultado obtenido de nuestro query.
            
        #endregion
        }
    }



       
    }

