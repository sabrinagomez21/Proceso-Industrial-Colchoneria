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

        //actualizar grid
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
        // grid para usuario
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
        //combo box aplicacion
        public static DataTable DatosAplicacion()
        {
            DataTable bitacora = new DataTable();
            OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT vnombreAplicacion, iidAplicacion FROM MaAPLICACION"), Conexion.ObtenerConexion());
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = mySqlComando;
            ad.Fill(bitacora);
            return bitacora;

        }
        //combo box tipo de errores
        public static DataTable DatosError()
        {
            DataTable bitacora = new DataTable();
            OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT vnombre, iidTipo FROM MaTIPOERROR"), Conexion.ObtenerConexion());
            OdbcDataAdapter ad = new OdbcDataAdapter();
            ad.SelectCommand = mySqlComando;
            ad.Fill(bitacora);
            return bitacora;

        }
        //Usuario
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
        //Usuario Aplicacion
        public static DataTable UsuarioApliacion(int pusuario,int paplicacion)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidAplicacion='{1}' ", pusuario,paplicacion),
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
        //Aplicacion
        public static DataTable EApliacion(int paplicacion)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidAplicacion='{0}' ", paplicacion),
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
        //Error Aplicaion
        public static DataTable ErrorApliacion(int perror,int paplicacion)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidTipo='{0}' AND error.iidAplicacion='{1}' ",perror, paplicacion),
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
        //Error
        public static DataTable Error(int perror)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidTipo='{0}'", perror),
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
        //Usuario Error Aplicaion
        public static DataTable UsuarioErrorApliacion(int pusuario,int perror, int paplicacion)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidTipo='{1}' error.iidAplicacion='{2}' ",pusuario, perror, paplicacion),
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
        //Usuario Error
        public static DataTable UsuarioError(int pusuario, int perror)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidTipo='{1}'", pusuario, perror),
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
        //usuario error aplicacion y una fecha
        public static DataTable UsErrAppDate(int pusuario, int perror, int paplicacion, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidTipo='{1}' AND error.iidAplicacion='{2}' AND error.decha='{3}'", pusuario, perror, paplicacion, pfecha),
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
        //usuario error aplicacion y 2 fechas 
        public static DataTable UsErrApp2Date(int pusuario, int perror, int paplicacion, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidTipo='{1}' AND error.iidAplicacion='{2}' AND error.decha BETWEEN '{3}' AND '{4}'", pusuario, perror, paplicacion,pfecha,pfecha2),
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
        //usuario fecha
        public static DataTable UsDate(int pusuario, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.decha='{1}'", pusuario,  pfecha),
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
        //usuario 2 fechas 
        public static DataTable Us2Date(int pusuario, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.decha BETWEEN '{1}' AND '{2}'", pusuario, pfecha, pfecha2),
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
        //usuario aplicacion una fecha
        public static DataTable UsAppDate(int pusuario,int paplicacion, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidAplicacion='{1}' AND error.decha='{2}'", pusuario, paplicacion, pfecha),
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
        //usuario aplicacion 2 fechas 
        public static DataTable UsApp2Date(int pusuario,int paplicacion, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidAplicacion='{1}' AND error.decha BETWEEN '{2}' AND '{3}'", pusuario, paplicacion, pfecha, pfecha2),
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
        //usuario error y una fecha
        public static DataTable UsErrDate(int pusuario, int perror, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidTipo='{1}' AND error.decha='{2}'", pusuario, perror, pfecha),
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
        //usuario error y 2 fechas 
        public static DataTable UsErr2Date(int pusuario, int perror, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidUsuario='{0}' AND error.iidTipo='{1}' AND error.decha BETWEEN '{2}' AND '{3}'", pusuario, perror, pfecha, pfecha2),
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
        //error y una fecha
        public static DataTable ErrDate(int perror, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidTipo='{0}' AND error.decha='{1}'", perror, pfecha),
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
        //errory 2 fechas 
        public static DataTable Err2Date(int perror, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidTipo='{0}' AND error.decha BETWEEN '{1}' AND '{2}'",perror, pfecha, pfecha2),
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
        //aplicacion y una fecha
        public static DataTable AppDate(int paplicacion, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidAplicacion='{0}' AND error.decha='{0}'",paplicacion, pfecha),
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
        //aplicacion y 2 fechas 
        public static DataTable App2Date(int paplicacion, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidAplicacion='{0}' AND error.decha BETWEEN '{1}' AND '{2}'",paplicacion, pfecha, pfecha2),
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
        //error aplicacion y una fecha
        public static DataTable ErrAppDate(int perror, int paplicacion, string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidTipo='{0}' AND error.iidAplicacion='{1}' AND error.decha='{2}'",perror, paplicacion, pfecha),
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
        //error aplicacion y 2 fechas 
        public static DataTable ErrApp2Date(int perror, int paplicacion, string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.iidTipo='{0}' AND error.iidAplicacion='{1}' AND error.decha BETWEEN '{2}' AND '{3}'",perror, paplicacion, pfecha, pfecha2),
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
        //usuario fecha
        public static DataTable Date(string pfecha)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.decha='{0}'",pfecha),
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
        //usuario 2 fechas 
        public static DataTable Dates(string pfecha, string pfecha2)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT CONCAT(usuario.vnombreusUario,' ',usuario.vapellidoUsuario) AS 'Usuario',app.vnombreAplicacion AS 'Aplicacion' " +
                     ",terror.vnombre As 'Tipo',error.vaccion AS 'Accion', error.dora AS 'Hora', error.decha AS 'Fecha' FROM MaERROR error " +
                     "INNER JOIN (MaUSUARIO usuario,MaAPLICACION app,MaTIPOERROR terror) ON error.iidUsuario=usuario.iidUsuario AND error.iidAplicacion=app.iidAplicacion" +
                     " AND error.iidTipo=terror.iidTipo WHERE error.decha BETWEEN '{0}' AND '{1}'",pfecha, pfecha2),
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
    }
}
