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
        public System.Data.DataTable GetAll()
        {
            return D_Bitacora.ObtenerRegistros();
        }
        public void Insertar_Registro(E_Bitacora pBitacora)
        {
            int resultado = D_Bitacora.Agregar(pBitacora);
        }

        public System.Data.DataTable aplicacion()
        {
            return D_Bitacora.DatosAplicacion();
        }
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
