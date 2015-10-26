//Clase en la cual se ejecutaran el query de la busqueda de un usuario.
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
using ConexionODBC;
using System.Windows.Forms;

namespace aplicaciones
{
    class D_BusquedaApli
    {
        // Mandaremos a llamar a las variables que fueron declaradas en la capa E_RegistroAp
        public static List<E_RegistroAp> Buscar(string pNombreApli)
        {
            List<E_RegistroAp> _lista = new List<E_RegistroAp>();// crearemos una lista en la que se alamcenaran todos los valores de las cajas de texto.

            try
            {
                //query que nos dara el resultado al buscar una aplicacion.
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidAplicacion,vnombreAplicacion,vformulario  FROM MAAPLICACION where vnombreAplicacion ='" + pNombreApli + "'"),
               ConexionODBC.Conexion.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    // En estas variables cargaremos los valores obtenidos al momento de la ejecucion de nuestro query
                    E_RegistroAp pAplicacion = new E_RegistroAp();
                    pAplicacion.Idapli = _reader.GetInt32(0);
                    pAplicacion.NombreAplicacion = _reader.GetString(1);
                    pAplicacion.NormbreForm = _reader.GetString(2);




                    _lista.Add(pAplicacion);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista; //Variable por la cual enviaremos el resultado de nuestra busqueda.
        }

        

    }
}
