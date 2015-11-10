/* Proyecto Desarrollado y Elaborado Por: Hector Joannes Gil Cardona
 * Fecha de Asignacion: 23 de Septiembre
 * Fecha de Entrega: 10 de Octubre
 * 
 */
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace Manejo_Rol
{
    public class D_Rol
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        public static List<E_Rol> Buscar(string pNombre, string pApellido)
        {
            //lista para los roles
            List<E_Rol> _lista = new List<E_Rol>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT ncodusuario, vnombreusuario, vapellidousuario, vemailusuario FROM MaUsuario where vnombreusuario ='{0}' or vapellidousuario='{1}'", pNombre, pApellido),
               ConexionODBC.Conexion.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    // asigna cada valor a las variables entidad de rol
                    E_Rol pEmpleado = new E_Rol();
                    pEmpleado.Id = _reader.GetInt32(0);
                    pEmpleado.Nombre = _reader.GetString(1);
                    pEmpleado.Apellido = _reader.GetString(2);




                    _lista.Add(pEmpleado); //llena la lista de empleado
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
            DataTable dt1 = new DataTable(); // databable para llenar los datos
            dt1.Clear(); //limpia el datatable
            string consulta = "select ncodrole,vnombrerole from MaROLUSUARIO;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, ConexionODBC.Conexion.ObtenerConexion());
            da.Fill(dt1); //llena el datatable de la consulta del query
            return dt1;
        }
        #endregion

        #region Consultar Apps
        public static DataTable consultaApps()
        {
            DataTable dt2 = new DataTable(); //datatable de consulta apps
            dt2.Clear();
            string consulta = "select ncodaplicacion,vnombreaplicacion from MaAPLICACION;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, ConexionODBC.Conexion.ObtenerConexion());
            da.Fill(dt2); //llena el datatable

            return dt2;
        }
        #endregion

        // inserta el rol del usuario
        #region Insertar Rol Usuario
        public static int AgregarRol(string sRol, string sId)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("INSERT into TrUSUARIOTOROLE (ncodusuario, ncodrole) values (" + sId + "," + sRol + ")"),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion

        public static DataTable AplicacionesDisponibles() // consulta para las aplicaciones disponibles
        {
            DataTable dtRegistros = new DataTable(); //dataTable para los registros de aplicaciones

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaAPLICACION"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros); //lena el datatable de la consulta

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }
       

       

        


        //elimina el rol del usuario

        #region Eliminar Registro
        public static int Eliminar(int pId)
        {
            int iValorRetorno = 0;

            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Delete From MaROLUSUARIO where ncodrole ={0}", pId), ConexionODBC.Conexion.ObtenerConexion());
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
                     string.Format("SELECT TrUSUARIOTOROLE.ncodrole , MaROLUSUARIO.vnombrerole FROM MaROLUSUARIO, TrUSUARIOTOROLE WHERE MaROLUSUARIO.ncodrole = TrUSUARIOTOROLE.ncodrole AND TrUSUARIOTOROLE.ncodusuario ='" + sIdUser + "'"),
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



        public static int consultarNombreRol(string sRol) //consulta para los nombre de los roles
        {
            int Id = 0;

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncodrole FROM MaROLUSUARIO where vnombrerole = '" + sRol + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Id = (int)mySqlDLector["ncodrole"]; //guarda el id en la variable para identificar el rol

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return Id;
        }

        // metodo para eliminar el rol
        protected static int quitaRol(string sRol, string sIdUser)//manda parametros de id rol y id usuario para la consulta
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrUSUARIOTOROLE  where ncodusuario = '" + sIdUser + "' and ncodrole = '" + sRol + "'"),
               ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

    }
}
