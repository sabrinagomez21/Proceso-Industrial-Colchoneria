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
         
         public  DataTable login(iE_login dtos)
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

                 if (MessageBox.Show("El usuario o la contraseña no son válidos", "Error de credenciales", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                     Application.Exit();

             }
            return dtRegistros;

                        
         }

         public DataTable rol(iE_login datos)
         {
             DataTable id_usuario = new DataTable();
             DataTable id_rol = new DataTable();
             DataTable id_modulo = new DataTable();
             
             try
             {
                 OdbcCommand _comando = new OdbcCommand(
                       String.Format("SELECT iidUsuario FROM MAUSUARIO where vusuario = '" + variables.username + "' and vpassword = '" + variables.password + "'"), ConexionODBC.Conexion.ObtenerConexion());

                 mySqlDAdAdaptador = new OdbcDataAdapter();
                 mySqlDAdAdaptador.SelectCommand = _comando;
                 mySqlDAdAdaptador.Fill(id_usuario);

                 OdbcCommand rolcomando = new OdbcCommand(
                     string.Format("SELECT iidRole FROM TRUSUARIOTOROLE where iidUsuario ='"+id_usuario+"'"),ConexionODBC.Conexion.ObtenerConexion());
                 mySqlDAdAdaptador = new OdbcDataAdapter();
                 mySqlDAdAdaptador.SelectCommand = rolcomando;
                 mySqlDAdAdaptador.Fill(id_rol);

                 OdbcCommand idmodulo = new OdbcCommand(
                    string.Format("SELECT ii FROM TRUSUARIOTOROLE where iidUsuario ='" + id_rol + "'"), ConexionODBC.Conexion.ObtenerConexion());
                 mySqlDAdAdaptador = new OdbcDataAdapter();
                 mySqlDAdAdaptador.SelectCommand = idmodulo;
                 mySqlDAdAdaptador.Fill(id_modulo);



                 
             }
             catch (Exception e)
             {      }
             return dtrol;

         }
     }
    }

