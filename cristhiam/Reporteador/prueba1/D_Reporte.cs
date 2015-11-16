using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;

namespace prueba1{
    #region Inico de Class
    public class D_Reporte:CAD
    {
        //Variables ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

    #endregion

        //Autor: Dennys Choy
        //Fecha: 29/10/15
        #region Consultar Registros

        public static DataTable ObtenerRegistros()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try{//Llamada de Conexion y Query
                mySqlComando = new OdbcCommand(string.Format("SELECT vnomreporte, dfechareporte FROM TrREPORTE"), CAD.ObtenerConexion());
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);//Llena la tabla dtRegistros
                CAD.ObtenerConexion().Close();
            }catch (Exception Ex){
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }return dtRegistros;
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Insertar Registro
        public static int Inserta(E_Reporte eReporte)
        {
            int iValorRetorno = 0;
            try{//Conexion y Inserccion
                mySqlComando = new OdbcCommand(
                string.Format("Insert into TrREPORTE (vnomreporte, dfechareporte, ncodaplicacion, ncodmodulo, ncodusuario) values ('{0}','{1}','{2}','{3}','{4}')",
                eReporte.vnomreporte, eReporte.dfechareporte, eReporte.ncodaplicacion, eReporte.ncodmodulo, eReporte.ncodusuario), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }catch (Exception e){
                MessageBox.Show("No es posible Insertar el Reporte o Bien ya Existe", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }return iValorRetorno;
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Eliminar Registro
        public static int Eliminar(string pId)
        {
            int iValorRetorno = 0;
            try{//Conexion y Envio de Query eliminar
                mySqlComando = new OdbcCommand(string.Format("Delete From TrREPORTE where vnomreporte='" + pId + "'"), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }catch (Exception e){
                MessageBox.Show("No es posible Eliminar el Registro", "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }return iValorRetorno;
        }

        #endregion

    }}
