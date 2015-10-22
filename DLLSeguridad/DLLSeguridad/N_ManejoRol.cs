using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLSeguridad
{
    public class N_ManejoRol:D_ManejoRol
    {

        public void Insert_Rol(E_ManejoRol pNameRol)
        {
            if (string.IsNullOrWhiteSpace(pNameRol.Nombre))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_ManejoRol.AgregarRol(pNameRol);

                if (resultado > 0)
                {
                    MessageBox.Show("Rol Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Rol", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

       




        //muestra info de roles en gridview
        public System.Data.DataTable GetAll()
        {
            return D_ManejoRol.ObtenerRegistros();
        }

        public E_ManejoRol GetSingle_Rol(int id)
        {
            E_ManejoRol pRol = new E_ManejoRol();
            pRol.Id = id;
            return D_ManejoRol.Consultar(pRol);
        }



        public void Delete_Rol(E_ManejoRol pRol)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Rol Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (D_ManejoRol.Eliminar(pRol.Id) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public void Update_Rol(E_ManejoRol pRol)
        {
            if (string.IsNullOrWhiteSpace(pRol.Nombre))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (D_ManejoRol.Actualizar(pRol) > 0)
                {
                    MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
