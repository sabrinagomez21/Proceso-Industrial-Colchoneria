using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using ConexionODBC;
namespace Produccion
{
    public class cDatosExplosion:Conexion
    {
        public static DataTable Consultar()
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombrereceta,ncodreceta FROM MaRECETA"), ObtenerConexion());
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
        public static DataTable Explosion(int ipproducto)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT mat.vnombre AS Material,mat.ncantidad  AS 'Materia Bodega', detalle.ncantidad AS 'Materia Requerida',"
                + "AS 'Cantidad A Realizar'  FROM TrDETALLERECETA detalle INNER JOIN (MaRECETA receta, MaMateria mat) "
                + " ON detalle.ncodmaterial=mat.ncodmaterialAND detalle.ncodreceta=receta.ncodreceta WHERE receta.ncodreceta='{0}' ", ipproducto),
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
