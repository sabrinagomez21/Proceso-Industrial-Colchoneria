using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;


namespace Manejo_Rol
{
    #region Conexión A Datos - CAD
    public class CAD
    {

        
            private static OdbcConnection mySqlConeccion;

            public static OdbcConnection ObtenerConexion()
            {
                mySqlConeccion = new OdbcConnection("DSN=Colchoneria;UID=root;Pwd=;");
                mySqlConeccion.Open();

                return mySqlConeccion;
            }

    }
        #endregion
}
