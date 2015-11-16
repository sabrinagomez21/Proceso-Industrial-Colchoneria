using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
namespace Login
{
    public class cNegocioMateriales:cDatosMateriales
    {
        public  DataTable obtenerProducto()
        {   
            return cDatosMateriales.Consultar();
        }
        public DataTable Explotar(int iproducto)
        {
            return cDatosMateriales.Explosion(iproducto);
        }
        public DataTable Implot(int icant, int iprod)
        {
            return cDatosMateriales.Implosion(icant,iprod);
        }
        public static int ordenproducto()
        {
            return cDatosMateriales.codproduccion();
        }
        public static DataTable producto()
        {
            return cDatosMateriales.produccion();
        }

    }
}
