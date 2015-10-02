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
    class cErrorD:Conexion
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

        public static DataTable Consultar(int id)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaERROR WHERE iidUsuario='{0}'",id),
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
    }
}
