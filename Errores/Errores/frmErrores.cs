/* Creacion y Diseño: Hector Joannes Gil Cardona
 * Fecha:13/09/2015
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Errores
{
    public partial class frmErrores : Form
    {
        public int id;
        public frmErrores()
        {            
            InitializeComponent();
            cargar(id);
        }
         void cargar(int id)
        {
            dgvErroresSistema.DataSource = new cErrorN().ErrorUsuario(id);
            dgvErroresSistema.Refresh();
             //si es administrador mostrar todos los datos
            //dgvErroresSistema.DataSource = new cErrorN().ErrorAdmin();
            //dgvErroresSistema.Refresh();
        }

         private void timer1_Tick(object sender, EventArgs e)
         {
             cargar(id);
             timer1.Enabled = false;
         }
    }
}
