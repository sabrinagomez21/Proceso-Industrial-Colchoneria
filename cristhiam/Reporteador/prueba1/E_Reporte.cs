using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prueba1
{
    public class E_Reporte
    {
        #region Atributos y Encapsulamiento
        public int id { get; set; }
        public string nom_reporte { get; set; }
        public string usuario { get; set; }
        public string fecha_hora { get; set; }

        #endregion

        public E_Reporte()
        {

        }

    }
}
