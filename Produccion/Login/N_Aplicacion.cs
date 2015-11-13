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

        public System.Data.DataTable Ordenes()
        {
            return D_Aplicacion.Orden();

        }

        public System.Data.DataTable Materiales()
        {
            return D_Aplicacion.Material();

        }
        public System.Data.DataTable GetEntregasParciales()
        {
            return D_Aplicacion.EntregaParcial(); // todos los registros
        }
        public List<string> InfoOrdenes(string idApp)
        {
            return D_Aplicacion.InfoOrden(idApp);
        }
        public int CantidadFabricar(string noorden)
        {
            return D_Aplicacion.CantProdFabricar(noorden);
        }
        public int CantidadTerminado(string noorden)
        {
            return D_Aplicacion.CantProdTerminado(noorden);
        }
        public int UltimoID()
        {
            return D_Aplicacion.LastID();
        }
    }
}
