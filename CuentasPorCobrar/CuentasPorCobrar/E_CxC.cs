using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    class E_CxC
    {
        public string sOperacionTransaccion{ get; set; }
        public string sNombreTransaccion { get; set; }

        public E_CxC(){
    
        }

        public E_CxC(string sOperacionTr, string sNomTr) {
            this.sOperacionTransaccion = sOperacionTr;
            this.sNombreTransaccion = sNomTr;
        }
    }
}
