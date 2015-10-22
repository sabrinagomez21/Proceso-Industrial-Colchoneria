//using MySql.Data.MySqlClient;
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
    public class D_Rol 
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        #region Consultar Registros
        public static DataTable ObtenerRegistros() // consulta para el grid
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT iidUsuario, CONCAT(`vnombreUsuario`,' - ',`vapellidoUsuario`) AS NombreCompleto FROM MaUSUARIO"),
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
        public static DataTable AplicacionesDisponibles() // consulta para las aplicaciones disponibles
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT * FROM MaAPLICACION"),
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

        public static List<int> PermisosAsignados(string sIdUser, string sApp)
        {
            List<int> PermisoLista = new List<int>();
            int botonNuevo = 0;
            int botonInsertar = 0;
            int botonEliminar = 0;
            int botonEditar = 0;
            int botonBuscar = 0;
            int botonCancelar = 0;
            int botonActualizar = 0;
            int botonImprimir = 0;
            int botonPrimerRegistro = 0;
            int botonAnteriorRegistro = 0;
            int botonSiguienteRegistro = 0;
            int botonUltimoRegistro = 0;

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT bbotonNuevo,bbotonInsertar, bbotonEliminar,bbotonEditar," +
                                " bbotonBuscar,bbotonCancelar,bbotonActualizar,"+
                                 " bbotonImprimir,bbotonPrimerReg, bbotonAnteriorReg, bbotonSigReg, bbotonUltimoReg  FROM MaUSUARIO" +
                                " INNER JOIN TrUSUARIOTOAPLICACION ON MaUSUARIO.iidUsuario = TrUSUARIOTOAPLICACION.iidUsuario" +
                                " INNER JOIN MaAPLICACION ON MaAPLICACION.iidAplicacion = TrUSUARIOTOAPLICACION.iidAplicacion" +
                                 " WHERE TrUSUARIOTOAPLICACION.iidUsuario = '" + sIdUser + "' AND TrUSUARIOTOAPLICACION.iidAplicacion = " + sApp),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader _reader = mySqlComando.ExecuteReader();

                while (_reader.Read())
                {
                    botonNuevo = _reader.GetInt32(0);
                    botonInsertar = _reader.GetInt32(1);
                    botonEliminar = _reader.GetInt32(2);
                    botonEditar = _reader.GetInt32(3);
                    botonBuscar = _reader.GetInt32(4);
                    botonCancelar = _reader.GetInt32(5);
                    botonActualizar = _reader.GetInt32(6);
                    botonImprimir = _reader.GetInt32(7);
                    botonPrimerRegistro = _reader.GetInt32(8);
                    botonAnteriorRegistro = _reader.GetInt32(9);
                    botonSiguienteRegistro = _reader.GetInt32(10);
                    botonUltimoRegistro = _reader.GetInt32(11);
                    PermisoLista.Add(botonNuevo);
                    PermisoLista.Add(botonInsertar);
                    PermisoLista.Add(botonEliminar);
                    PermisoLista.Add(botonEditar);
                    PermisoLista.Add(botonBuscar);
                    PermisoLista.Add(botonCancelar);
                    PermisoLista.Add(botonActualizar);
                    PermisoLista.Add(botonImprimir);
                    PermisoLista.Add(botonPrimerRegistro);
                    PermisoLista.Add(botonAnteriorRegistro);
                    PermisoLista.Add(botonSiguienteRegistro);
                    PermisoLista.Add(botonUltimoRegistro);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return PermisoLista;
        }

        public static DataTable AplicacionesAsignadas(string sIdUser) // consulta para las aplicaciones asignadas
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT TrUSUARIOTOAPLICACION.iidAplicacion,vnombreAplicacion FROM MaAPLICACION INNER JOIN TrUSUARIOTOAPLICACION ON TrUSUARIOTOAPLICACION.iidAplicacion = MaAPLICACION.iidAplicacion where iidUsuario = '" + sIdUser + "'"),
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

        public static int AgregarApp(string sApp, string sId, bool sPerNuevo, bool sPerInsertar, bool sPerEliminar, bool sPerEditar, bool sPerBuscar, bool sPerCancelar, bool sPerActulizar, bool sPerImprimir, bool sPerPrimReg, bool sPerAntReg, bool sPerSigReg, bool sPerUltReg)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("INSERT into TrUSUARIOTOAPLICACION (iidUsuario, iidAplicacion, bbotonNuevo,bbotonInsertar,bbotonEliminar,bbotonEditar,bbotonBuscar,bbotonCancelar,bbotonActualizar,bbotonImprimir, bbotonPrimerReg ,bbotonAnteriorReg,bbotonSigReg,bbotonUltimoReg) " +
            "values (" + sId + "," + sApp + "," + sPerNuevo + "," + sPerInsertar + "," + sPerEliminar + "," + sPerEditar + "," + sPerBuscar + "," + sPerCancelar + "," + sPerActulizar + "," + sPerImprimir + "," + sPerPrimReg + "," + sPerAntReg + "," + sPerSigReg + "," + sPerUltReg + ")"),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }


        protected static int quitaApp(string sApp, string sIdUser)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrUSUARIOTOAPLICACION  where iidUsuario = '" + sIdUser + "' and iidAplicacion = '" + sApp + "'"),
               ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        protected static int quitaAllApp(string sIdUser)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("DELETE from TrUSUARIOTOAPLICACION  where iidUsuario = '" + sIdUser + "'"),
               ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        public static List<E_Rol> Buscar(string pNombre, string pApellido)
        {
            List<E_Rol> _lista = new List<E_Rol>();

            try
            {
                OdbcCommand _comando = new OdbcCommand(String.Format(
               "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario, vemailUsuario FROM MAUSUARIO where vnombreUsuario ='{0}' or vapellidoUsuario='{1}'", pNombre, pApellido),
               ConexionODBC.Conexion.ObtenerConexion()
               );
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    E_Rol pEmpleado = new E_Rol();
                    pEmpleado.Id = _reader.GetInt32(0);
                    pEmpleado.Nombre = _reader.GetString(1);
                    pEmpleado.Apellido = _reader.GetString(2);




                    _lista.Add(pEmpleado);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return _lista;
        }


        public static int EditarApp(string sApp, string sId, bool sPerNuevo, bool sPerInsertar, bool sPerEliminar, bool sPerEditar, bool sPerBuscar, bool sPerCancelar, bool sPerActulizar, bool sPerImprimir, bool sPerPrimReg, bool sPerAntReg, bool sPerSigReg, bool sPerUltReg)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("UPDATE TrUSUARIOTOAPLICACION SET bbotonNuevo = " + sPerNuevo + ",bbotonInsertar = " + sPerInsertar + " ,bbotonEliminar = " + sPerEliminar + " ,bbotonEditar = " + sPerEditar + ",bbotonBuscar = " + sPerBuscar + " ,bbotonCancelar = " + sPerCancelar + " ,bbotonActualizar = " + sPerActulizar + ",bbotonImprimir = " + sPerImprimir + ",bbotonPrimerReg = " + sPerPrimReg + ",bbotonAnteriorReg = " + sPerAntReg + ",bbotonSigReg = " + sPerSigReg + ",bbotonUltimoReg = " + sPerUltReg + " WHERE TrUSUARIOTOAPLICACION.iidUsuario = '" + sId + "' AND TrUSUARIOTOAPLICACION.iidAplicacion = '" + sApp + "'"),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        public static DataTable PermisosAsignadosLbx(string sIdUser, string sApp) // consulta para las aplicaciones asignadas
        {
            DataTable dtRegistros = new DataTable();

            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT TrUSUARIOTOAPLICACION.bbotonInsertar, TrUSUARIOTOAPLICACION.bbotonEliminar,"+
                            "TrUSUARIOTOAPLICACION.bbotonEditar, TrUSUARIOTOAPLICACION.bbotonBuscar,"+
                            "TrUSUARIOTOAPLICACION.bbotonCancelar FROM MaUSUARIO "+
                            " INNER JOIN TrUSUARIOTOAPLICACION ON MaUSUARIO.iidUsuario = TrUSUARIOTOAPLICACION.iidUsuario"+
                            " INNER JOIN MaAPLICACION ON MaAPLICACION.iidAplicacion = TrUSUARIOTOAPLICACION.iidAplicacion"+
                            " WHERE MaUSUARIO.iidUsuario = '" + sIdUser + "' AND TrUSUARIOTOAPLICACION.iidAplicacion = '" + sApp + "'"),
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
    }
}
