//analista programador walter flores 0901-12-62
//clase de datos de produccion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using ConexionODBC;
namespace Login
{
    public class cDatosMateriales:Conexion
    {
        //obtiene el nombre de la receta y su codigo para cargar a un seleccionador
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
        //obtiene datos para la explosion de productos
        //Explosion: nos muestra que tanto podemos fabricar con la materia que se cuenta en bodega
        public static DataTable Explosion(int ipproducto)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT mat.vnombre AS Material,mat.ncantidad AS 'Materia Bodega', detalle.ncantidad AS 'Materia Requerida',"
                + "mat.ncantidad DIV detalle.ncantidad AS 'Cantidad A Realizar', mat.nprecio AS 'Costo Unitario', ((mat.ncantidad DIV detalle.ncantidad)*mat.nprecio )AS 'Costo Total' FROM TrDETALLERECETA detalle INNER JOIN (MaRECETA receta,"
                +"MaMaterial mat) ON detalle.ncodmaterial=mat.ncodmaterial AND detalle.ncodreceta=receta.ncodreceta WHERE receta.ncodreceta='{0}'", ipproducto),
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
        //obtiene datos para la implosion de productos
        //Implosion: nos proporciona datos si una orden se puede llevar a cabo con la materia que se cuenta
        public static DataTable Implosion(int pcantidad,int pproducto)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT mat.vnombre AS Material,mat.ncantidad AS 'Materia Bodega', detalle.ncantidad AS 'Materia Requerida',"
                     + "(mat.ncantidad - (detalle.ncantidad*{0})) AS 'Materia Restante',mat.nprecio AS 'Costo Unitario', "
                     + "({0}*mat.nprecio )AS 'Costo Total' FROM TrDETALLERECETA detalle INNER JOIN (MaRECETA receta,"
                +"MaMaterial mat) ON detalle.ncodmaterial=mat.ncodmaterial AND detalle.ncodreceta=receta.ncodreceta WHERE receta.ncodreceta='{1}'",pcantidad, pproducto),
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
        //obtenemos datos de productos
        public static OdbcDataReader numProducto()
        {
            OdbcDataReader read=null;
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT nexistencia,vnombre FROM MaPRODUCTO"), ObtenerConexion());
                read = mySqlComando.ExecuteReader();

            }
            catch (Exception Ex)
            {
                // MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return read;
        }
        public static int codproduccion()
        {
            int codigo=0;
             OdbcDataReader read=null;
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT `AUTO_INCREMENT` FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'colchoneria' AND TABLE_NAME = 'maordenproduccion'"), ObtenerConexion());
                read = mySqlComando.ExecuteReader();
                while (read.Read())
                {
                    codigo = read.GetInt32(0);
                }
            }
            catch (Exception Ex)
            {

            }
            
            return codigo;
        }
        public static DataTable produccion()
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                     string.Format("SELECT `ncodordenes`,`vreferenciaproducto`,`vinicioproduccion`,`ventregaproducto`,"
                     +"`ncantidadproductoafabricar`,`ncantidadnoproductoterminado`,`ncantidadproductofaltante`,`vestatusorden`,"
                     +"`ncodreceta` FROM maordenproduccion",   ObtenerConexion()  ));
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {

            }
            return dtRegistros;
        }
    }
}
