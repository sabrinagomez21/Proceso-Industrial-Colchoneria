using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class E_Rol
    {
        public static int IdUser;
        public static string UserName;
        public static string UserApellido;
        public static string UserEmail;
         #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int Id { get; set; }
        public string Nombre { get; set; }

        //variables de insercionRol
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        #endregion



        #region Constructor

        public E_Rol()
        {}

        public E_Rol(int pId, string pNombre, string pApellido, string pUsuario, string pEmail)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Usuario = pUsuario;
            this.Email = pEmail;         
        }

        #endregion
    
    }
}
