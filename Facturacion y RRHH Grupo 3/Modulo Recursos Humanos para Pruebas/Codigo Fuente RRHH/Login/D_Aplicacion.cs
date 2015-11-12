using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionODBC;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace Login
{
    public class D_Aplicacion
    {
       

        public static DataTable Get(string saplicacion, string sidRol, string sidUser)
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                string.Format("SELECT CONCAT (TrUSUARIOTOAPLICACION.btnimprimir|| ', ' ||TrROLETOAPLICACION.btnimprimir) AS btnimprimir , (TrUSUARIOTOAPLICACION.btnnuevo || ', ' || TrROLETOAPLICACION.btnnuevo) AS btnnuevo , (TrUSUARIOTOAPLICACION.btnirUltimo || ', ' || TrROLETOAPLICACION.btnirUltimo) as btnirUltimo,(TrUSUARIOTOAPLICACION.btnirPrimero || ', ' || TrROLETOAPLICACION.btnirPrimero) as btnirPrimero, (TrUSUARIOTOAPLICACION.btnanterior || ', ' || TrROLETOAPLICACION.btnanterior) as btnanterior,(TrUSUARIOTOAPLICACION.btnsiguiente || ', ' || TrROLETOAPLICACION.btnsiguiente)AS btnsiguiente,(TrUSUARIOTOAPLICACION.btneditar || ', ' || TrROLETOAPLICACION.btneditar) AS btneditar, (TrUSUARIOTOAPLICACION.btncancelar || ', ' || TrROLETOAPLICACION.btncancelar) AS btncancelar,(TrUSUARIOTOAPLICACION.btnrefrescar || ', ' || TrROLETOAPLICACION.btnrefrescar) as btnrefrescar,(TrUSUARIOTOAPLICACION.btnbuscar || ', ' || TrROLETOAPLICACION.btnbuscar) AS btnbuscar,(TrUSUARIOTOAPLICACION.btneliminar || ', ' || TrROLETOAPLICACION.btneliminar) as btneliminar, (TrUSUARIOTOAPLICACION.btnguardar || ', ' || TrROLETOAPLICACION.btnguardar) as btnguardar FROM TrUSUARIOTOAPLICACION ,TrROLETOAPLICACION, MaAPLICACION WHERE TrUSUARIOTOAPLICACION.ncodAplicacion=MaAPLICACION.ncodAplicacion AND TrROLETOAPLICACION.ncodAplicacion = MaAPLICACION.ncodAplicacion AND MaAPLICACION.vnombreFormulario = '" + saplicacion + "' AND TrROLETOAPLICACION.ncodRole = '" + sidRol + "' AND TrUSUARIOTOAPLICACION.ncodUsuario = '" + sidUser + "'"),
                ConexionODBC.Conexion.ObtenerConexion()
            );
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch { }
            return dtRegistros;
        }

        public static DataTable ObtenerRegistros() // consulta para el grid
        {
            //DataTable dtRegistros = new DataTable();

            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                string.Format("SELECT * FROM maproveedor"),
                ConexionODBC.Conexion.ObtenerConexion()
                );

                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch { }
            return dtRegistros;

        }

        public static E_Aplicacion Consultar(E_Aplicacion eproveedor)
        {
            E_Aplicacion pCliente = new E_Aplicacion();

            try
            {
                OdbcCommand busqueda = new OdbcCommand(
                    string.Format("SELECT * FROM maproveedor WHERE ncodproveedor = '{0}'", eproveedor.Idproveedor),
                  ConexionODBC.Conexion.ObtenerConexion()
                );

                OdbcDataReader _reader = busqueda.ExecuteReader();

                if (_reader.Read())
                {
                    if (_reader.HasRows)
                    {
                        pCliente.Idproveedor = (int)_reader["ncodproveedor"];
                        pCliente.nombreproveedor = (string)_reader["vnombre"];
                        pCliente.nitproveedor = (string)_reader["vnit"];
                        pCliente.saldoproveedor = Convert.ToString(_reader["nsaldo"]);
                        pCliente.telefonoproveedor= (string)_reader["vtelefono"];
                        pCliente.ciudadproveedor = (string)_reader["vciudad"];
                        pCliente.descripcionproveedor = (string)_reader["vdescripcion"];
                        pCliente.direccionproveedor = (string)_reader["vdireccion"];
                        
                    
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return pCliente;
        }

        public void rellenarComboOrdenes(ComboBox cmb)
        {

            OdbcCommand busqueda = new OdbcCommand(
                                string.Format("SELECT ncodordencompra FROM maordencompra WHERE vstatusorden = 'inicial' or vstatusorden = 'parcial'"),
                              ConexionODBC.Conexion.ObtenerConexion()
                            );

            OdbcDataReader _reader = busqueda.ExecuteReader();

            while (_reader.Read())
            {
              //  cmb.Items.Add(_reader["ncodordencompra"].ToString());
                cmb.Items.Add(_reader["ncodordencompra"].ToString());
                
                 }
            cmb.SelectedItem = 0;
        }


    }
}