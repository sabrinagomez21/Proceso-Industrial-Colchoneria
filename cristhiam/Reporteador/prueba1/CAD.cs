using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prueba1
{
    #region Conexión A Datos - CAD
    public class CAD
    {
        private static MySqlConnection mySqlConeccion;

        public static MySqlConnection ObtenerConexion()
        {
            mySqlConeccion = new MySqlConnection("server = localhost; username = root; password = 12345; database = Reportes");
            mySqlConeccion.Open();

            return mySqlConeccion;
        }
    }
    #endregion
}
