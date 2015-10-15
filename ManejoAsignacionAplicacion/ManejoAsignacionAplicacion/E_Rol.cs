using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoAsignacionAplicacion
{
    public class E_Rol
    {
         #region Atributos y Encapsulamiento

        //  variables de busqueda usuario.
        public static int IdUser;
        public static string NameUser;
        public int Id
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }

        //variables de insercionRol
        public string Apellido { get; set; }
       


        #endregion



        #region Constructor

        public E_Rol()
        {}

        public E_Rol(int pId, string pNombre, string pApellido)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
           
            
        }

        #endregion
    
    }
}
