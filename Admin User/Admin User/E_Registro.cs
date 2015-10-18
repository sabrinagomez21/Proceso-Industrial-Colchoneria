using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_User
{
    public class E_Registro
    {
        #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int IdUser { get; set; }
        public string NombreUser { get; set; }

        //variables de insercionRol
        public string ApellidoUser { get; set; }

        public string EmailUser { get; set; }
        public string User { get; set; }
        public string Password { get; set; }



        #endregion

        #region Constructor

        public E_Registro()
        { }

        public E_Registro(int pIdUser, string pNombreUser, string pApellidoUser, string pEmailUser, string pUser, string pPasssword)
        {
            this.IdUser = pIdUser;
            this.NombreUser = pNombreUser;
            this.ApellidoUser = pApellidoUser;
            this.EmailUser = pEmailUser;
            this.User = pUser;
            this.Password = pPasssword;


        }

        #endregion
    }


    
}
