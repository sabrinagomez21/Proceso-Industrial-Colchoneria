using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class E_Aplicacion
    {
        public static int IdApp;

        public int Id { get; set; }
       // public int btnImprimir { get; set; }

        public E_Aplicacion(){}


        public int Idproveedor { get; set; }
        public string nitproveedor { get; set; }
        public string saldoproveedor { get; set; }
        public string descripcionproveedor { get; set; }
        public string telefonoproveedor { get; set; }
        public string ciudadproveedor { get; set; }
        public string nombreproveedor { get; set; }
        public string direccionproveedor { get; set; }



        public int codcompra { get; set; }
        public int codproveedor { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public int costototal { get; set; }
        public int codarticulo { get; set; }
        public string estatusorden { get; set; }





        
        public E_Aplicacion(int pid)
        {
            this.Id = pid;
            
        }
    }
}
