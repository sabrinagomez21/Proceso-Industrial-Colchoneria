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
            dGVBitacora.DataSource = new N_Bitacora().SUSER(id, Convert.ToInt32(cmbAplicacion.SelectedValue), E_Usuario.date1, E_Usuario.date2);
            dGVBitacora.Refresh();
        }
        public void Fecha(string fech1)
        {
            dGVBitacora.DataSource = new N_Bitacora().Horarios(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue), fech1, E_Usuario.date2);
            dGVBitacora.Refresh();
        }
        public void Fechas(string fech1,string fech2)
        {
            dGVBitacora.DataSource = new N_Bitacora().Horarios(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue), fech1, fech2);
            dGVBitacora.Refresh();
        }
         private void Presentacion_Load(object sender, EventArgs e)
         {
             
             cagabox();
             ActualizarForm();

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
             cmbAplicacion.SelectedValue = 0;
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
                 dGVBitacora.DataSource = new N_Bitacora().Horarios(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue), E_Usuario.date1, E_Usuario.date2);
                 dGVBitacora.Refresh();
             }
             catch { }
         }


         private void btnFecha_Click(object sender, EventArgs e)
         {
             frmFechas consulta = new frmFechas(this);
             consulta.Show();
         }

    }
}
