/* Proyecto Desarrollado y Elaborado Por: Hector Joannes Gil Cardona
 * Fecha de Asignacion: 23 de Septiembre
 * Fecha de Entrega: 10 de Octubre
 * 
 */
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace Manejo_Rol
{
    public class D_ManageRol
    {
        // comando para la ejecucion de querys
        private static OdbcCommand mySqlComando;
        // adaptador del odbc
        private static OdbcDataAdapter mySqlDAdAdaptador;

       


        public static List<E_ManageRol> BuscarRegisRol(string pNombreRol)
        {
            // lista de la clase entidad la cual obtendra los datos
            List<E_ManageRol> _lista1 = new List<E_ManageRol>();

            try
            {
                // ejecucion del query
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidRole, vnombreRole FROM MaROLUSUARIO where vnombreRole ='{0}'", pNombreRol), ConexionODBC.Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();


                // mientras el reader tenga datos
                while (_reader.Read())
                {
                    // se instancia la capa de entidad para manejar las variables
                    E_ManageRol pEmpleado = new E_ManageRol();
                    pEmpleado.Id_Rol = _reader.GetInt32(0); // obtiene el id
                    pEmpleado.Nombre_Rol = _reader.GetString(1); // obtiene el nombre del rol
                   




                    _lista1.Add(pEmpleado); // guarda todos los registros en la lista
                }
            }
            catch (Exception e)
            {
                // no obtiene el registro 
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista1;
        }


        #region Consultar Un Registro

        public static E_ManageRol Consultar(E_ManageRol eRol)
        {
            // se intancia la capa entidad para el manejo de roles
            E_ManageRol pRol = new E_ManageRol();
           
            try
            {
                // query 
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT iidRole as 'No.', vnombreRole as 'Nombre Role' FROM MaROLUSUARIO WHERE iidRole = '{0}'", eRol.Id_Rol),
                    ConexionODBC.Conexion.ObtenerConexion()
                );
                // data reader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read()) // si el lector obtiene registros
                {
                    if (mySqlDLector.HasRows)
                    {
                        // asigna el valor a las variables de la capa entidad
                        pRol.Id_Rol = (int)mySqlDLector["No."];
                        pRol.Nombre_Rol = (string)mySqlDLector["Nombre Role"];
                       


                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return pRol;
            ;
        }
        #endregion


        #region Insertar Rol Usuario
        public static int AgregarRol(E_ManageRol eNameRol)
        {
            // valor el cual se retorna para validar si se realizo bien la accion
            int iValorRetorno = 0;
            // query
            mySqlComando = new OdbcCommand(
                string.Format("Insert into MaROLUSUARIO (vnombreRole) values ('{0}')",
                eNameRol.Nombre_Rol),
                ConexionODBC.Conexion.ObtenerConexion()
            );
            // se ejecuta el query
            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno; // si el query fue realizdo exitosamente manda un valor mayor a 0
        }
        #endregion

        #region Consultar Registros
        public static DataTable ObtenerRegistros() // consulta para el grid
        {
            // datatable para guardar los registros
            DataTable dtRegistros = new DataTable();

            try
            {
                // query
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidRole as 'No.', vnombreRole as 'Nombre Role' FROM MaROLUSUARIO"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter(); // adapter para el query
                mySqlDAdAdaptador.SelectCommand = mySqlComando; // ejecuta el query
                mySqlDAdAdaptador.Fill(dtRegistros); // lena el dataTable con los registros que obtuvo del query

            }
            catch (Exception Ex)

            {
                //error al obtener el registro del query
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }
        #endregion


        public static int Actualizar(E_ManageRol pCliente)
        {
            // valor que se utiliza para verificar si el query se ejecuto correctamente
            int retorno = 0;
            try
            {
                // query
                OdbcCommand comando = new OdbcCommand(string.Format("Update MaROLUSUARIO set vnombreRole='{0}' where iidRole={1}",
                pCliente.Nombre_Rol, pCliente.Id_Rol), ConexionODBC.Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery(); // ejecuta query
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Actualizar el Registro", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //retorna el valor el cual tendria q ser mayor a 0 o 0 si en tal caso el query no se ejecuto bien
            return retorno;
        }

    }
}
