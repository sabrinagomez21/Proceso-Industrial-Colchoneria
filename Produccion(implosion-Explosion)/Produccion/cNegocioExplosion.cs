using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
namespace Produccion
{
    public class cNegocioExplosion:cDatosExplosion
    {
        public  DataTable obtenerProducto()
        {   
            return cDatosExplosion.Consultar();
        }
        public DataTable Explotar(int iproducto)
        {
            return cDatosExplosion.Explosion(iproducto);
        }
    }
}
