using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace DLLSeguridad
{
    public class D_ManejoRol
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        public static List<E_ManejoRol> Buscar(string pNombre, string pApellido)
        {
            List<E_ManejoRol> _lista = new List<E_ManejoRol>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario, vemailUsuario FROM MAUSUARIO where vnombreUsuario ='{0}' or vapellidoUsuario='{1}'", pNombre, pApellido),
               ConexionODBC.Conexion.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    E_ManejoRol pEmpleado = new E_ManejoRol();
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

        #region Consultar Perfiles
        public static DataTable consultaPerfil()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            string consulta = "select iidRole,vnombreRole from MaROLUSUARIO;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, ConexionODBC.Conexion.ObtenerConexion());
            da.Fill(dt1);
            return dt1;
        }
        #endregion

        #region Consultar Apps
        public static DataTable consultaApps()
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            string consulta = "select iidAplicacion,vnombreAplicacion from MaAPLICACION;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, ConexionODBC.Conexion.ObtenerConexion());
            da.Fill(dt2);
            return dt2;
        }
        #endregion


        #region Insertar Rol Usuario
        public static int AgregarRol(string sRol, string sId)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("INSERT into TrUSUARIOTOROLE (iidRole, iidUsuario) values (" + sRol + "," + sId + ")"),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion

        public static DataTable AplicacionesDisponibles() // consulta para las aplicaciones disponibles
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaAPLICACION"),
                     ConexionODBC.Conexion.ObtenerConexion()
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
       

       

        




        #region Eliminar Registro
        public static int Eliminar(int pId)
        {
            int iValorRetorno = 0;

            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Delete From MaROLUSUARIO where iidRole ={0}", pId), ConexionODBC.Conexion.ObtenerConexion());
                iValorRetorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Eliminar el Registro", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return iValorRetorno;

        }
        #endregion



       

       


        public static DataTable RolAsignados(string sIdUser) // consulta para las aplicaciones asignadas
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT TrUSUARIOTOROLE.iidRole , MaROLUSUARIO.vnombreRole FROM MaROLUSUARIO, TrUSUARIOTOROLE WHERE MaROLUSUARIO.iidRole = TrUSUARIOTOROLE.iidRole AND TrUSUARIOTOROLE.iidUsuario ='" + sIdUser + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
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



        public static int consultarNombreRol(string sRol)
        {
            int Id = 0;

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidRole FROM MaROLUSUARIO where vnombreRole = '" + sRol + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Id = (int)mySqlDLector["iidRole"];

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return Id;
        }


        protected static int quitaRol(string sRol, string sIdUser)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrUSUARIOTOROLE  where iidUsuario = '" + sIdUser + "' and iidRole = '" + sRol + "'"),
               ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

    }
}
