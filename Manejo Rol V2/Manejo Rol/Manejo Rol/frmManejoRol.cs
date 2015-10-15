using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Manejo_Rol
{
    public partial class frmManejoRol : Form
    {
        public frmManejoRol()
        {
            InitializeComponent();
        }

        public E_Rol EmpleadoActual { get; set; }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmConsulta buscar = new frmConsulta();
            
            buscar.Show();
            
            if (buscar.EmpleadoSeleccionado != null)
            {
                EmpleadoActual = buscar.EmpleadoSeleccionado;
                txtUsuario.Text = Convert.ToString( buscar.EmpleadoSeleccionado.Id);
                txtNombreUsuario.Text = buscar.EmpleadoSeleccionado.Nombre;
              

            }
            this.Hide();
        }

        private void frmManejoRol_Load(object sender, EventArgs e)
        {
            mostrarPerfil();
            //mostrarApps();
            PresionarBotones();
        }

        private void PresionarBotones()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                btnAsignarSimple.Enabled = false;
                btnAsignarMuchos.Enabled = false;
                btnQuitarSimple.Enabled = false;
                lblQuitarMuchos.Enabled = false;
            }
        }
        public void CargarRolAsig()
        {
            try
            {
                lbRolAsignado.DisplayMember = "vnombreRole";
                lbRolAsignado.ValueMember = "iidRole";
                lbRolAsignado.DataSource = new N_Rol().RolAsig(txtUsuario.Text); // tiene todos los registro del datatable
                lbRolAsignado.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void mostrarPerfil()
        {
            try
            {
                // le asignas una fuente de datos al listbox1
                lbPerfiles.DataSource = D_Rol.consultaPerfil();
                // dysplaymember es el valor que se vera en el list
               lbPerfiles.DisplayMember = "vnombreRole";
                // valuemember es el valor del list
               lbPerfiles.ValueMember = "iidRole";
            }
            catch (Exception e)
            {

            }
        }

        private void mostrarApps()
        {
            //try
            //{
            //    // le asignas una fuente de datos al listbox1
            //    lbAppDisponibles.DataSource = D_Rol.consultaApps();
            //    // dysplaymember es el valor que se vera en el list
            //    lbAppDisponibles.DisplayMember = "vnombreAplicacion";
            //    // valuemember es el valor del list
            //    lbAppDisponibles.ValueMember = "iidAplicacion";
            //}
            //catch (Exception e)
            //{

            //}
        }

        

        private void btnAsignarSimple_Click(object sender, EventArgs e)
        {
            string sRol = lbPerfiles.GetItemText(lbPerfiles.SelectedValue);
            
            N_Rol Nego = new N_Rol();
            Nego.agregarRol(sRol, txtUsuario.Text);
            string sIdUser = txtUsuario.Text;
            lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser);
            
        }

        private int BuscarRegistro(string sRol)
        {
            int app = new N_Rol().getName_Rol(sRol);
            return app;
        }

        private void btnAsignarMuchos_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < lbPerfiles.Items.Count; i++)
                {
                    if (lbPerfiles.GetSelected(i))
                    {
                        string selectedItem = lbPerfiles.GetItemText(lbPerfiles.Items[i]).ToString();
                        //insert command
                        //MessageBox.Show(selectedItem);
                        int iiRol = BuscarRegistro(selectedItem);
                        N_Rol Nego = new N_Rol();
                        string siRol = System.Convert.ToString(iiRol);
                        string sID = txtUsuario.Text;
                        Nego.agregarRol(siRol, sID);
                        string sIdUser = txtUsuario.Text;
                        lbPerfiles.DataSource = new N_Rol().RolAsig(sIdUser);
                    }
                }
        }

        private void lblQuitarMuchos_Click(object sender, EventArgs e)
        {
            string sIdUser = txtUsuario.Text;
            for (int i = 0; i < lbRolAsignado.Items.Count; i++)
            {
                if (lbRolAsignado.GetSelected(i))
                {
                    string selectedItem = lbRolAsignado.GetItemText(lbRolAsignado.Items[i]).ToString();
                    //insert command
                    //MessageBox.Show(selectedItem);
                    int iiRol = BuscarRegistro(selectedItem);
                    N_Rol Nego = new N_Rol();
                    string siApp = System.Convert.ToString(iiRol);
                    //MessageBox.Show(siApp);

                    Nego.quitaAplicaciones(siApp, sIdUser);

                }

            }

            lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser);
        }

        private void btnQuitarSimple_Click(object sender, EventArgs e)
        {
            string sRol = lbRolAsignado.GetItemText(lbRolAsignado.SelectedValue);
            //MessageBox.Show(sApp);
            N_Rol Nego = new N_Rol();
            string sIdUser = txtUsuario.Text;
            Nego.quitaAplicaciones(sRol, sIdUser);
            lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser);
        }

    }
}
