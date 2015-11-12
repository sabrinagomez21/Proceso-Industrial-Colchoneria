using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionODBC;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Graficador
{
    class d_cuenta
    {        

        public static e_Grafica Consultar(string sTipoGrafica, string sCompVent, Boolean[] bMeses, int iTamano, string sTituloGrafica, string sTituloX, string sTituloY)
        {
            int iCantidadX = 0;
            int iCantidadY = 0;
            e_Grafica Grafica = new e_Grafica();
            Grafica.dx = new double[iTamano];
            Grafica.y = new double[iTamano];
            Grafica.x = new string[iTamano];
            Grafica.sGrafica = sTipoGrafica;
            Grafica.sTitulo = sTituloGrafica;
            Grafica.sEjeX = sTituloX;
            Grafica.sEjeY = sTituloY;


            try
            {
                if (bMeses[0]==true)
                {
                    Grafica.x[iCantidadX] = "Ene";
                    Grafica.dx[iCantidadX] = 01;
                    iCantidadX++;
                    if (sCompVent=="ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-01-01' AND '2015-01-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                               Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                               iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-01-01' AND '2015-01-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                               Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                               iCantidadY++;
                        }
                    }
               }

                if (bMeses[1] == true)
                {
                    Grafica.x[iCantidadX] = "Feb";
                    Grafica.dx[iCantidadX] = 02;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-02-01' AND '2015-02-28'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-02-01' AND '2015-02-28'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[2] == true)
                {
                    Grafica.x[iCantidadX] = "Mar";
                    Grafica.dx[iCantidadX] = 03;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-03-01' AND '2015-03-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-03-01' AND '2015-03-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[3] == true)
                {
                    Grafica.x[iCantidadX] = "Abr";
                    Grafica.dx[iCantidadX] = 04;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-04-01' AND '2015-04-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-04-01' AND '2015-04-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[4] == true)
                {
                    Grafica.x[iCantidadX] = "May";
                    Grafica.dx[iCantidadX] = 05;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-05-01' AND '2015-05-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-05-01' AND '2015-05-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[5] == true)
                {
                    Grafica.x[iCantidadX] = "Jun";
                    Grafica.dx[iCantidadX] = 06;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-06-01' AND '2015-06-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-06-01' AND '2015-06-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[6] == true)
                {
                    Grafica.x[iCantidadX] = "Jul";
                    Grafica.dx[iCantidadX] = 07;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-07-01' AND '2015-07-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-07-01' AND '2015-07-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[7] == true)
                {
                    Grafica.x[iCantidadX] = "Ago";
                    Grafica.dx[iCantidadX] = 08;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-08-01' AND '2015-08-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-08-01' AND '2015-08-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[8] == true)
                {
                    Grafica.x[iCantidadX] = "Sep";
                    Grafica.dx[iCantidadX] = 09;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-09-01' AND '2015-09-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-09-01' AND '2015-09-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[9] == true)
                {
                    Grafica.x[iCantidadX] = "Oct";
                    Grafica.dx[iCantidadX] = 10;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-10-01' AND '2015-10-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-10-01' AND '2015-10-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[10] == true)
                {
                    Grafica.x[iCantidadX] = "Nov";
                    Grafica.dx[iCantidadX] = 11;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-11-01' AND '2015-11-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-11-01' AND '2015-11-30'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

                if (bMeses[11] == true)
                {
                    Grafica.x[iCantidadX] = "Dic";
                    Grafica.dx[iCantidadX] = 12;
                    iCantidadX++;
                    if (sCompVent == "ventas")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE dfechaventa BETWEEN '2015-12-01' AND '2015-12-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                            iCantidadY++;
                        }

                    }
                    else if (sCompVent == "compras")
                    {
                        OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE dfecha BETWEEN '2015-12-01' AND '2015-12-31'"), ConexionODBC.Conexion.ObtenerConexion());
                        OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                        while (mySqlDLector.Read())
                        {
                            Grafica.y[iCantidadY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                            iCantidadY++;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                
            }

            return Grafica;
        }

    }
}
