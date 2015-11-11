using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class E_EditOrden
    {
        //variables para el id rol y nombre
        #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public int Id_orden { get; set; }
        public int Id_Proveedor { get; set; }

        public string descripcionCompra { get; set; }
        public int cantidad { get; set; }

        public int costototal { get; set; }

        public int id_articulo { get; set; }
        public string status { get; set; }


        //variables de insercionRol




        #endregion



        #region Constructor

        public E_EditOrden()
        { }

        public E_EditOrden(int pIdOrden, int pIdProveedor, string pdescripcionCompra, int pcantidad, int pcostoTotal, int pidArticulo, string pstatus)
        {
            this.Id_orden = pIdOrden;
            this.Id_Proveedor = pIdProveedor;
            this.descripcionCompra = pdescripcionCompra;
            this.cantidad = pcantidad;
            this.costototal = pcostoTotal;
            this.id_articulo = pidArticulo;
            this.status = pstatus;



        }

        #endregion
    }
}
