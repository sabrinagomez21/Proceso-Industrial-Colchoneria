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
    public class D_Permisos
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;
        public static int AgregarApp(string sRol, string sApp, bool sBNuevo, bool sBEditar, bool sBEliminar, bool sBInsertar, bool sBCancelar, bool sBActualizar, bool sBImprimir, bool sBBuscar, bool sBPrimerReg, bool sBAnterior, bool sBSiguiente, bool sBUltimoReg)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("INSERT into TrROLETOAPLICACION (iidRole,iidAplicacion,bbotonNuevo,bbotonEditar,bbotonEliminar,bbotonInsertar,bbotonCancelar,bbotonActualizar,bbotonImprimir,bbotonBuscar,bbotonPrimerReg,bbotonAnteriorReg,bbotonSigReg,bbotonUltimoReg) values (" + sRol + "," + sApp + "," + sBNuevo + "," + sBEditar + "," + sBEliminar + "," + sBInsertar + "," + sBCancelar + "," + sBActualizar + "," + sBImprimir + "," + sBBuscar + "," + sBPrimerReg + "," + sBAnterior + "," + sBSiguiente + "," + sBUltimoReg + ")"),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        public static int consultarNombreApp(string sApp)
        {
            int Id = 0;

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidAplicacion FROM MaAPLICACION where vnombreAplicacion = '" + sApp + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Id = (int)mySqlDLector["iidAplicacion"];

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return Id;
        }



        #region Consultar Registros
        public static DataTable BuscarAllRoles() // consulta para el grid
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidRole, vnombreRole FROM MaROLUSUARIO"),
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



        public static DataTable AppAsignados(string sIdRol) // consulta para las aplicaciones asignadas
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("Select TrROLETOAPLICACION.iidAplicacion, MaAPLICACION.vnombreAplicacion FROM TrROLETOAPLICACION,MaAPLICACION WHERE MaAPLICACION.iidAplicacion = TrROLETOAPLICACION.iidAplicacion and TrROLETOAPLICACION.iidRole ='" + sIdRol + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex + "No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            return dtRegistros;
        }




        protected static int quitaApp(string sIdRol,string sApp)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrROLETOAPLICACION  where iidRole = '" + sIdRol + "' and iidAplicacion = '" + sApp + "'"),
               ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }



        #region Consultar Un Registro

        public static E_Permisos Consultar(E_Permisos ePermisos)
        {
            E_Permisos pPermision = new E_Permisos();

            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT bbotonNuevo,bbotonEditar,bbotonEliminar,bbotonInsertar,bbotonCancelar,bbotonActualizar,bbotonImprimir,bbotonBuscar,bbotonPrimerReg,bbotonAnteriorReg,bbotonSigReg,bbotonUltimoReg  FROM TrROLETOAPLICACION WHERE iidRole = '{0}' AND iidAplicacion = '{1}'", ePermisos.iRol,ePermisos.iApp),
                    ConexionODBC.Conexion.ObtenerConexion()
                );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {

                        pPermision.botonNuevo = Convert.ToBoolean((Int16)mySqlDLector["bbotonNuevo"]);
                        pPermision.botonEditar = Convert.ToBoolean((Int16)mySqlDLector["bbotonEditar"]);
                        pPermision.botonEliminar = Convert.ToBoolean((Int16)mySqlDLector["bbotonEliminar"]);
                        pPermision.botonInsertar = Convert.ToBoolean((Int16)mySqlDLector["bbotonInsertar"]);
                        pPermision.botonCancelar = Convert.ToBoolean((Int16)mySqlDLector["bbotonCancelar"]);
                        pPermision.botonActualizar = Convert.ToBoolean((Int16)mySqlDLector["bbotonActualizar"]);
                        pPermision.botonImprimir = Convert.ToBoolean((Int16)mySqlDLector["bbotonImprimir"]);
                        pPermision.botonBuscar = Convert.ToBoolean((Int16)mySqlDLector["bbotonBuscar"]);
                        pPermision.botonPrimerReg = Convert.ToBoolean((Int16)mySqlDLector["bbotonPrimerReg"]);
                        pPermision.botonAnterior = Convert.ToBoolean((Int16)mySqlDLector["bbotonAnteriorReg"]);
                        pPermision.botonSiguiente = Convert.ToBoolean((Int16)mySqlDLector["bbotonSigReg"]);
                        pPermision.botonUltimoReg = Convert.ToBoolean((Int16)mySqlDLector["bbotonUltimoReg"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return pPermision;
        }
        #endregion



        public static int Actualizar(E_Permisos sPermisos)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Update TrROLETOAPLICACION set bbotonNuevo={0},bbotonEditar={1},bbotonEliminar={2},bbotonInsertar={3},bbotonCancelar={4},bbotonActualizar={5},bbotonImprimir={6},bbotonBuscar={7},bbotonPrimerReg={8},bbotonAnteriorReg={9},bbotonSigReg={10},bbotonUltimoReg={11} where iidRole={12} AND iidAplicacion={13}",
                sPermisos.botonNuevo,sPermisos.botonEditar,sPermisos.botonEliminar,sPermisos.botonInsertar,sPermisos.botonCancelar,sPermisos.botonActualizar,sPermisos.botonImprimir,sPermisos.botonBuscar,sPermisos.botonPrimerReg,sPermisos.botonAnterior,sPermisos.botonSiguiente,sPermisos.botonUltimoReg , sPermisos.iRol,sPermisos.iApp), ConexionODBC.Conexion.ObtenerConexion());

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
