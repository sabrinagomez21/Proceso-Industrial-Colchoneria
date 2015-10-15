using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Rol
{
    
    public class E_ManageRol
    {
        #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int Id_Rol { get; set; }
        public string Nombre_Rol { get; set; }

        //variables de insercionRol
       



        #endregion



        #region Constructor

        public E_ManageRol()
        { }

        public E_ManageRol(int pIdRol, string pNombreRol)
        {
            this.Id_Rol = pIdRol;
            this.Nombre_Rol = pNombreRol;
          


        }

        #endregion

    }
}
