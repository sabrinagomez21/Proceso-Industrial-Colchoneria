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
        public static DataTable ObtenerRegistros()
        {
            DataTable bitacora = new DataTable();

            mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) "+
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion "), Conexion.ObtenerConexion());
            mySqlDAdAdaptador = new OdbcDataAdapter();
            mySqlDAdAdaptador.SelectCommand = mySqlComando;
            mySqlDAdAdaptador.Fill(bitacora);

            return bitacora;
        }
        #endregion

        #region UsuarioConsulta
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

        #region UsuarioBitacora
        public static List<E_Bitacora> Busca(string pid)
        {
            
            List<E_Bitacora> _lista = new List<E_Bitacora>();
            
            try
            {
                
               mySqlComando = new OdbcCommand(string.Format("SELECT bita.vnombreEquipo AS 'Nombre del Equipo', CONCAT(user.vnombreusUario,' ',user.vapellidoUsuario) AS 'Usuario', bita.vipEquipo AS 'IP Equipo', bita.dhora AS 'Hora'," +
                "bita.dfecha AS 'Fecha',app.vnombreAplicacion AS 'Aplicacion', accion.vnombreAccion AS 'Accion',bita.vdetalleAccion FROM MaBITACORA bita  INNER JOIN (MaUSUARIO user,MaACCIONES accion,MaAPLICACION app) "+
                "ON bita.iidUsuario=user.iidUsuario AND bita.iidAplicacion=app.iidAplicacion AND bita.iidAccion=accion.iidAccion WHERE bita.iidUsuario='{0}'",pid), Conexion.ObtenerConexion());
               OdbcDataReader _reader = mySqlComando.ExecuteReader();
                while (_reader.Read())
                {
                    E_Bitacora pUsuario = new E_Bitacora();
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
    }

}
