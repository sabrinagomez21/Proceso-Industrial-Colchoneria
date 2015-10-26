using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_User
{
    public class N_Registro : D_Registro
    {
        public void Insert_User(E_Registro pUser)
        {
            if (string.IsNullOrWhiteSpace(pUser.NombreUser) || string.IsNullOrWhiteSpace(pUser.ApellidoUser) || string.IsNullOrWhiteSpace(pUser.EmailUser) || string.IsNullOrWhiteSpace(pUser.Password) || string.IsNullOrWhiteSpace(pUser.User))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                int resultado = D_Registro.AgregarUser(pUser);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Usuario", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }





    }
}
