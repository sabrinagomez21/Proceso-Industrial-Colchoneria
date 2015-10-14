using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    public class cUsuario
    {
        public int Id { get; set; }
        public static int id;
        public string nombre { get; set; }
        

        public cUsuario()
        {

        }

        public cUsuario(int pid, string pnombre)
        {
            this.Id = pid;
            this.nombre = pnombre;
        }
    }
}
