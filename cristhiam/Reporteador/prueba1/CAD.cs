using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

//Autor: Cristhiam Duarte
//Fecha: 29/10/15
namespace prueba1{
    #region Conexión A Datos - CAD
    public class CAD
    {
        private static OdbcConnection conBD; //Variable ODBC
        public static OdbcConnection ObtenerConexion()
        {   //String de Conexion
            conBD = new OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=colchoneria;port=3306");
            conBD.Open(); //Inicia la Conexion
            return conBD; //Valor de Retorno
        }
    }
    #endregion
}
