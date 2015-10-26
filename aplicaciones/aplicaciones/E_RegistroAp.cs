//Capa donde se encuentran las variables a utilizar en el modulo.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using ConexionODBC;
using System.Windows.Forms;


namespace aplicaciones
{
    class E_RegistroAp
    {
         #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int Idapli { get; set; }
        public string NombreAplicacion { get; set; }

        //variables de insercionRol
        public string NormbreForm { get; set; }

       #endregion

        #region Constructor

        public E_RegistroAp()
        { }

        public E_RegistroAp(int pIdApli, string pNombreApli, string pNombreForm)
        {
            this.Idapli = pIdApli;
            this.NombreAplicacion = pNombreApli;
            this.NormbreForm = pNombreForm;
            

        }

        #endregion



    }

}