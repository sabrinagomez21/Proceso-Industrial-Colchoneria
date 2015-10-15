using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitacora
{
   public class E_Usuario
    {
       #region Atributos y Encapsulamiento

        public int Id { get; set; }
        public static int id;
        public string nombre { get; set; }
        

        #endregion

        #region Constructor

        public E_Usuario()
        {

        }

        public E_Usuario(int pid, string pnombre)
        {
            this.Id = pid;
            this.nombre = pnombre;
        }

        #endregion
    }
}
