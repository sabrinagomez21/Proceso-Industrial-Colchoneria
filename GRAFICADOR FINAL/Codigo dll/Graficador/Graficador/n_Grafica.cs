using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficador
{
    class n_Grafica
    {
        public void CrearGrafica(e_Grafica Datos)
        {

            if (Datos.sGrafica.Equals("barras") || Datos.sGrafica.Equals("pie"))
            {
                if (string.IsNullOrWhiteSpace(Datos.sTitulo) || string.IsNullOrWhiteSpace(Datos.sEjeY) || string.IsNullOrWhiteSpace(Datos.sEjeX) || string.IsNullOrWhiteSpace(Datos.sGrafica) || Datos.x[0] == "" || Datos.y[0] == 0)
                {
                    MessageBox.Show("No es posible obtener el registro, los meses seleccionados no contienen informacion o Campos vacios!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    frmGrafica ver = new frmGrafica(Datos);
                    ver.Show();
                }

            }else if (Datos.sGrafica.Equals("lineal"))
            {
                if (Datos.dx[0] == 0 || Datos.y[0] == 0 || string.IsNullOrWhiteSpace(Datos.sTitulo) || string.IsNullOrWhiteSpace(Datos.sEjeY) || string.IsNullOrWhiteSpace(Datos.sEjeX) || string.IsNullOrWhiteSpace(Datos.sGrafica))
                {
                    MessageBox.Show("No es posible obtener el registro, los meses seleccionados no contienen informacion o Campos vacios!", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmGrafica ver = new frmGrafica(Datos);
                    ver.Show();
                }
            }

        }
    }
}
