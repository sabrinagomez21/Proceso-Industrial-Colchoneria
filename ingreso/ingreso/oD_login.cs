using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionODBC;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.Odbc;
using System.Windows.Forms;


namespace ingreso
{

     public class oD_login
    {

         private static OdbcDataAdapter mySqlDAdAdaptador;

         public iE_login variables = new iE_login();

         //operacion de acceso al sistema
         
         public  DataTable login(iE_login variables)
         {

             DataTable dtRegistros = new DataTable();
            try{             
             

             OdbcCommand _comando = new OdbcCommand(
                 String.Format("SELECT * FROM MAUSUARIO where vusuario = '" + variables.username + "' and vpassword = '" + variables.password + "'"), ConexionODBC.Conexion.ObtenerConexion());

             
            
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = _comando;
            mySqlDAdAdaptador.Fill(dtRegistros);
            }
             catch(Exception ex){

                 MessageBox.Show("Los Datos ingresados son Erroneos","intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             }
            return dtRegistros;

                        
         }

    }
}
