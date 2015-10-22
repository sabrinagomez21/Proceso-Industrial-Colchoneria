//La función de la siguiente clase o capa es la de encapsular los atributos que se estan usando

//Programador y Analista: José Wilfredo Chacón Cartagena
//Fecha de Asignación: 08/10/2015
//Fecha de Entrega: 21/10/2015

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

        public static string date1;

        public static string date2;
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
