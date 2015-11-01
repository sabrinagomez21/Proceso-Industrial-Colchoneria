using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;

namespace prueba1
{

    public class D_Reporte:CAD
    {

        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        #region Consultar Registros

        public static DataTable ObtenerRegistros()
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(string.Format("SELECT * FROM reportes"), CAD.ObtenerConexion());
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);
                CAD.ObtenerConexion().Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }
        #endregion

        #region Insertar Registro
        public static int Inserta(E_Reporte eReporte)
        {
            int iValorRetorno = 0;
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("Insert into reportes (nom_reporte, usuario, fecha_hora) values ('{0}','{1}','{2}')",
                    eReporte.nom_reporte, eReporte.usuario, eReporte.fecha_hora), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Insertar el Registro o Bien ya Existe", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return iValorRetorno;
        }
        #endregion

        #region Eliminar Registro
        public static int Eliminar(string pId)
        {
            int iValorRetorno = 0;

            try
            {
                mySqlComando = new OdbcCommand(string.Format("Delete From reportes where nom_reporte='" + pId + "'"), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Eliminar el Registro", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return iValorRetorno;

        }

        #endregion

    }
}
