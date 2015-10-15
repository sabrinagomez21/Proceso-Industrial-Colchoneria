using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bitacora
{
    public class N_Bitacora : D_Bitacora
    {
        public System.Data.DataTable GetAll()
        {
            return D_Bitacora.ObtenerRegistros();
        }


        public void Insertar_Registro(E_Bitacora pBitacora)
        {
            int resultado = D_Bitacora.Agregar(pBitacora);
        }
        public System.Data.DataTable SUSER(int id)
        {
            return D_Bitacora.ObtenerUsuario(id);
        }
        public System.Data.DataTable aplicacion()
        {
            return D_Bitacora.DatosAplicacion();

        }

        /*public System.Data.DataTable usuarioAplicacion(int iuser,int iapp)
        {
            return D_Bitacora.DatosAplicacion();
        }*/

        public System.Data.DataTable Aplicaciones(int user,int iapp)
        {
            if (user > 0)
            {
                return D_Bitacora.UserToAplicacion(user, iapp);
            }
            else
            {
                return D_Bitacora.ObtenerAplicaciones(iapp);
            }
            
        }
    }
}
