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
       private static OdbcCommand mySqlComando;
       private static OdbcDataAdapter mySqlDAdAdaptador;
        public static DataTable Get(string saplicacion,string sidRol,string sidUser)
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

        public static DataTable Orden()
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                string.Format("SELECT * FROM maordenproduccion"),
                ConexionODBC.Conexion.ObtenerConexion()
            );
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch { }
            return dtRegistros;
        }
        public static DataTable Material()
        {
            DataTable dtRegistros = new DataTable();
            try
            {
                OdbcCommand mySqlComando = new OdbcCommand(
                string.Format("SELECT * FROM mamaterial"),
                ConexionODBC.Conexion.ObtenerConexion()
            );
                OdbcDataAdapter mySqlDAdAdaptador = new OdbcDataAdapter();
                mySqlDAdAdaptador.SelectCommand = mySqlComando;
                mySqlDAdAdaptador.Fill(dtRegistros);

            }
            catch { }
            return dtRegistros;
        }
        public static DataTable EntregaParcial() // consulta para el grid
        {
            // datatable para guardar los registros
            DataTable dtRegistros = new DataTable();

            try
            {
                // query
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncodordenes as No_Orden,vreferenciaproducto as Producto, vinicioproduccion as Inicio_Produccion,ventregaproducto as Fecha_de_Entrega,vultimomovimiento as Fecha_Ultimo_Movimiento ,nnodocumento as No_Documento, ncantidadproductoafabricar as Cantidad_a_Fabricar,ncantidadnoproductoterminado as Cantidad_Producto_Terminado, ncantidadproductofaltante as Producto_Faltante,vestatusorden as Estado_Orden FROM maordenproduccion"),
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
        public static DataTable ProductoTerminado() // consulta para el grid
        {
            // datatable para guardar los registros
            DataTable dtRegistros = new DataTable();

            try
            {
                // query
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncodordenes as No_Orden,vreferenciaproducto as Producto, vinicioproduccion as Inicio_Produccion,ventregaproducto as Fecha_de_Entrega,vultimomovimiento as Fecha_Ultimo_Movimiento ,nnodocumento as No_Documento, ncantidadproductoafabricar as Cantidad_a_Fabricar,ncantidadnoproductoterminado as Cantidad_Producto_Terminado, ncantidadproductofaltante as Producto_Faltante,vestatusorden as Estado_Orden FROM maordenproduccion"),
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
        public static DataTable Recetas() // consulta para el grid
        {
            // datatable para guardar los registros
            DataTable dtRegistros = new DataTable();

            try
            {
                // query
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT mareceta.vnombrereceta as Nombre_receta, mamaterial.vnombre as Nombre_material, trdetallereceta.ncantidad as Total "+
                                   " FROM mareceta INNER JOIN trdetallereceta ON mareceta.ncodreceta = trdetallereceta.ncodreceta ,mamaterial"),
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

        public static List<string> InfoOrden(string idorden)
        {
            //inicializamos una lista de tipo string
            List<string> OrdenLista = new List<string>();
            //declaramos una variable de tipo string
            string Producto = "";
            string Cantidad = "";
            string Entrega = "";
            try
            {
                //asignamos el query hacia el odbccomand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vreferenciaproducto,ncantidadproductoafabricar,ventregaproducto FROM maordenproduccion where ncodordenes = " + idorden + ""),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecuta el query hacia un datareader
                OdbcDataReader _reader = mySqlComando.ExecuteReader();
                //lee los datos mientras hallan datos
                while (_reader.Read())
                {
                    //asigna la la primera columna encontrada hacia la variable
                    Producto = _reader.GetString(0);
                    Cantidad = _reader.GetString(1);
                    Entrega = _reader.GetString(2);
                    //añade la varible hacia la lista 
                    OrdenLista.Add(Producto);
                    OrdenLista.Add(Cantidad);
                    OrdenLista.Add(Entrega);
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve la lista con el nombre de las aplicaciones
            return OrdenLista;
        }

        public static int CantProdFabricar(string NoOrden)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            int CantFabrica = 0;
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncantidadproductoafabricar FROM maordenproduccion where ncodordenes ='" + NoOrden + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        CantFabrica = Convert.ToInt16(mySqlDLector["ncantidadproductoafabricar"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return CantFabrica;
        }

        public static string nombreProd(string NoOrden)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            string name = "";
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vreferenciaproducto FROM maordenproduccion"+
                                    " WHERE maordenproduccion.ncodordenes ='" + NoOrden + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        name = Convert.ToString(mySqlDLector["vreferenciaproducto"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return name;
        }

        public static string nombreProd2(string nameProd)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            string name = "";
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT vnombre FROM maproducto" +
                                    " WHERE vnombre = '" + nameProd + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        name = Convert.ToString(mySqlDLector["vnombre"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return name;
        }
        public static string idProd2(string nameProd)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            string id = "";
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncodarticulo FROM maproducto" +
                                    " WHERE vnombre = '" + nameProd + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        id = Convert.ToString(mySqlDLector["ncodarticulo"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return id;
        }

        public static int CantProdTerminado(string NoOrden)
        {
            //declaramos una variable string inicializandola con una cadena vacia
            int CantTermina = 0;
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT ncantidadnoproductoterminado FROM maordenproduccion where ncodordenes ='" + NoOrden + "'"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader mySqlDLector = mySqlComando.ExecuteReader();
                //si el datareader lee
                if (mySqlDLector.Read())
                {
                    //si el datareader tiene filas
                    if (mySqlDLector.HasRows)
                    {
                        //asigna el nombre del rol ala variable name
                        CantTermina = Convert.ToInt16(mySqlDLector["ncantidadnoproductoterminado"]);
                    }
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return CantTermina;
        }
        public static int LastID()
        {
            //declaramos una variable string inicializandola con una cadena vacia
            int lastid = 0;
            try
            {
                //asignamos el query a odbccommand
                mySqlComando = new OdbcCommand(
                     string.Format("SELECT COUNT(*) FROM MaRECETA"),
                     ConexionODBC.Conexion.ObtenerConexion()
                 );
                //ejecutamos el query y lo asignamos a un datareader
                OdbcDataReader _reader = mySqlComando.ExecuteReader();
                //se ejecuta mientras encuentre datos
                while (_reader.Read())
                {
                    //encuentra la primer colmuna y la asigna a la variable
                    lastid = _reader.GetInt16(0);
                    //añade la variable ala lista
                    
                }
            }
            catch (Exception e)
            {
                //muestra un mensaje de error
                MessageBox.Show("No es posible obtener el registro" + e, "Error al Realizar la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //devuelve el nombre del rol que esta asignado al usuario
            return lastid;
        }
    }
}
