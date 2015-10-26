//Validaciones si en caso se ingresan datos incorrectos o no se ingresa ningun dato.
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
    class N_RegistroAp
    {

        public void Insert_User(E_RegistroAp pUser)
        {
            if (string.IsNullOrWhiteSpace(pUser.NombreAplicacion) || string.IsNullOrWhiteSpace(pUser.NormbreForm) )
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                int resultado = D_RegistroAp.AgregarApli(pUser);

                if (resultado > 0)
                {
                    MessageBox.Show("Aplicacion Guardada Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (MessageBox.Show("La aplicacion no se pudo registrar", "Error de Registro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                        Application.Exit();
                }
            }
        }
    
    }

}
