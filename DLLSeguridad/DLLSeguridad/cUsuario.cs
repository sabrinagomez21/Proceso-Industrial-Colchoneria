﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLSeguridad
{
    public class cUsuario
    {
        public int Id { get; set; }

        public static int id;

        public static string fecha1;

        public static string fecha2;
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
