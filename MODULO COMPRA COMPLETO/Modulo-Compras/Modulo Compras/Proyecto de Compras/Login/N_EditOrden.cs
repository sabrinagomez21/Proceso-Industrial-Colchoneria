using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class N_EditOrden : D_EditOrden
    {
        public void Update_Orden(E_EditOrden pEdit) //actualiza el rol
        {
            if (string.IsNullOrWhiteSpace(pEdit.status) || string.IsNullOrWhiteSpace(pEdit.descripcionCompra)) // si el campo esta vacio
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (D_EditOrden.Actualizar(pEdit) > 0) // si el resultado es mayor a 0 se ejecuto correctamente el metodo
                {
                    // MessageBox.Show("Los datos del la  se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //  MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
