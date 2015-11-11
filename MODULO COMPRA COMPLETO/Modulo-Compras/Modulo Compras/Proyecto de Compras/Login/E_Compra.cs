using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class E_Compra
    {
        //variables para el id rol y nombre
        #region Atributos y Encapsulamiento
        //  variables de busqueda usuario.
        public string descripcionC { get; set; }
        public int cantidad { get; set; }

        public int costototal { get; set; }

        public string fecha { get; set; }
        public int nodocumento { get; set; }

        //variables de insercionRol




        #endregion



        #region Constructor

        public E_Compra()
        { }

        public E_Compra(int pdocumento ,string pdescripcion, int pcantidad, int pcostototal, string pfecha)
        {
            this.descripcionC = pdescripcion;
            this.cantidad = pcantidad;
            this.costototal = pcostototal;
            this.fecha = pfecha;
            this.nodocumento = pdocumento;


        }

        #endregion
    }
}