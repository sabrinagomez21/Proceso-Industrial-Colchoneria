﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Frm_Reporte(int modulo, int form, string nombre));
            Frm_Reporte FormCarga = new Frm_Reporte(1,1,"cris");
            FormCarga.Show();
        }
    }
}
