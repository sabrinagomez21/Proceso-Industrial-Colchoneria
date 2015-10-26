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

namespace Manejo_Rol
{
    public class E_Permisos
    {
         #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public bool botonNuevo { get; set; }
        public bool botonEditar { get; set; }
        public bool botonEliminar { get; set; }
        public bool botonInsertar { get; set; }
        public bool botonCancelar { get; set; }
        public bool botonActualizar { get; set; }
        public bool botonImprimir { get; set; }
        public bool botonBuscar { get; set; }
        public bool botonPrimerReg { get; set; }
        public bool botonAnterior { get; set; }
        public bool botonSiguiente { get; set; }
        public bool botonUltimoReg { get; set; }

        public string iRol { get; set; }
        public string iApp { get; set; }





        #endregion



        #region Constructor

        public E_Permisos()
        { }

        public E_Permisos(string pRol, string pApp,bool bNuevo, bool bEditar, bool bEliminar, bool bInsertar, bool bCancelar, bool bActualizar, bool bImprimir, bool bBuscar, bool bPrimero, bool bAnterior, bool bSiguiente, bool bUltimo)
        {
            this.iRol = pRol;
            this.iApp = pApp;
            this.botonNuevo = bNuevo;
            this.botonEditar = bEditar;
            this.botonEliminar = bEliminar;
            this.botonInsertar = bInsertar;
            this.botonCancelar = bCancelar;
            this.botonActualizar = bActualizar;
            this.botonImprimir = bImprimir;
            this.botonBuscar = bBuscar;
            this.botonPrimerReg = bPrimero;
            this.botonAnterior = bAnterior;
            this.botonSiguiente = bSiguiente;
            this.botonUltimoReg = bUltimo;


        }

        #endregion

    }
}
