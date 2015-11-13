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

        public E_Aplicacion(int pid)
        {
            this.Id = pid;
            
        }
    }
}
