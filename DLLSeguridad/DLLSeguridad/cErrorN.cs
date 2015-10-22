using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DLLSeguridad
{
    public class cErrorN
    {
        public void insert(cError pEreor)
        {
            if ((pEreor.iIdUsuario==0) || (pEreor.sAccion==null))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = cErrorD.Agregar(pEreor);

                if (resultado > 0)
                {
                    MessageBox.Show("Ocurrio Un error y este fue Guardado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }

        #region consulta usuario, tipo errores  y aplicaciones
        public DataTable ErrorUsuario()
        {
            return cErrorD.Consultar();
        }
        public DataTable Aplicacion()
        {
            return cErrorD.DatosAplicacion();
        }
        public DataTable Error()
        {
            return cErrorD.DatosError();
        }
        #endregion
        public DataTable SUSER(int id,int error,int aplicacion,string fecha1,string fecha2)
        {
            switch (error)
            {
                case 0:
                    switch (aplicacion)
                    {
                        case 0:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.ConsultarUsuario(id);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsDate(id, fecha1);
                                        default:
                                            return cErrorD.Us2Date(id, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioApliacion(id,aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsAppDate(id,aplicacion, fecha1);
                                        default:
                                            return cErrorD.UsApp2Date(id, aplicacion,fecha1, fecha2);
                                    }
                            }
                    }
                default:
                    switch (aplicacion)
                    {
                        case 0:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioError(id,error);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsErrDate(id, error, fecha1);
                                        default:
                                            return cErrorD.UsErr2Date(id, error, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioErrorApliacion(id, error,aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsErrAppDate(id, error, aplicacion, fecha1);
                                        default:
                                            return cErrorD.UsErrApp2Date(id, error, aplicacion, fecha1, fecha2);
                                    }
                            }
                    }                   
            }
        }
        public DataTable ErrorAplicacion(int usuario, int error, int aplicacion, string fecha1, string fecha2)
        {
            switch (usuario)
            {
                case 0:
                    switch (error)
                    {
                        case 0:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.EApliacion(aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.AppDate(aplicacion, fecha1);
                                        default:
                                            return cErrorD.App2Date(aplicacion, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.ErrorApliacion(error, aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.ErrAppDate(error, aplicacion, fecha1);
                                        default:
                                            return cErrorD.ErrApp2Date(error, aplicacion, fecha1, fecha2);
                                    }
                            }
                    }
                default:
                    switch (aplicacion)
                    {
                        case 0:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioApliacion(usuario, aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsAppDate(usuario, aplicacion, fecha1);
                                        default:
                                            return cErrorD.UsApp2Date(usuario, aplicacion, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioErrorApliacion(usuario, error, aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsErrAppDate(usuario, error, aplicacion, fecha1);
                                        default:
                                            return cErrorD.UsErrApp2Date(usuario, error, aplicacion, fecha1, fecha2);
                                    }
                            }
                    }
            }
        }
        public DataTable TipoError(int usuario, int error, int aplicacion, string fecha1, string fecha2)
        {
            switch (usuario)
            {
                case 0:
                    switch (aplicacion)
                    {
                        case 0:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.Error(error);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.ErrDate(error, fecha1);
                                        default:
                                            return cErrorD.Err2Date(error, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.ErrorApliacion(error, aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.ErrAppDate(error, aplicacion, fecha1);
                                        default:
                                            return cErrorD.ErrApp2Date(error, aplicacion, fecha1, fecha2);
                                    }
                            }
                    }
                default:
                    switch (aplicacion)
                    {
                        case 0:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioError(usuario, error);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsErrDate(usuario, error, fecha1);
                                        default:
                                            return cErrorD.UsErr2Date(usuario, error, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (fecha1)
                            {
                                case null:
                                    return cErrorD.UsuarioErrorApliacion(usuario, error, aplicacion);
                                default:
                                    switch (fecha2)
                                    {
                                        case null:
                                            return cErrorD.UsErrAppDate(usuario, error, aplicacion, fecha1);
                                        default:
                                            return cErrorD.UsErrApp2Date(usuario, error, aplicacion, fecha1, fecha2);
                                    }
                            }
                    }
            }
        }
        public DataTable Fechas(int usuario, int error, int aplicacion, string fecha1, string fecha2)
        {
            switch (fecha2)
            {
                case null:
                    switch (usuario)
                    {
                        case 0:
                            switch (error)
                            {
                                case 0:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.Date(fecha1);
                                        default:
                                            return cErrorD.AppDate(aplicacion, fecha1);
                                    }
                                default:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.ErrDate(error,fecha1);
                                        default:
                                            return cErrorD.ErrAppDate(error,aplicacion, fecha1);
                                    }
                            }
                        default:
                            switch (error)
                            {
                                case 0:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.UsDate(usuario,fecha1);
                                        default:
                                            return cErrorD.UsAppDate(usuario,aplicacion, fecha1);
                                    }
                                default:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.UsErrDate(usuario,error, fecha1);
                                        default:
                                            return cErrorD.UsErrAppDate(usuario,error, aplicacion, fecha1);
                                    }
                            }
                    }
                default:
                    switch (usuario)
                    {
                        case 0:
                            switch (error)
                            {
                                case 0:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.Dates(fecha1,fecha2);
                                        default:
                                            return cErrorD.App2Date(aplicacion, fecha1, fecha2);
                                    }
                                default:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.Err2Date(error, fecha1, fecha2);
                                        default:
                                            return cErrorD.ErrApp2Date(error, aplicacion, fecha1, fecha2);
                                    }
                            }
                        default:
                            switch (error)
                            {
                                case 0:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.Us2Date(usuario, fecha1, fecha2);
                                        default:
                                            return cErrorD.UsAppDate(usuario, aplicacion, fecha1);
                                    }
                                default:
                                    switch (aplicacion)
                                    {
                                        case 0:
                                            return cErrorD.UsErr2Date(usuario, error, fecha1, fecha2);
                                        default:
                                            return cErrorD.UsErrApp2Date(usuario, error, aplicacion, fecha1, fecha2);
                                    }
                            }
                    }
            }
        }        
    }
}
