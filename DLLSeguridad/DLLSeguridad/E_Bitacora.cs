using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora
{
    public class E_Bitacora
    {
        #region Atributos y Encapsulamiento

        public int Id { get; set; }
        public string nombreEquipo { get; set; }
        public string hora { get; set; }
        public string fecha { get; set; }
        public string nombre { get; set; }
        

        #endregion

        #region Constructor

        public E_Bitacora()
        {

        }

        public E_Bitacora(string pnombreEquipo, string phora, string pfecha,string pnombre)
        {
            this.nombreEquipo = pnombreEquipo;
            this.hora = phora;
            this.fecha = pfecha;
            this.nombre = pnombre;
        }

        #endregion
    }
}
