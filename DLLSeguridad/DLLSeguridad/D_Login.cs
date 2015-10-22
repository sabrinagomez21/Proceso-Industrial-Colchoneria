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
    public class D_Login
    {
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

        public static List<E_Login> Buscar(string pNombre, string pApellido)
        {
            List<E_Login> _lista = new List<E_Login>();

          try
            {
            OdbcCommand _comando = new OdbcCommand(String.Format(
           "SELECT iidUsuario, vnombreUsuario, vapellidoUsuario, vemailUsuario FROM MAUSUARIO where vnombreUsuario ='{0}' or vapellidoUsuario='{1}'", pNombre, pApellido), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                E_Login pEmpleado = new E_Login();
                pEmpleado.Id = _reader.GetInt32(0);
                pEmpleado.Nombre = _reader.GetString(1);
               
              


                _lista.Add(pEmpleado);
            }
            }
          catch (Exception e)
          {
              MessageBox.Show("No es posible obtener el registro hahahahahahahahah" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
            return _lista;
        }

        #region Consultar Perfiles
        public static DataTable consultaPerfil()
        {
            DataTable dt1 = new DataTable();
            dt1.Clear();
            string consulta = "select iidRole,vnombreRole from MAROLUSUARIO;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, ConexionODBC.Conexion.ObtenerConexion() );
            da.Fill(dt1);
            return dt1;
        }
        #endregion

        #region Consultar Apps
        public static DataTable consultaApps()
        {
            DataTable dt2 = new DataTable();
            dt2.Clear();
            string consulta = "select iidAplicacion,vnombreAplicacion from MaAPLICACION;";
            OdbcDataAdapter da = new OdbcDataAdapter(consulta, ConexionODBC.Conexion.ObtenerConexion());
            da.Fill(dt2);
            return dt2;
        }
        #endregion


        #region Insertar Rol Usuario
        //public static int AgregarRol(E_Rol eNameRol)
        //{
        //    int iValorRetorno = 0;

        //    mySqlComando = new OdbcCommand(
        //        string.Format("Insert into MAROLUSUARIO (vnombreRol) values ('{0}')",
        //        eNameRol.NombreRol),
        //        ConexionODBC.Conexion.ObtenerConexion()
        //    );

        //    iValorRetorno = mySqlComando.ExecuteNonQuery();
        //    return iValorRetorno;
        //}

        public static int LoginD(string sUser, string sContra)
        {
            int iValorRetorno = 0;

            mySqlComando = new OdbcCommand(
                string.Format("SELECT * FROM MaUSUARIO where vusuario = '" + sUser + "' AND vpassword = '" + sContra + "' "),
                ConexionODBC.Conexion.ObtenerConexion()
            );

            iValorRetorno = mySqlComando.ExecuteNonQuery();
            return iValorRetorno;
        }

        public static int ContModu()
        {
            int Tot = 0;
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT COUNT(*) as Total FROM MaMODULO"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Tot = Convert.ToInt32(mySqlDLector["Total"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return Tot;
        }

        public static int ContAplica(int idModu)
        {
            int Tot = 0;
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT count(*) as Total FROM MaAPLICACION WHERE iidModulo = '" + idModu + "' AND bStatusModulo = 1"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Tot = Convert.ToInt32(mySqlDLector["Total"]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return Tot;
        }

        public static string NameModu(int idModu)
        {
            string Name = "";
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vNombreModulo FROM MaMODULO where iidModulo = '" + idModu + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        Name = Convert.ToString(mySqlDLector["vNombreModulo"]);

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return Name;
        }

        public static List<string> NameApUsu(int idUser)
        {
            List<string> NameAppLista = new List<string>();
            string NamesApp = "";
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombreAplicacion FROM TrUSUARIOTOAPLICACION" +
                                " INNER JOIN MaAPLICACION ON MaAPLICACION.iidAplicacion = TrUSUARIOTOAPLICACION.iidAplicacion"+
                                " WHERE TrUSUARIOTOAPLICACION.iidUsuario = " + idUser + ""),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );

                OdbcDataReader _reader = mySqlComando.ExecuteReader();

                while (_reader.Read())
                {
                    NamesApp = _reader.GetString(0);
                    NameAppLista.Add(NamesApp);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return NameAppLista;
        }

        public static List<string> NameAppli(int idAppli)
        {
            List<string> PermisoLista = new List<string>();
            string Name = "";
            
            try
            {
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombreAplicacion FROM MaAPLICACION where iidModulo = " + idAppli + "  AND bStatusModulo = 1"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );


                OdbcDataReader _reader = mySqlComando.ExecuteReader();

                while (_reader.Read())
                {
                    
                    Name = _reader.GetString(0);

                    PermisoLista.Add(Name);
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return PermisoLista;
        }
        #endregion

        public static E_Login Consultar(E_Login sUser)
        {
            E_Login pUser = new E_Login();     
            try
            {
                mySqlComando = new OdbcCommand(
                    string.Format("SELECT * FROM MaUSUARIO WHERE vusuario = '" + sUser.Usuario + "'"),
                    ConexionODBC.Conexion.ObtenerConexion()
                );
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();

                if (mySqlDLector.Read())
                {
                    if (mySqlDLector.HasRows)
                    {
                        pUser.Id = (int)mySqlDLector["iidUsuario"];
                        pUser.Nombre = (string)mySqlDLector["vnombreUsuario"];
                        pUser.Apellido = (string)mySqlDLector["vapellidoUsuario"];
                        pUser.Email = (string)mySqlDLector["vemailUsuario"];
                    }
                }
                            
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return pUser;
        }


    }
}
