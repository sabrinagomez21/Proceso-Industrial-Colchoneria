using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
                     string.Format("SELECT * FROM cliente"),
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
    }
}
