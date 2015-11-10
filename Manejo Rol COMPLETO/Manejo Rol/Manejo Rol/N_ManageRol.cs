/* Proyecto Desarrollado y Elaborado Por: Hector Joannes Gil Cardona
 * Fecha de Asignacion: 23 de Septiembre
 * Fecha de Entrega: 10 de Octubre
 * 
 */
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
        //validacion de la insercion del rol
        public void Insert_Rol(E_ManageRol pNameRol)
        {
            if (string.IsNullOrWhiteSpace(pNameRol.Nombre_Rol)) // si el campo esta vacio
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_ManageRol.AgregarRol(pNameRol); // va a ejecutar el metodo de datos para el query

                if (resultado > 0) // el valor mayor a 0 se ejecuto con exito
                {
                    MessageBox.Show("Rol Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Rol", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //obtiene la consulta de un solo rol
        public E_ManageRol GetSingle_Rol(int id)
        {
            E_ManageRol pRol = new E_ManageRol();
            pRol.Id_Rol = id;
           
            return D_ManageRol.Consultar(pRol);
        }

        // elimina el rol
        public void Delete_Rol(E_ManageRol pRol)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Rol Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (D_Rol.Eliminar(pRol.Id_Rol) > 0) // ejecuta el query el la capa de datos
                {
                    MessageBox.Show("Rol Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo eliminar el Rol", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //muestra info de roles en gridview
        public System.Data.DataTable GetAll()
        {
            return D_ManageRol.ObtenerRegistros(); // todos los registros
        }


        public void Update_Rol(E_ManageRol pRol) //actualiza el rol
        {
            if (string.IsNullOrWhiteSpace(pRol.Nombre_Rol)) // si el campo esta vacio
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (D_ManageRol.Actualizar(pRol) > 0) // si el resultado es mayor a 0 se ejecuto correctamente el metodo
                {
                    MessageBox.Show("Los datos del Rol se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



    }
}
