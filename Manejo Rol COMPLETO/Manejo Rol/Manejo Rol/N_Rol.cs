using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Rol
{
    public class N_Rol:D_Rol
    {
        public System.Data.DataTable RolAsig(string sIdUser)
        {
            return D_Rol.RolAsignados(sIdUser);
        }
        //obtiene el nombre del rol
        public int getName_Rol(string sRol)
        {
            
            return D_Rol.consultarNombreRol(sRol);
        }
       
        //elimina app del rol
        public void quitaAplicaciones(string sRol, string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sRol)) // si el campo rol esta vacio
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.quitaRol(sRol, sIdUser); //manda parametros de id rol y id usuario para la capa de datos para elminar 

                if (resultado > 0)
                {
                    MessageBox.Show("rol Quitada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la rol", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
       

        //agrega rol al usuario

        public void agregarRol(string sRol, string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sRol))
            {
                MessageBox.Show("Debe Seleccionar un Rol para el usuario!", "Seleccion Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.AgregarRol(sRol, sIdUser); // ejecucion de la capa de datos del query insertar

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

        //obtiene todos los apps diponibles
        public System.Data.DataTable AppDispo()
        {
            return D_Rol.AplicacionesDisponibles();
        }

    }
}
