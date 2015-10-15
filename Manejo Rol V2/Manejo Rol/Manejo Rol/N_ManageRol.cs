using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Rol
{
    public class N_ManageRol : D_ManageRol
    {
        public void Insert_Rol(E_ManageRol pNameRol)
        {
            if (string.IsNullOrWhiteSpace(pNameRol.Nombre_Rol))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_ManageRol.AgregarRol(pNameRol);

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


        public E_ManageRol GetSingle_Rol(int id)
        {
            E_ManageRol pRol = new E_ManageRol();
            pRol.Id_Rol = id;
            //return D_Rol.Consultar(pRol,sPerInserta);
            return D_ManageRol.Consultar(pRol);
        }


        public void Delete_Rol(E_ManageRol pRol)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Rol Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (D_Rol.Eliminar(pRol.Id_Rol) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //muestra info de roles en gridview
        public System.Data.DataTable GetAll()
        {
            return D_ManageRol.ObtenerRegistros();
        }


        public void Update_Rol(E_ManageRol pRol)
        {
            if (string.IsNullOrWhiteSpace(pRol.Nombre_Rol))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (D_ManageRol.Actualizar(pRol) > 0)
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
