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

namespace DLLSeguridad
{
    public partial class frmErrores : Form
    {
        private frmErrores instace;

        public frmErrores()
        {
            InitializeComponent();
            instace = this;
            cargar();
            cargarBox();
        }
         void cargar()
        {
            dgvErroresSistema.DataSource = new cErrorN().ErrorUsuario();
            dgvErroresSistema.Refresh();
        }

         private void timer1_Tick(object sender, EventArgs e)
         {
             cargar();
             timer1.Enabled = false;
         }

         private void btnsearch_Click(object sender, EventArgs e)
         {
             frmBuscarUsuari consulta = new frmBuscarUsuari(this);
             cUsuario.id = 0;
             consulta.Show();
         }
         public void Usuario(int id)
         {
             dgvErroresSistema.DataSource = new cErrorN().SUSER(id,Convert.ToInt32(cmbError.SelectedValue),Convert.ToInt32(cmbAplicacion.SelectedValue),cUsuario.fecha1,cUsuario.fecha2);
             dgvErroresSistema.Refresh();
         }
         public void Fecha(string fecha)
         {
             dgvErroresSistema.DataSource = new cErrorN().Fechas(cUsuario.id, Convert.ToInt32(cmbError.SelectedValue), Convert.ToInt32(cmbAplicacion.SelectedValue), fecha, cUsuario.fecha2);
             dgvErroresSistema.Refresh();
         }
         public void Fechas(string fecha1,string fecha2)
         {
             dgvErroresSistema.DataSource = new cErrorN().Fechas(cUsuario.id, Convert.ToInt32(cmbError.SelectedValue), Convert.ToInt32(cmbAplicacion.SelectedValue), fecha1, cUsuario.fecha2);
             dgvErroresSistema.Refresh();
         }
        public void validar()
         {
             try
             {
                 dgvErroresSistema.DataSource = new cErrorN().TipoError(cUsuario.id, Convert.ToInt32(cmbError.SelectedValue), Convert.ToInt32(cmbAplicacion.SelectedValue), cUsuario.fecha1, cUsuario.fecha2);
                 dgvErroresSistema.Refresh();
             }
             catch { }
         }
         private void cargarBox()
         {
             cmbAplicacion.DataSource = new cErrorN().Aplicacion();
             cmbAplicacion.Refresh();
             cmbAplicacion.ValueMember = "iidAplicacion";
             cmbAplicacion.DisplayMember = "vnombreAplicacion";
             cmbAplicacion.SelectedValue = 0;

             cmbError.DataSource = new cErrorN().Error();
             cmbError.Refresh();
             cmbError.ValueMember= "iidTipo";
             cmbError.DisplayMember = "vnombre";
             cmbError.SelectedValue = 0;
         }
         private void cmbError_SelectedValueChanged(object sender, EventArgs e)
         {
             try
             {
                 dgvErroresSistema.DataSource = new cErrorN().TipoError(cUsuario.id, Convert.ToInt32(cmbError.SelectedValue), Convert.ToInt32(cmbAplicacion.SelectedValue), cUsuario.fecha1, cUsuario.fecha2);
                 dgvErroresSistema.Refresh();
             }
             catch { }
         }

         private void cmbAplicacion_SelectedValueChanged(object sender, EventArgs e)
         {
             try
             {
                 dgvErroresSistema.DataSource = new cErrorN().ErrorAplicacion(cUsuario.id, Convert.ToInt32(cmbError.SelectedValue), Convert.ToInt32(cmbAplicacion.SelectedValue), cUsuario.fecha1, cUsuario.fecha2);
                 dgvErroresSistema.Refresh();
             }
             catch { }
         }

         private void btnSalir_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void btnActualizar_Click(object sender, EventArgs e)
         {
             cargar();
             cUsuario.id = 0;
         }

         private void btnFecha_Click(object sender, EventArgs e)
         {
             frmFecha consulta = new frmFecha(this);
             consulta.Show();
         }
    }
}
