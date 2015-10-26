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
    class N_EditApli
    {
        public void Update_Aplicacion(E_RegistroAp pUser)
        {
            if (string.IsNullOrWhiteSpace(pUser.NombreAplicacion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (D_EditApli.Actualizar(pUser) > 0)
                {
                    MessageBox.Show("Los datos de la aplicacion se actualizaron correctamente", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la aplicacion", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        public void Delete_app(E_RegistroAp pRol)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar la aplicacion seleccionada", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (D_EditApli.Eliminar(pRol.Idapli) > 0)
                {
                    MessageBox.Show("Aplicacion Eliminada Correctamente!", "Aplicacion Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo eliminar Aplicacion ", "Aplicacion No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
