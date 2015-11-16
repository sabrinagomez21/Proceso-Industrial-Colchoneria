using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Inventario
{
    class CAD
    {
        private static OdbcConnection conBD;

        public static OdbcConnection obtenerConexion()
        {
            conBD = new OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=colchoneria;port=3306");
            conBD.Open(); //Inicia la Conexion
            return conBD;

        }
    }
}
