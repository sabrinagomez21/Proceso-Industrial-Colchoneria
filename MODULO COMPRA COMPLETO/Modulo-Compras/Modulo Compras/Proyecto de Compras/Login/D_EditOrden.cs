using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Login
{
    public class D_EditOrden
    {
        public static int Actualizar(E_EditOrden pOrden)
        {
            // valor que se utiliza para verificar si el query se ejecuto correctamente
            int retorno = 0;
            try
            {
                // query
                OdbcCommand comando = new OdbcCommand(string.Format("Update MaORDENCOMPRA set ncodproveedor={0}, vdescripcioncompra='{1}', ncantidad={2},ncostototal={3},ncodarticulo={4},vstatusorden='{5}'  where ncodordencompra={6}",
                pOrden.Id_Proveedor, pOrden.descripcionCompra, pOrden.cantidad, pOrden.costototal, pOrden.id_articulo, pOrden.status, pOrden.Id_orden), ConexionODBC.Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery(); // ejecuta query
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Actualizar el Registro", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //retorna el valor el cual tendria q ser mayor a 0 o 0 si en tal caso el query no se ejecuto bien
            return retorno;
        }
    }
}
