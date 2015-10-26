// Capa en la cual se encuentran las variables a utilizar dentro del sistema.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo
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

        //variables de insercion
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
