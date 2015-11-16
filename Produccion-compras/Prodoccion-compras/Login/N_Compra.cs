using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class N_Compra : D_Compra
    {
        public void Insert_Compra(E_Compra pNameRol)
        {
            if (string.IsNullOrWhiteSpace(pNameRol.descripcionC)) // si el campo esta vacio
            {
                // MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Compra.AgregarCompra(pNameRol); // va a ejecutar el metodo de datos para el query

                if (resultado > 0) // el valor mayor a 0 se ejecuto con exito
                {
                    //  MessageBox.Show("Rol Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    //  MessageBox.Show("No se pudo guardar el Rol", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}