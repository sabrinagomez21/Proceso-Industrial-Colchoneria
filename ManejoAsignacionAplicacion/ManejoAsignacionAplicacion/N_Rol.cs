using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoAsignacionAplicacion
{
    public class N_Rol:D_Rol
    {

        public System.Data.DataTable GetAll()
        {
            return D_Rol.ObtenerRegistros();
        }

        public System.Data.DataTable AppDispo()
        {
            return D_Rol.AplicacionesDisponibles();
        }
        public System.Data.DataTable AppAsig(string sIdUser)
        {
            return D_Rol.AplicacionesAsignadas(sIdUser);
        }
        public void agregaAplicaciones(string sApp, string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.AgregarApp(sApp, sIdUser);

                if (resultado > 0)
                {
                    MessageBox.Show("App Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void quitaAplicaciones(string sApp, string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.quitaApp(sApp, sIdUser);

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

        public void quitarAllApps(string sIdUser)
        {
            if (string.IsNullOrWhiteSpace(sIdUser))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.quitaAllApp( sIdUser);

                if (resultado > 0)
                {
                    MessageBox.Show("App Eliminadas Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la app", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        
        public int getName_App(string sApp)
        {
            //MessageBox.Show(D_Rol.Consultar(sApp)+ "");
            return D_Rol.consultarNombreApp(sApp);
        }
    }
}
