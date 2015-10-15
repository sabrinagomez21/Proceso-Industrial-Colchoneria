using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class Presentacion : Form
    {
        private Presentacion instace;
        
         public Presentacion()
        {
            InitializeComponent();
            instace = this;
        }
        public void Usuario(int id){
            dGVBitacora.DataSource = new N_Bitacora().SUSER(id);
            dGVBitacora.Refresh();
        }
         private void Presentacion_Load(object sender, EventArgs e)
         {
             ActualizarForm();
             cagabox();
         }
         private void ActualizarForm()
         {
             try
             {
                 dGVBitacora.DataSource = new N_Bitacora().GetAll();
                 dGVBitacora.Refresh();
             }
             catch (Exception Ex)
             {
                 
             }
         }
        

         private void btnsearch_Click(object sender, EventArgs e)
         {
             frmConsulta consulta = new frmConsulta(this);
             E_Usuario.id = 0;
             consulta.Show();
         }

         private void cagabox() 
         {
             cmbAplicacion.DataSource = new N_Bitacora().aplicacion();
             cmbAplicacion.DisplayMember = "vnombreAplicacion";
             cmbAplicacion.ValueMember = "iidAplicacion";
             cmbAplicacion.Refresh();
         }

         private void btnRefrescar_Click(object sender, EventArgs e)
         {
             ActualizarForm();
             E_Usuario.id = 0;
         }

         private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                 dGVBitacora.DataSource = new N_Bitacora().Aplicaciones(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue));
                 dGVBitacora.Refresh();
             }
             catch { }
         }

    }
}
