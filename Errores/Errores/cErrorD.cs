using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using ConexionODBC;

namespace Errores
{
    public class cErrorD:Conexion
    {
        public static int Agregar(cError pError)
        {
            int retorno = 0;
            string sTabla="MaERROR";
            string sCampos = "dora, decha, iidAplicacion, iidUsuario,vaccion,iidTipo";
            string sDatos = string.Format("CURTIME(),CURDATE(),{0},{1},'{2}',{3}",
                            pError.iAplicacion, pError.iIdUsuario, pError.sAccion,pError.iTipo);
            string query = string.Format("INSERT INTO {0} ({1}) VALUES({2})", sTabla, sCampos, sDatos);
            OdbcCommand comando = new OdbcCommand(query, ObtenerConexion());
            try
            {
                retorno=comando.ExecuteNonQuery();
               
            }
            catch
            {

            }
            return retorno;
        }

        public static DataTable Consultar()
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' "+
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error "+
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion"+
                     " AND error.iidTipo=terror.iidTipo"),
                     ObtenerConexion()
                 );
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
               // MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dtRegistros;
        }

        public static DataTable ConsultarUsuario(int identificacor)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}'",identificacor),
                     ObtenerConexion()
                 );
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                // MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return dtRegistros;
        }

        public static DataTable Registros()
        {
            DataTable dtRegistros = new DataTable();

            try
            {

                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaERROR"),
                     ObtenerConexion()
                 );
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }

        public static List<cUsuario> Buscar(string pNombre, string pApellido)
        {

            List<cUsuario> _lista = new List<cUsuario>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario FROM MaUSUARIO where vnombreUsuario = '{0}' or vapellidoUsuario = '{1}'", pNombre, pApellido), Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    cUsuario pUsuario = new cUsuario();
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


    }
}
