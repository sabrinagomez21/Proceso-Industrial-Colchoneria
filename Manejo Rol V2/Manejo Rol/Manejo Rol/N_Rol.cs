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

        public int getName_Rol(string sRol)
        {
            //MessageBox.Show(D_Rol.Consultar(sApp)+ "");
            return D_Rol.consultarNombreRol(sRol);
        }
       

        public void quitaAplicaciones(string sRol, string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sRol))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.quitaRol(sRol, sIdUser);

                if (resultado > 0)
                {
                    MessageBox.Show("App Quitada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la app", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
       




       

       



      

        


        public void agregarRol(string sRol, string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sRol))
            {
                MessageBox.Show("Debe Seleccionar un Rol para el usuario!", "Seleccion Rol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.AgregarRol(sRol, sIdUser);

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


        public System.Data.DataTable AppDispo()
        {
            return D_Rol.AplicacionesDisponibles();
        }

    }
}
