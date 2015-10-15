using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_Rol
{
    public class N_Permisos : D_Permisos
    {

        public void agregaAplicaciones(string sRol,string sApp, bool sBNuevo,bool sBEditar,bool sBEliminar,bool sBInsertar,bool sBCancelar,bool sBActualizar, bool sBImprimir, bool sBBuscar, bool sBPrimerReg, bool sBAnterior, bool sBSiguiente, bool sBUltimoReg)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Permisos.AgregarApp(sRol,sApp,sBNuevo,sBEditar,sBEliminar,sBInsertar,sBCancelar,sBActualizar,sBImprimir,sBBuscar,sBPrimerReg,sBAnterior,sBSiguiente,sBUltimoReg);

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


        public int getName_App(string sApp)
        {
            //MessageBox.Show(D_Rol.Consultar(sApp)+ "");
            return D_Permisos.consultarNombreApp(sApp);
        }

        public System.Data.DataTable AppAsig(string sIdRol)
        {
            return D_Permisos.AppAsignados(sIdRol);
        }

        public void quitaAplicaciones(string sIdRol,string sApp)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Permisos.quitaApp(sIdRol, sApp);

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


        public E_Permisos GetPermisoApp(string Rol, string App)
        {
            E_Permisos pPermiso = new E_Permisos();
            pPermiso.iRol = Rol;
            pPermiso.iApp = App;
            return D_Permisos.Consultar(pPermiso);
        }


        public void Update_Permisos(E_Permisos pRol)
        {
            if (string.IsNullOrWhiteSpace(pRol.iApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
               if (D_Permisos.Actualizar(pRol) > 0)
                {
                    MessageBox.Show("Los permisos se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


    }
}
