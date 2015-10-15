using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoAsignacionAplicacion
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
            
        }
        public E_Rol EmpleadoSeleccionado { get; set; }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dvgbuscar.DataSource = D_Rol.Buscar(txtname.Text, txtlastname.Text);
        }
        private void Cargar() 
        {
            E_Rol.IdUser = Convert.ToInt16(dvgbuscar.CurrentRow.Cells[0].Value.ToString());
            E_Rol.NameUser = dvgbuscar.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {

            

            frmAsignacionAplicacion Emp = new frmAsignacionAplicacion();
            Emp.txtCodigoPerfil.Text = this.dvgbuscar.CurrentRow.Cells[0].Value.ToString();
            Emp.txtNombrePerfil.Text = this.dvgbuscar.CurrentRow.Cells[1].Value.ToString();
            Cargar();
            this.Close();
            Emp.Show();
            Emp.CargarAppAsig();
          
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        
    }
}
