using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{

    public class D_Reporte:CAD
    {
        
        private static MySqlCommand mySqlComando;
        private static MySqlDataAdapter mySqlDAdAdaptador;
        #region Consultar Registros

        public static DataTable ObtenerRegistros()
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new MySqlCommand(
                     string.Format("SELECT * FROM reportes"),
                     CAD.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new MySqlDataAdapter();
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

        #region Insertar Registro
        public static int Inserta(E_Reporte eReporte)
        {
            int iValorRetorno = 0;

            mySqlComando = new MySqlCommand(
                string.Format("Insert into reportes (nom_reporte, usuario, fecha_hora) values ('{0}','{1}','{2}')",
                eReporte.nom_reporte, eReporte.usuario, eReporte.fecha_hora),
                CAD.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion

        #region Eliminar Registro
        public static int Eliminar(int pId)
        {
            int iValorRetorno = 0;

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Delete From reportes where id={0}", pId), CAD.ObtenerConexion());
                iValorRetorno = comando.ExecuteNonQuery();
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
