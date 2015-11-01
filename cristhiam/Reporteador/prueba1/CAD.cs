using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace prueba1
{
    #region Conexión A Datos - CAD
    public class CAD
    {
        private static OdbcConnection conBD;
        public static OdbcConnection ObtenerConexion()
        {
            conBD = new OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=reportes;port=3306");
            conBD.Open();
            return conBD;
        }
      /*  public static MySqlConnection ObtenerConexion()
        {
            mySqlConeccion = new MySqlConnection("server = localhost; username = root; database = Reportes;");
            mySqlConeccion.Open();
            return mySqlConeccion;
        }*/

    }
    #endregion
}
