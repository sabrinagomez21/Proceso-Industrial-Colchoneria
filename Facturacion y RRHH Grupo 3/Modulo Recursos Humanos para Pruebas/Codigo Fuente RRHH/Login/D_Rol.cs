//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace Login
{
    public class D_Rol
    {
        //declaracion de variables para la conexion ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        

       //funcion login el cual consulta los datos del usuario por medio de usuario y contraseña 
        #region Login
        public static int LoginD(string sUser, string sContra)
        {
            //declaramos una variable de tipo entero con valor a 0
            int iValorRetorno = 0;
            //hacemos el query el cual se asignara a odbccomand
            mySqlComando = new OdbcCommand(
                string.Format("SELECT * FROM MaUSUARIO where vusuario = '" + sUser + "' AND vpassword =  SHA1('" + sContra + "') "),
                ConexionODBC.Conexion.ObtenerConexion()
            );
            //ejecuta la consulta si hay un dato devuelve un 1, si no un 0
            iValorRetorno = mySqlComando.ExecuteNonQuery();
            //devolvvemos la variable
            return iValorRetorno;
        }
        #endregion
        //funcion el cual cuenta todos los modulos del sistema
        #region Contar Modulos
        public static int ContModu()
        {
            //declaramos una variable de tipo entero inicializandola con 0
            int Tot = 0;
            try
            {
                //hacemos el query el cual se asignara a odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT COUNT(*) as Total FROM MaMODULO"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta la consulta del comando y la pasa un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee datos 
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //encuentra la variable "Total" y la asigna la variable tot
                        Tot = Convert.ToInt32(mySqlDLector["Total"]);
                    }
                }
            }
            catch (Exception e)
            {
                //si no encontro el registro muestra el error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el numero total de modulos
            return Tot;
        }
        #endregion
        //funcion el cual cuenta las aplicacion que existe en cada modulo
        #region Contar Aplicaciones
        public static int ContAplica(int idModu)
        {
            //declaramos la varaible tot para inicializarla con 0
            int Tot = 0;
            try
            {
                //asignamos el query hacia el odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT count(*) as Total FROM MaAPLICACION WHERE ncodModulo = '" + idModu + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query hacia un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee 
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //entonces asigna la fila ala variable creada anteriormente
                        Tot = Convert.ToInt32(mySqlDLector["Total"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muentra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el valor encontrado
            return Tot;
        }
        #endregion
        //funcion el cual consulta los nombres del modulo
        #region Nombre Modulos
        public static string NameModu(int idModu)
        {
            //incializamos la variable con una cadena vacia
            string Name = "";
            try
            {
                //asigna el query ala variable odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombreModulo FROM MaMODULO where ncodModulo = '" + idModu + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query y lo asigna a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si logra leer el data reader
                if (mySqlDLector.Read())
                {
                    //si data reader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del modulo ala variable Name
                        Name = Convert.ToString(mySqlDLector["vnombreModulo"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra el error si existe
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve la variable con los datos asignados
            return Name;
        }
        #endregion
        //funcion el cual consulta los roles que tiene asignado el usuario
        #region Nombre Rol
        public static string NameRol(int idUser)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            string Name = "";
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT MaROLUSUARIO.vnombreRole FROM MaUSUARIO" +
                                    " INNER JOIN TrUSUARIOTOROLE ON MaUSUARIO.ncodUsuario = TrUSUARIOTOROLE.ncodUsuario" +
                                    " INNER JOIN MaROLUSUARIO ON MaROLUSUARIO.ncodRole = TrUSUARIOTOROLE.ncodRole" +
                                    " WHERE MaUSUARIO.ncodUsuario ='" + idUser + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        Name = Convert.ToString(mySqlDLector["vnombreRole"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return Name;
        }
        #endregion

        #region id Rol
        public static string idRol(int idUser)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            string Name ="" ;
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT MaROLUSUARIO.ncodRole FROM MaUSUARIO" +
                                    " INNER JOIN TrUSUARIOTOROLE ON MaUSUARIO.ncodUsuario = TrUSUARIOTOROLE.ncodUsuario" +
                                    " INNER JOIN MaROLUSUARIO ON MaROLUSUARIO.ncodRole = TrUSUARIOTOROLE.ncodRole" +
                                    " WHERE MaUSUARIO.ncodUsuario ='" + idUser + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        Name = Convert.ToString(mySqlDLector["ncodRole"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return Name;
        }
        #endregion

         public static string idUser(int idUser)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            string Name ="" ;
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT MaUSUARIO.ncodUsuario from MaUSUARIO WHERE MaUSUARIO.ncodUsuario ='" + idUser + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        Name = Convert.ToString(mySqlDLector["ncodUsuario"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return Name;
        }
        

        //funcion el cual devuelve el nombre del formulario
        #region Nombre Formulario
        public static string NameFormulario(int idApp)
        {
            //declaramos una variable string con valor vacio
            string NameFor = "";
            try
            {
                //asignamos el query ala odbccoman
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vNombreFormulario FROM MaAPLICACION" +
                                    " WHERE ncodAplicacion = " + idApp + ""),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query y lo asigna a datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del formulario encontrado ala variable 
                        NameFor = Convert.ToString(mySqlDLector["vNombreFormulario"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombredel formulario atravez de la variable
            return NameFor;
        }
        #endregion
        //funcion el cual devuelve las aplicaciones asignadas al usuario
        #region Nombre Aplicaciones de Usuario
        public static List<string> NameApUsu(int idUser)
        {
            //inicializa una lista de tipo string
            List<string> NameAppLista = new List<string>();
            //declaramos una variable de tipo string
            string NamesApp = "";
            try
            {
                //asignamos el query a odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombreAplicacion FROM TrUSUARIOTOAPLICACION" +
                                " INNER JOIN MaAPLICACION ON MaAPLICACION.ncodAplicacion = TrUSUARIOTOAPLICACION.ncodAplicacion" +
                                " WHERE TrUSUARIOTOAPLICACION.ncodUsuario = " + idUser + ""),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query para el odbcdatareader
                OdbcDataReader _reader = mySqlComando.ExecuteReader();
                //se ejecuta mientras encuentre datos
                while (_reader.Read())
                {
                    //encuentra la primer colmuna y la asigna a la variable
                    NamesApp = _reader.GetString(0);
                    //añade la variable ala lista
                    NameAppLista.Add(NamesApp);
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve la lista con todos los datos
            return NameAppLista;
        }
        #endregion
        //funcion el cual devuelve las aplicaciones de los roles asignados al usuario
        #region Nombre Roles de Usuario
        public static List<string> NameRolUsuAp(int idUser)
        {
            //inicializamos una lista de tipo string
            List<string> NameAppLista = new List<string>();
            //declaramos una variable string vacia
            string NamesRolUsu = "";
            try
            {
                //asigna el query hacia un odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT MaAPLICACION.vnombreAplicacion FROM MaUSUARIO" +
                                    " INNER JOIN TrUSUARIOTOROLE ON MaUSUARIO.ncodUsuario = TrUSUARIOTOROLE.ncodUsuario" +
                                    " INNER JOIN MaROLUSUARIO ON TrUSUARIOTOROLE.ncodRole = MaROLUSUARIO.ncodRole" +
                                    " INNER JOIN TrROLETOAPLICACION ON MaROLUSUARIO.ncodRole = TrROLETOAPLICACION.ncodRole" +
                                    " INNER JOIN MaAPLICACION ON TrROLETOAPLICACION.ncodAplicacion = MaAPLICACION.ncodAplicacion" +
                                    " WHERE MaUSUARIO.ncodUsuario =  " + idUser + ""),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query hacia un datareader
                OdbcDataReader _reader = mySqlComando.ExecuteReader();
                //lee el datareader mientras hallan datos
                while (_reader.Read())
                {
                    //encuentra los datos de la primera columna y las asigna ala variable
                    NamesRolUsu = _reader.GetString(0);
                    //añade la variable ala lista
                    NameAppLista.Add(NamesRolUsu);
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve la lista con las aplicaciones del usuario
            return NameAppLista;
        }
    #endregion
        //funcion el cual devuelve los nombre de las aplicaciones del modulo
        #region Nombre Aplicacion
        public static List<string> NameAppli(int idAppli)
        {
            //inicializamos una lista de tipo string
            List<string> PermisoLista = new List<string>();
            //declaramos una variable de tipo string
            string Name = "";
            try
            {
                //asignamos el query hacia el odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombreAplicacion FROM MaAPLICACION where ncodModulo = " + idAppli + ""),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query hacia un datareader
                OdbcDataReader _reader = mySqlComando.ExecuteReader();
                //lee los datos mientras hallan datos
                while (_reader.Read())
                {
                    //asigna la la primera columna encontrada hacia la variable
                    Name = _reader.GetString(0);
                    //añade la varible hacia la lista 
                    PermisoLista.Add(Name);
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve la lista con el nombre de las aplicaciones
            return PermisoLista;
        }
        #endregion
        //funcion el cual devuelve el id de la aplicacion
        #region Id Aplicacion
        public static int IdAppli(string NameAppli)
        {
            //declaramos una variable de tipo entero con un valor 0
            int idAp = 0;
            try
            {
                //asignamos el query hacia el odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncodAplicacion FROM MaAPLICACION where vnombreAplicacion = '" + NameAppli + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query y lo pasa a un datareader
                OdbcDataReader _reader = mySqlComando.ExecuteReader();
                //se ejecutara mientras hallan datos
                while (_reader.Read())
                {
                    //asigna la primer columna encontrada hacia la variable declarada
                    idAp = _reader.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el id de la aplicacion consultada
            return idAp;
        }
        #endregion
        //funcion el cual consulta los datos del usuario
        #region Consultar Usuario
        public static E_Rol Consultar(E_Rol sUser)
        {
            //creamos una variable de tipo E_Rol
            E_Rol pUser = new E_Rol();
            try
            {
                //asigna el query con el odbccomand
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM MaUSUARIO WHERE vusuario = '" + sUser.Usuario + "'"),
                    ConexionODBC.Conexion.ObtenerConexion()
                );
                //ejecuta el query y lo pasa a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el data reader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna los datos encontrados hacia la variable de tipo E_Rol que contiene atributos
                        pUser.Id = (int)mySqlDLector["ncodUsuario"];
                        pUser.Nombre = (string)mySqlDLector["vnombreUsuario"];
                        pUser.Apellido = (string)mySqlDLector["vapellidoUsuario"];
                        pUser.Email = (string)mySqlDLector["vemailUsuario"];
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mesaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve los datos del usuario
            return pUser;
        }
        #endregion
    }
}
