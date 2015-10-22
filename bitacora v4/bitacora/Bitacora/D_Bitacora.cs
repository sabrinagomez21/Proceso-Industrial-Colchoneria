//La función de la siguiente clase o capa es la de almacenar todos los metodos necesarios para el funcionamiento
//del modulo de bitacora

//Programador y Analista: José Wilfredo Chacón Cartagena
//Fecha de Asignación: 08/10/2015
//Fecha de Entrega: 21/10/2015

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace Bitacora
{
    public class D_Bitacora:E_Bitacora
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Agregar Registro a la Bitacora

        //Funcion que inserta datos a la tabla bitacora
        public static int Agregar(E_Bitacora eBitacora)
        {
            int iValorRetorno = 0;

            string sMachineName = Environment.MachineName;

            mySqlComando = new OdbcCommand(string.Format("INSERT INTO BITACORA (hora, fecha, nombreEquipo) VALUES(DATE_FORMAT(CURTIME(), '%h:%i:%s'),CURDATE(),'{1}',{2},'{3}')", sMachineName,
                eBitacora.hora, eBitacora.fecha),
                Conexion.ObtenerConexion());

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion

        #region Obtener Datos de la Bitacora

        //Funcion que nos sirve para buscar registros almacenados en la tabla bitacora
        public static DataTable ObtenerRegistros()
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) "+
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion "), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region UsuarioConsulta

        //Metodo utilizado para obtener el registro de un usuario ya sea por nombre o por apellido
        public static List<E_Usuario> Buscar(string pNombre, string pApellido)
        {
            
            List<E_Usuario> _lista = new List<E_Usuario>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario FROM MaUSUARIO where vnombreUsuario = '{0}' or vapellidoUsuario = '{1}'", pNombre, pApellido), Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    E_Usuario pUsuario = new E_Usuario();
                    pUsuario.Id = _reader.GetInt32(0);
                    pUsuario.nombre = _reader.GetString(1) + " " + _reader.GetString(2);
                    _lista.Add(pUsuario);
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista;
        }

        #endregion

        #region usuario

        //Datatable que se llena con los registros de la tabla bitacora para poder ser mostrados en un datagrid. Los datos que se
        //muestran son los siguientes: nombre del equipo, usuario, IP del equipo, hora, fecha, aplicacion, accion y detalle
        public static DataTable ObtenerUsuario(int pid)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS Detalle FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}'", pid), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Datos Aplicacion

        //Datatable que se llena con los registros de las aplicaciones disponibles para cargarlas en un combobox
        public static DataTable DatosAplicacion()
        {
            DataTable bitacora = new DataTable();
            mySqlComando = new OdbcCommand(string.Format("SELECT vnombreAplicacion, iidAplicacion FROM MaAPLICACION"), Conexion.ObtenerConexion());
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = mySqlComando;
            ad.Fill(bitacora);
            return bitacora;

        }
        #endregion

        #region Obtener Datos de la Bitacora
        public static DataTable ObtenerAplicaciones(int iap)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidAplicacion='{0}'",iap), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos Usuario y apliacion

        //Datatable que obtiene el usuario y las aplicaciones que ha usado
        public static DataTable UserToAplicacion(int puser,int piap)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}' AND bita.iidAplicacion='{1}'",puser, piap), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos Usuario ,apliacion y fecha

        //Datatable que obtiene el usuario, las aplicaciones que ha usado y la fecha seleccionada
        public static DataTable UserToAppToDate(int puser, int piap, string pdate)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}' AND bita.iidAplicacion='{1}' AND bita.dfecha='{2}'", puser, piap,pdate), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos Usuario fecha
        public static DataTable UserToDate(int puser, string pdate)
        {
            DataTable bitacora = new DataTable();
            string comando= string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}' AND bita.dfecha='{1}'", puser, pdate);
            mySqlComando = new OdbcCommand(comando, Conexion.ObtenerConexion());
            MessageBox.Show(comando);
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos Aplicacion y fecha
        public static DataTable AppToDate(int piap, string pdate)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidAplicacion='{0}' AND bita.dfecha='{1}'", piap, pdate), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos fecha

        //Datatable que se llena con las fechas seleccionadas
        public static DataTable Date(string pdate)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.dfecha='{0}'", pdate), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos Usuario ,apliacion, fecha, fecha2

        //Datatable que se llena con los datos del usuario, la aplicacion seleccionada, y las fechas seleccionadas
        public static DataTable UserToAppTo2Date(int puser, int piap, string pdate,string pdate2)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}' AND bita.iidAplicacion='{1}' AND bita.dfecha BETWEEN '{2}' AND '{3}'", puser, piap, pdate,pdate2), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos entre 2 fechas

        //Datatable que se llena con los registros obtenidos habiendo seleccionado como filtro 2 fechas
        public static DataTable To2Date(string pdate, string pdate2)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.dfecha BETWEEN '{0}' AND '{1}'", pdate, pdate2), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos Usuario y 2 fechas

        //Datatable que se llena con la informacion de los usuarios registrados y la seleccion de 2 fechas
        public static DataTable UserTo2Date(int puser, string pdate, string pdate2)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}' AND bita.dfecha BETWEEN '{1}' AND '{2}'", puser, pdate, pdate2), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region Obtener Datos apliacion y 2 fechas

        //Datatable que se llena con la informacion de las aplicaciones disponibles y la seleccion de 2 fechas
        public static DataTable AppTo2Date(int piap, string pdate, string pdate2)
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion AS 'Detalle' FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) " +
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidAplicacion='{0}' AND bita.dfecha BETWEEN '{1}' AND '{2}'", piap, pdate, pdate2), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion
        
    }

}
