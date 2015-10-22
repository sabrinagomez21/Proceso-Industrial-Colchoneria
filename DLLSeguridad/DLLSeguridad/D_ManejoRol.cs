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
           "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario FROM MaUSUARIO where vnombreUsuario ='{0}' or vapellidoUsuario='{1}'", pNombre, pApellido), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                E_ManejoRol pEmpleado = new E_ManejoRol();
                pEmpleado.Id = _reader.GetInt32(0);
                pEmpleado.Nombre = _reader.GetString(1);
               
              


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
        public static int AgregarRol(E_ManejoRol eNameRol)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("Insert into MaROLUSUARIO (vnombreRole) values ('{0}')",
                eNameRol.Nombre),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion


        #region Consultar Registros
        public static DataTable ObtenerRegistros() // consulta para el grid
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaROLUSUARIO"),
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
        #endregion

        #region Consultar Un Registro

        public static E_ManejoRol Consultar(E_ManejoRol eRol)
        {
            E_ManejoRol pRol = new E_ManejoRol();

            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM MaROLUSUARIO WHERE iidRole = '{0}'", eRol.Id),
                    ConexionODBC.Conexion.ObtenerConexion()
                );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        pRol.Id = (int)mySqlDLector["iidRole"];
                        pRol.Nombre = (string)mySqlDLector["vnombreRole"];
                     
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return pRol;
        }
        #endregion

        public static List<E_ManejoRol> BuscarRegisRol(string pNombreRol)
        {
            List<E_ManejoRol> _lista1 = new List<E_ManejoRol>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidRole, vnombreRole FROM MaROLUSUARIO where vnombreRole ='{0}'", pNombreRol), ConexionODBC.Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();


              
                while (_reader.Read())
                {
                    E_ManejoRol pEmpleado = new E_ManejoRol();
                    pEmpleado.Id = _reader.GetInt32(0);
                    pEmpleado.Nombre = _reader.GetString(1);




                    _lista1.Add(pEmpleado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista1;
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



        #region Actualizar Registro

        public static int Actualizar(E_ManejoRol pRol)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando1 = new OdbcCommand(string.Format("Update MaROLUSUARIO set vnombreRole='{0}' where iidRole={1}",
                pRol.Nombre, pRol.Id), ConexionODBC.Conexion.ObtenerConexion());

                retorno = comando1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Actualizar el Registro", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return retorno;
        }

        #endregion

    }
}
