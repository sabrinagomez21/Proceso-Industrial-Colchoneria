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
        private frmErrores instace;

        public frmErrores()
        {
            InitializeComponent();
            instace = this;
            cargar();
        }
         void cargar()
        {
            dgvErroresSistema.DataSource = new cErrorN().ErrorUsuario();
            dgvErroresSistema.Refresh();
             //si es administrador mostrar todos los datos
            //dgvErroresSistema.DataSource = new cErrorN().ErrorAdmin();
            //dgvErroresSistema.Refresh();
        }

         private void timer1_Tick(object sender, EventArgs e)
         {
             cargar();
             timer1.Enabled = false;
         }

         private void btnsearch_Click(object sender, EventArgs e)
         {
             frmBuscarUsuario consulta = new frmBuscarUsuario(this);
             cUsuario.id = 0;
             consulta.Show();
         }
         public void Usuario(int id)
         {
             dgvErroresSistema.DataSource = new cErrorN().SUSER(id);
             dgvErroresSistema.Refresh();
         }
    }
}
