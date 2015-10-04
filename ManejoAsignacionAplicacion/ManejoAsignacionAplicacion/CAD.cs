using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

using System.Data.Odbc;


namespace ManejoAsignacionAplicacion
{
    #region Conexión A Datos - CAD
    public class CAD
    {

        
            private static OdbcConnection mySqlConeccion;

            public static OdbcConnection ObtenerConexion()
            {
                mySqlConeccion = new OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};Server=localhost;Database=Colchoneria;User=root;Password=;Option=3;");
                mySqlConeccion.Open();

                return mySqlConeccion;
            }

    }
        #endregion
}
