using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Login
{
    public class N_Aplicacion:D_Aplicacion
    {
        public System.Data.DataTable Permisos(string nform, string nidRol,string nidUser)
        {
            return D_Aplicacion.Get(nform,nidRol,nidUser);

        }

        public System.Data.DataTable GetAll()
        {
            return D_Aplicacion.ObtenerRegistros();
        }

        public E_Aplicacion GetSingle_Cliente(int id)
        {
            E_Aplicacion pCliente = new E_Aplicacion();
            pCliente.Idproveedor = id;
            return D_Aplicacion.Consultar(pCliente);
        }
        
    }
}
