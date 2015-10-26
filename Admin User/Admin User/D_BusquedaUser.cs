//Modulo de Registro y busqueda de usuarios al sistema.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo
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
       
        // en este Metodo cargamos los datos de las variables que se encuentran de la clase E_Registro
        public static List<E_Registro> Buscar(string pNombre, string pApellido)
        {
           //creamos una lista para obtener los datos necesiarios para que se ejecute nuestro query
            List<E_Registro> _lista = new List<E_Registro>();
            
            try
            {
                //Realizamos nuestro query para seleccionar los datos correspondientes al momento de ingresar el nombre o apellido del usuario.
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario , vnombreUsuario, vapellidoUsuario , vemailUsuario ,vusuario ,vpassword  FROM MAUSUARIO where vnombreUsuario LIKE '{0}' or vapellidoUsuario LIKE '{1}'", pNombre, pApellido),
               ConexionODBC.Conexion.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    //Al momento de obtener los datos de nuestro query seran almacenados en estas variables para su posterior carga en el datagrid.
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
              //si en caso ocurre un error, se desplegara el siguiente mensaje.
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista;
        }
    }
}
