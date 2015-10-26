/* Proyecto Desarrollado y Elaborado Por: Hector Joannes Gil Cardona
 * Fecha de Asignacion: 23 de Septiembre
 * Fecha de Entrega: 10 de Octubre
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Rol
{
    
    public class E_ManageRol
    {
        //variables para el id rol y nombre
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
