using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Admin_User
{
    public class D_BusquedaUser
    {
        public static List<E_Registro> Buscar(string pNombre, string pApellido)
        {
            List<E_Registro> _lista = new List<E_Registro>();
            
            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario , vnombreUsuario, vapellidoUsuario , vemailUsuario ,vusuario ,vpassword  FROM MAUSUARIO where vnombreUsuario LIKE '{0}' or vapellidoUsuario LIKE '{1}'", pNombre, pApellido),
               ConexionODBC.Conexion.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    E_Registro pEmpleado = new E_Registro();
                    pEmpleado.IdUser = _reader.GetInt32(0);
                    pEmpleado.NombreUser = _reader.GetString(1);
                    pEmpleado.ApellidoUser = _reader.GetString(2);
                    pEmpleado.EmailUser = _reader.GetString(3);
                    pEmpleado.User = _reader.GetString(4);
                    pEmpleado.Password = _reader.GetString(5);




                    _lista.Add(pEmpleado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista;
        }
    }
}
