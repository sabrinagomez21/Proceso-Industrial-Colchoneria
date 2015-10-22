using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLSeguridad
{
    public class E_ManejoRol
    {
         #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int Id { get; set; }
        public string Nombre { get; set; }

        //variables de insercionRol
      //  public int IdRole { get; set; }
       // public string NombreRole { get; set; }
       


        #endregion



        #region Constructor

        public E_ManejoRol()
        {}

        public E_ManejoRol(int pId, string pNombre )
        {
            this.Id = pId;
            this.Nombre = pNombre;
           
          //  this.NombreRole = pNombreRole;
           
            
        }

        #endregion
    
    }
}
