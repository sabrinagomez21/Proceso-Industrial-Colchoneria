using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;

namespace DLLSeguridad
{
    public class D_ManageRol
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

       


        public static List<E_ManageRol> BuscarRegisRol(string pNombreRol)
        {
            List<E_ManageRol> _lista1 = new List<E_ManageRol>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidRole, vnombreRole FROM MaROLUSUARIO where vnombreRole ='{0}'", pNombreRol), ConexionODBC.Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();



                while (_reader.Read())
                {
                    E_ManageRol pEmpleado = new E_ManageRol();
                    pEmpleado.Id_Rol = _reader.GetInt32(0);
                    pEmpleado.Nombre_Rol = _reader.GetString(1);
                   




                    _lista1.Add(pEmpleado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista1;
        }


        #region Consultar Un Registro

        public static E_ManageRol Consultar(E_ManageRol eRol)
        {
            E_ManageRol pRol = new E_ManageRol();
           // int sInsertar = 0;
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT iidRole as 'No.', vnombreRole as 'Nombre Role' FROM MaROLUSUARIO WHERE iidRole = '{0}'", eRol.Id_Rol),
                    ConexionODBC.Conexion.ObtenerConexion()
                );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
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
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("Insert into MaROLUSUARIO (vnombreRole) values ('{0}')",
                eNameRol.Nombre_Rol),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }
        #endregion

        #region Consultar Registros
        public static DataTable ObtenerRegistros() // consulta para el grid
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidRole as 'No.', vnombreRole as 'Nombre Role' FROM MaROLUSUARIO"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }
        #endregion


        public static int Actualizar(E_ManageRol pCliente)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Update MaROLUSUARIO set vnombreRol='{0}' where iidRole={1}",
                pCliente.Nombre_Rol, pCliente.Id_Rol), ConexionODBC.Conexion.ObtenerConexion());

                retorno = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Actualizar el Registro", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return retorno;
        }

    }
}
