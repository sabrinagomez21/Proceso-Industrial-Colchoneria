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
    public class E_Rol
    {
        //variables para el rol
        #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int Id { get; set; }
        public string Nombre { get; set; }

        //variables de insercionRol
        public string Apellido { get; set; }



        #endregion



        #region Constructor

        public E_Rol()
        { }

        public E_Rol(int pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;


        }

        #endregion

    }
}
