using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    class D_CxC: CAD
    {
        public static int Insertar(E_CxC cxc){
            return 0;
        }

        public static int Actualizar(E_CxC cxc){
            return 0;
        }

        public static int Eliminar(E_CxC cxc){
            return 0;
        }

        public E_CxC Consulta(E_CxC cxc){
            return cxc;
        }

        public static DataTable ObtenerRegistros()
        {
            DataTable dtRegistros = new DataTable();
            return dtRegistros;
        }
    }
}
