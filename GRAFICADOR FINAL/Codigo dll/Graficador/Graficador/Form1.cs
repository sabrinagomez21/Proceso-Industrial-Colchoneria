using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;

namespace Graficador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void funCrearGrafica()
        {
            string sGrafica = "";
            int iContadorY = 0;
            int iContadorX = 0;
            string[] x = new string[12];
            double[] dx = new double[12];
            double[] y = new double[12];


            if (rbPie.Checked)
            {
                sGrafica = "pie";
            }
            else if (rbBarras.Checked)
            {
                sGrafica = "barras";
            }
            else if (rbLineal.Checked)
            {
                sGrafica = "lineal";
            }


            if (cbEnero.Checked)
            {
                x[iContadorX] = "Ene";
                dx[iContadorX] = 01;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-01-01' AND '2015-01-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }

                }
                else if (rbCompras.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-01-01' AND '2015-01-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbFebrero.Checked)
            {
                x[iContadorX] = "Feb";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-02-01' AND '2015-02-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-02-01' AND '2015-02-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbMarzo.Checked)
            {
                x[iContadorX] = "Mar";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-03-01' AND '2015-03-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-03-01' AND '2015-03-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbAbril.Checked)
            {
                x[iContadorX] = "Abr";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-04-01' AND '2015-04-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-04-01' AND '2015-04-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbMayo.Checked)
            {
                x[iContadorX] = "May";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-05-01' AND '2015-05-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-05-01' AND '2015-05-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbJunio.Checked)
            {
                x[iContadorX] = "Jun";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-06-01' AND '2015-06-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-06-01' AND '2015-06-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbJulio.Checked)
            {
                x[iContadorX] = "Jul";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-07-01' AND '2015-07-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-07-01' AND '2015-07-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbAgosto.Checked)
            {
                x[iContadorX] = "Ago";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-08-01' AND '2015-08-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-08-01' AND '2015-08-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbSeptiembre.Checked)
            {
                x[iContadorX] = "Sep";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-09-01' AND '2015-09-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-09-01' AND '2015-09-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbOctubre.Checked)
            {
                x[iContadorX] = "Oct";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-10-01' AND '2015-10-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-10-01' AND '2015-10-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbNoviembre.Checked)
            {
                x[iContadorX] = "Nov";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-11-01' AND '2015-11-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-11-01' AND '2015-11-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            if (cbDiciembre.Checked)
            {
                x[iContadorX] = "Dic";
                dx[iContadorX] = 02;
                iContadorX++;
                if (rbVentas.Checked)
                {
                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(dprecioventa) FROM maventas WHERE vfechaventa BETWEEN '2015-12-01' AND '2015-12-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(dprecioventa)"]);
                        iContadorY++;
                    }
                }
                else if (rbCompras.Checked)
                {

                    OdbcCommand mySqlComando = new OdbcCommand(string.Format("SELECT SUM(ncostototal) FROM macompra WHERE vfechacompra BETWEEN '2015-12-01' AND '2015-12-31'"), ConexionODBC.Conexion.ObtenerConexion());
                    OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                    while (mySqlDLector.Read())
                    {
                        y[iContadorY] = Convert.ToDouble(mySqlDLector["SUM(ncostototal)"]);
                        iContadorY++;
                    }
                }
            }

            //frmGrafica ver = new frmGrafica(txtTitulo.Text, txtEjex.Text, txtEjey.Text, x, y, dx,sGrafica);
            //ver.Show();

        }


        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            if (cbEnero.Checked == true || cbFebrero.Checked == true || cbMarzo.Checked == true || cbAbril.Checked == true || cbJunio.Checked == true || cbJulio.Checked == true
                || cbAgosto.Checked == true || cbSeptiembre.Checked == true || cbOctubre.Checked == true || cbNoviembre.Checked == true || cbDiciembre.Checked == true || cbEnero.Checked == true)
            {
                Boolean[] bMeses = { false, false, false, false, false, false, false, false, false, false, false, false };
                string sCompVent = "";
                string sTipoGrafica = "";
                string sTituloGrafica = txtTitulo.Text;
                string sTituloX = txtEjex.Text;
                string sTituloY = txtEjey.Text;
                int iContador = 0;

                e_Grafica dgrafica = new e_Grafica();

                if (cbEnero.Checked)
                {
                    bMeses[0] = true;
                    iContador++;
                }
                if (cbFebrero.Checked)
                {
                    bMeses[1] = true;
                    iContador++;
                }
                if (cbMarzo.Checked)
                {
                    bMeses[2] = true;
                    iContador++;
                }
                if (cbAbril.Checked)
                {
                    bMeses[3] = true;
                    iContador++;
                }
                if (cbMayo.Checked)
                {
                    bMeses[4] = true;
                    iContador++;
                }
                if (cbJunio.Checked)
                {
                    bMeses[5] = true;
                    iContador++;
                }
                if (cbJulio.Checked)
                {
                    bMeses[6] = true;
                    iContador++;
                }
                if (cbAgosto.Checked)
                {
                    bMeses[7] = true;
                    iContador++;
                }
                if (cbSeptiembre.Checked)
                {
                    bMeses[8] = true;
                    iContador++;
                }
                if (cbOctubre.Checked)
                {
                    bMeses[9] = true;
                    iContador++;
                }
                if (cbNoviembre.Checked)
                {
                    bMeses[10] = true;
                    iContador++;
                }
                if (cbDiciembre.Checked)
                {
                    bMeses[11] = true;
                    iContador++;
                }

                if (rbCompras.Checked)
                {
                    sCompVent = "compras";
                }
                else
                {
                    sCompVent = "ventas";
                }

                if (rbPie.Checked)
                {
                    sTipoGrafica = "pie";
                }
                else if (rbLineal.Checked)
                {
                    sTipoGrafica = "lineal";
                }
                else if (rbBarras.Checked)
                {
                    sTipoGrafica = "barras";
                }
                e_Grafica gr;
                gr = d_cuenta.Consultar(sTipoGrafica, sCompVent, bMeses, iContador, sTituloGrafica, sTituloX, sTituloY);
                n_Grafica nuevo = new n_Grafica();
                nuevo.CrearGrafica(gr);

            }
            else
            {
                MessageBox.Show("Ningun mes esta seleccionado!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            //funCrearGrafica();
        }
    }
}
