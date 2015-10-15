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

        public System.Data.DataTable PermisAsig(string sIdUser, string sApp)
        {
            return D_Rol.PermisosAsignadosLbx(sIdUser, sApp);
        }
        public void agregaAplicaciones(string sApp, string sIdUser, bool sPerInserta, bool sPerElimina, bool sPerEdita, bool sPerBusca, bool sPerCancela)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.AgregarApp(sApp, sIdUser, sPerInserta, sPerElimina, sPerEdita, sPerBusca, sPerCancela);

                if (resultado > 0)
                {
                    MessageBox.Show("App Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la App", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        public List<int> PermisosAsigna(string sIdUser, string sApp)
        {
            return D_Rol.PermisosAsignados(sIdUser, sApp);
        }

        public void EditaAplicaciones(string sApp, string sIdUser, bool sPerInserta, bool sPerElimina, bool sPerEdita, bool sPerBusca, bool sPerCancela)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Rol.EditarApp(sApp, sIdUser, sPerInserta, sPerElimina, sPerEdita, sPerBusca, sPerCancela);

                if (resultado > 0)
                {
                    MessageBox.Show("Permisos Editados Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar los permisos", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
