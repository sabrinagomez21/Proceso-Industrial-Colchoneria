using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario{
    #region Class E_Reporte
    public class E_Inventario
    {
    #endregion
        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Atributos y Encapsulamiento
        public string producto { get; set; }
        public string cantidad { get; set; }
        public string descripcion { get; set; }
        public string DI_orden { get; set; }
        public string DI_cantidad { get; set; }
        public string DI_tipo { get; set; }

        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region E_Reporte
        public E_Inventario()
        {

        }
        #endregion
    }
}
