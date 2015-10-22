using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    public class cError
    {
        public int iIdUsuario { get; set; }
        public string sFecha { get; set; }
        public string sHora { get; set; }
        public int iAplicacion { get; set; }
        public string sAccion { get; set; }
        public int iTipo { get; set; }
        public cError(int iUser, string sFec,string sHor,int iApp,string sAc, int iTi)
        {
            this.iIdUsuario = iUser;
            this.sFecha = sFec;
            this.sHora = sHor;
            this.iAplicacion = iApp;
            this.sAccion = sAc;
            this.iTipo = iTi;
        }

        public cError()
        {
    
        }
    }
}
