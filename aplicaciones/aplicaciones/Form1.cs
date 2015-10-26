using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicaciones
{
    public partial class frmaplicacionNueva : Form
    {
        public frmaplicacionNueva()
        {
            InitializeComponent();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void gbRegistro_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            E_RegistroAp pUser = new E_RegistroAp();
            pUser.NombreAplicacion = txtNombreaplicacion .Text.Trim();
            pUser.NormbreForm= txtNombreFormulario .Text.Trim();
            
            new N_RegistroAp().Insert_User(pUser);
            txtNombreaplicacion.ResetText();
            txtNombreFormulario .ResetText();
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmaplicacionNueva nueva = new frmaplicacionNueva();
            nueva.Close();
           
            frmBuscarApli buscar = new frmBuscarApli ();
            buscar.Show();

            
        }
    }
}
