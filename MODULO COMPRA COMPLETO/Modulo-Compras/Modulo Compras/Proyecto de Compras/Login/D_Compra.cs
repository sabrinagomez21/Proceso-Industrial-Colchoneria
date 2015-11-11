using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Login
{
    public class D_Compra
    {
        // comando para la ejecucion de querys
        private static OdbcCommand mySqlComando;
        // adaptador del odbc
        private static OdbcDataAdapter mySqlDAdAdaptador;

        public static int AgregarCompra(E_Compra eNameRol)
        {
            // valor el cual se retorna para validar si se realizo bien la accion
            int iValorRetorno = 0;
            // query
            mySqlComando = new OdbcCommand(
                string.Format("Insert into MaCompra (ncodcompra, vdescripcioncompra,ncantidad,ncostototal,dfecha) values ({0},'{1}',{2},{3},'{4}')",
                 eNameRol.nodocumento, eNameRol.descripcionC, eNameRol.cantidad, eNameRol.costototal, eNameRol.fecha),
                ConexionODBC.Conexion.ObtenerConexion()
            );
            // se ejecuta el query
            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno; // si el query fue realizdo exitosamente manda un valor mayor a 0
        }

    }
}
