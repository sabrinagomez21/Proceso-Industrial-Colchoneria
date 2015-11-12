using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graficador
{
    public class e_Grafica
    {
        public string sTitulo { get; set; }
        public string sEjeX { get; set; }
        public string sEjeY { get; set; }                
        public string[] x { get; set; }
        public double[] y { get; set; }
        public double[] dx { get; set; }
        public string sGrafica { get; set; }

        public e_Grafica() { }
    }
}
