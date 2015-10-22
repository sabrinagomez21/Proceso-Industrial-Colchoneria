//La función de la siguiente clase o capa es la de recibir las peticiones y devolver las respuestas tras un proceso

//Programador y Analista: José Wilfredo Chacón Cartagena
//Fecha de Asignación: 08/10/2015
//Fecha de Entrega: 21/10/2015

using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Bitacora
{
    public class N_Bitacora : D_Bitacora
    {

        //Funcion para llenar el datagrid principal con los datos obtenidos en el datatable ObtenerRegistros
        public System.Data.DataTable GetAll()
        {
            return D_Bitacora.ObtenerRegistros();
        }

        //Funcion que inserta registros a la tabla bitacora
        public void Insertar_Registro(E_Bitacora pBitacora)
        {
            int resultado = D_Bitacora.Agregar(pBitacora);
        }

        //Funcion para llena el combobox de Aplicacion con los datos obtenidos en el datatable DatosAplicacion
        public System.Data.DataTable aplicacion()
        {
            return D_Bitacora.DatosAplicacion();
        }

        //Funcion para llenar el datatable SUSER con los datos del usuario, aplicacion, fechas
        public System.Data.DataTable SUSER(int user, int iapp, string fecha, string fecha2)
        {
            if (iapp != 0 && !string.IsNullOrEmpty(fecha) && !string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.UserToAppTo2Date(user, iapp, fecha, fecha2);
            }
            else if (iapp != 0 && !string.IsNullOrEmpty(fecha) && string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.UserToAppToDate(user, iapp, fecha);
            }
            else if (iapp != 0 && string.IsNullOrEmpty(fecha) && string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.UserToAplicacion(user, iapp);
            }
            if (iapp == 0 && !string.IsNullOrEmpty(fecha) && string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.AppToDate(user, fecha);
            }
            else if (iapp == 0 && !string.IsNullOrEmpty(fecha) && !string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.AppTo2Date(user, fecha, fecha2);
            }
            else
            {
                return D_Bitacora.ObtenerUsuario(user);
            }
        }

        //Funcion para llenar el datatable Aplicaciones con los datos del usuario, aplicacion, fechas
        public System.Data.DataTable Aplicaciones(int user, int iapp, string fecha, string fecha2)
        {
            if (user != 0 && !string.IsNullOrEmpty(fecha) && !string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.UserToAppTo2Date(user, iapp, fecha, fecha2);
            }
            else if (user != 0 && !string.IsNullOrEmpty(fecha) && string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.UserToAppToDate(user, iapp, fecha);
            }
            else if (user != 0 && string.IsNullOrEmpty(fecha) && string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.UserToAplicacion(user, iapp);
            }
            if (user == 0 && !string.IsNullOrEmpty(fecha) && string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.AppToDate(iapp, fecha);
            }
            else if (user == 0 && !string.IsNullOrEmpty(fecha) && !string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.AppTo2Date(iapp, fecha, fecha2);
            }
            else
            {
                return D_Bitacora.ObtenerAplicaciones(iapp);
            }
        }
        public System.Data.DataTable Horarios(int user, int iapp,string fecha,string fecha2)
        {           
            if (user != 0 && iapp!=0 && !string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.UserToAppTo2Date(user, iapp, fecha,fecha2);
            }
            else if (user != 0 && iapp != 0 && string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.UserToAppToDate(user, iapp, fecha);
            }
            else if (user != 0 && iapp == 0 && !string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.UserTo2Date(user, fecha, fecha2);
            }
            if (user == 0 && iapp != 0 && !string.IsNullOrEmpty(fecha2))
            {
                return D_Bitacora.AppTo2Date(iapp, fecha, fecha2);
            }
            else if (user == 0 && iapp == 0 && !string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.To2Date(fecha,fecha2);
            }
            else if (user == 0 && iapp != 0 && string.IsNullOrWhiteSpace(fecha2))
            {
                return D_Bitacora.AppToDate(iapp,fecha);
            }
            else if(user != 0 && iapp == 0 && string.IsNullOrWhiteSpace(fecha2)) 
            {
                return D_Bitacora.UserToDate(user,fecha);
            }
            else
            {
                return D_Bitacora.Date(fecha);
            }
        }

    }
}
