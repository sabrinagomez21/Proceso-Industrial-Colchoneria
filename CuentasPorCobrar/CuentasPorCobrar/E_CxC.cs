using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    class E_CxC
    {
        public int iNoCliente { get; set; }
        public int iNoDocto { get; set; }
        public string sFrecha { get; set; }
        public string sTransaccion { get; set; }
        public int iValor { get; set; }

        public E_CxC(){
    
        }

        public E_CxC(int iNC, int iND, string sF, string sT, int iVal) {
            this.iNoCliente = iNC;
            this.iNoDocto = iND;
            this.sFrecha = sF;
            this.sTransaccion = sT;
            this.iValor = iVal;

        }
    }
}
