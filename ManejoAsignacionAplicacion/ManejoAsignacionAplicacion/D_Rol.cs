//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace ManejoAsignacionAplicacion
{
    public class D_Rol: CAD
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Consultar Registros
        public static DataTable ObtenerRegistros() // consulta para el grid
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando =new OdbcCommand(
                     string.Format("SELECT iidUsuario, CONCAT(`vnombreUsuario`,' - ',`vapellidoUsuario`) AS NombreCompleto FROM MaUSUARIO"),
                     CAD.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }
        #endregion
        public static DataTable AplicacionesDisponibles() // consulta para las aplicaciones disponibles
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaAPLICACION"),
                     CAD.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }

       
        public static int consultarNombreApp(string sApp)
        {
            int Id = 0;

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidAplicacion FROM MaAPLICACION where vnombreAplicacion = '" + sApp + "'"),
                     CAD.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Id = (int)mySqlDLector["iidAplicacion"];
                       
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return Id;
        }

        public static DataTable AplicacionesAsignadas(string sIdUser) // consulta para las aplicaciones asignadas
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT TrUSUARIOTOAPLICACION.iidAplicacion,vnombreAplicacion FROM MaAPLICACION INNER JOIN TrUSUARIOTOAPLICACION ON TrUSUARIOTOAPLICACION.iidAplicacion = MaAPLICACION.iidAplicacion where iidUsuario = '" + sIdUser + "'"),
                     CAD.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }

        public static int AgregarApp(string sApp, string sId)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("INSERT into TrUSUARIOTOAPLICACION (iidUsuario, iidAplicacion) values (" + sId + "," + sApp + ")"),
                CAD.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }


        protected static int quitaApp(string sApp, string sIdUser)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrUSUARIOTOAPLICACION  where iidUsuario = '" + sIdUser + "' and iidAplicacion = '" + sApp + "'"),
               CAD.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        protected static int quitaAllApp(string sIdUser)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrUSUARIOTOAPLICACION  where iidUsuario = '" + sIdUser + "'"),
               CAD.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        public static List<E_Rol> Buscar(string pNombre, string pApellido)
        {
            List<E_Rol> _lista = new List<E_Rol>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario, vemailUsuario FROM MAUSUARIO where vnombreUsuario ='{0}' or vapellidoUsuario='{1}'", pNombre, pApellido),
               CAD.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    E_Rol pEmpleado = new E_Rol();
                    pEmpleado.Id = _reader.GetInt32(0);
                    pEmpleado.Nombre = _reader.GetString(1);
                    pEmpleado.Apellido = _reader.GetString(2);




                    _lista.Add(pEmpleado);
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
