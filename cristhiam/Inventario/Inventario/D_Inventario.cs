using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;

namespace Inventario{
    #region Inico de Class
    public class D_Inventario : CAD
    {
        //Variables ODBC
        private static OdbcCommand mySqlComando;
        private static OdbcDataAdapter mySqlDAdAdaptador;

    #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Obtener Registros para Frm_InvPrincipal

        public static DataTable ObtenerRegistros()
        {
            DataTable dtInventario = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                mySqlComando = new OdbcCommand(string.Format("SELECT * FROM inventario"), CAD.ObtenerConexion());
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtInventario);//Llena la tabla dtRegistros
                CAD.ObtenerConexion().Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } return dtInventario;
        }
        #endregion

        //Autor: David Barrios
        //Fecha: 27/10/15
        #region Obtener Registros para Frm_MateriaPrima

        public static DataTable ObtenerMateria()
        {
            DataTable dtInventario = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                mySqlComando = new OdbcCommand(string.Format("SELECT producto, cantidad, descripcion FROM inventario"), CAD.ObtenerConexion());
                mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtInventario);//Llena la tabla dtRegistros
                CAD.ObtenerConexion().Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No es posible obtener el registro", "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } return dtInventario;
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Inserta Datos desde Frm_InvPrincipal
        public static int Inserta(E_Inventario eInventario)
        {
            int iValorRetorno = 0;
            try
            {//Conexion y Inserccion
                mySqlComando = new OdbcCommand(
                string.Format("Insert into dt_inventario (orden, producto, cantidad, tipo) values ('{0}','{1}','{2}','{3}')",
                eInventario.DI_orden, eInventario.producto, eInventario.DI_cantidad, eInventario.DI_tipo), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Insertar el producto o Bien ya Existe", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } return iValorRetorno;
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Insertar datos desde Frm_MateriaPrima
        public static int InsertaMateria(E_Inventario eInventario)
        {
            int iValorRetorno = 0;
            try
            {//Conexion y Inserccion
                mySqlComando = new OdbcCommand(
                string.Format("Insert into inventario (producto, cantidad, descripcion) values ('{0}','{1}','{2}')",
                eInventario.producto, eInventario.cantidad, eInventario.descripcion), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Insertar el producto o Bien ya Existe", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } return iValorRetorno;
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Actualiza(update) datos desde Frm_invPrincipal
        public static int Actualiza(E_Inventario eInventario)
        {
            int iValorRetorno = 0;
            try
            {//Conexion y Inserccion
                mySqlComando = new OdbcCommand(
                string.Format("UPDATE inventario SET cantidad = '" + eInventario.cantidad + "',  descripcion = '" + eInventario.descripcion + "' WHERE id = " + eInventario.id + ";"), CAD.ObtenerConexion());
                iValorRetorno = mySqlComando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible Insertar el Reporte o Bien ya Existe", "Error al Insertar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } return iValorRetorno;
        }
        #endregion


    }
}
