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
    public class N_Permisos : D_Permisos
    {
        // metodo de validacion para agregar aplicaciones con permisos
        public void agregaAplicaciones(string sRol,string sApp, bool sBNuevo,bool sBEditar,bool sBEliminar,bool sBInsertar,bool sBCancelar,bool sBActualizar, bool sBImprimir, bool sBBuscar, bool sBPrimerReg, bool sBAnterior, bool sBSiguiente, bool sBUltimoReg)
        {
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // obtiene un resultado entero al momento de ejecutar el metodo
                int resultado = D_Permisos.AgregarApp(sRol,sApp,sBNuevo,sBEditar,sBEliminar,sBInsertar,sBCancelar,sBActualizar,sBImprimir,sBBuscar,sBPrimerReg,sBAnterior,sBSiguiente,sBUltimoReg);

                if (resultado > 0)
                {
                    MessageBox.Show("App Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el App", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // obtiene el nombre de la app
        public int getName_App(string sApp)
        {
            
            return D_Permisos.consultarNombreApp(sApp);
        }

        // se obtiene datos de los permisos por medio de id del rol
        public System.Data.DataTable AppAsig(string sIdRol)
        {
            return D_Permisos.AppAsignados(sIdRol);
        }

        // elimina las aplicaciones del rol
        public void quitaAplicaciones(string sIdRol,string sApp)
        {
            //si el campo es vacio
            if (string.IsNullOrWhiteSpace(sApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Permisos.quitaApp(sIdRol, sApp); //ejecucion del metodo datos para eliminar permisos, parametros id rol y id app

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
            E_Permisos pPermiso = new E_Permisos(); //instancia para el metodo de entidad de los permisos
            pPermiso.iRol = Rol;// id rol
            pPermiso.iApp = App; //id app
            return D_Permisos.Consultar(pPermiso);
        }

        // actualiza permisos
        public void Update_Permisos(E_Permisos pRol)
        {
            if (string.IsNullOrWhiteSpace(pRol.iApp))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
               if (D_Permisos.Actualizar(pRol) > 0) //si el permiso se ejecuto correctamente
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
