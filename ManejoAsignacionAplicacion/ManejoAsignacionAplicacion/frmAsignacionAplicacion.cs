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

namespace ManejoAsignacionAplicacion
{
    public partial class frmAsignacionAplicacion : Form
    {
        public frmAsignacionAplicacion()
        {
            InitializeComponent();
        }

        private void frmAsignacionAplicacion_Load(object sender, EventArgs e)
        {
            //CargarDatos();
            CargarAppDispo();
            PresionarBotones();
            

        }

        private void PresionarBotones()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoPerfil.Text))
            {
                btnAsignacionSimple.Enabled = false;
                btnAsignacionMuchas.Enabled = false;
                btnQuitarSimple.Enabled = false;
                btnQuitarMuchas.Enabled = false;
            }
        }

        public void CargarAppAsig()
        {
            try
            {
                lbxAppAsignadas.DisplayMember = "vnombreAplicacion";
                lbxAppAsignadas.ValueMember = "iidAplicacion";
                lbxAppAsignadas.DataSource = new N_Rol().AppAsig(txtCodigoPerfil.Text); // tiene todos los registro del datatable
                lbxAppAsignadas.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            } 
        }

        private void CargarAppDispo()
        {
            try
            {
                lbxAppDisponibles.DisplayMember = "vnombreAplicacion";
                lbxAppDisponibles.ValueMember = "iidAplicacion";
                lbxAppDisponibles.DataSource = new N_Rol().AppDispo(); // tiene todos los registro del datatable
                lbxAppDisponibles.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            } 
        }

        private int BuscarRegistro(string sApp)
        {
            int app = new N_Rol().getName_App(sApp);
            return app;
        }

        private void btnAsignacionSimple_Click(object sender, EventArgs e)
        {
            string sApp = lbxAppDisponibles.GetItemText(lbxAppDisponibles.SelectedValue);
            MessageBox.Show(sApp);
            N_Rol Nego = new N_Rol();
            Nego.agregaAplicaciones(sApp, txtCodigoPerfil.Text);
            string sIdUser = txtCodigoPerfil.Text;
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig(sIdUser);
            
        }

        private void btnQuitarSimple_Click(object sender, EventArgs e)
        {
            string sApp = lbxAppAsignadas.GetItemText(lbxAppAsignadas.SelectedValue);
            //MessageBox.Show(sApp);
            N_Rol Nego = new N_Rol();
            string sIdUser = txtCodigoPerfil.Text;
            Nego.quitaAplicaciones(sApp, sIdUser);       
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig(sIdUser);
        }

        private void btnAsignacionMuchas_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < lbxAppDisponibles.Items.Count; i++)
            {
                if (lbxAppDisponibles.GetSelected(i))
                {
                    string selectedItem = lbxAppDisponibles.GetItemText(lbxAppDisponibles.Items[i]).ToString();
                    //insert command
                    //MessageBox.Show(selectedItem);
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Rol Nego = new N_Rol();
                    string siApp = System.Convert.ToString(iiApp);
                    string sID = txtCodigoPerfil.Text;
                    Nego.agregaAplicaciones(siApp, sID);
                    string sIdUser = txtCodigoPerfil.Text;
                    lbxAppAsignadas.DataSource = new N_Rol().AppAsig(sIdUser);
                }   
            }
        }

        private void btnQuitarMuchas_Click(object sender, EventArgs e)
        {
            string sIdUser = txtCodigoPerfil.Text;
            for (int i = 0; i < lbxAppAsignadas.Items.Count; i++)
            {
                if (lbxAppAsignadas.GetSelected(i))
                {
                    string selectedItem = lbxAppAsignadas.GetItemText(lbxAppAsignadas.Items[i]).ToString();
                    //insert command
                    //MessageBox.Show(selectedItem);
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Rol Nego = new N_Rol();
                    string siApp = System.Convert.ToString(iiApp);
                    //MessageBox.Show(siApp);
                    
                    Nego.quitaAplicaciones(siApp, sIdUser);   
                    
                }
                
            }
            
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig(sIdUser);
        }
        public E_Rol EmpleadoActual { get; set; }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmConsulta buscar = new frmConsulta();

            buscar.Show();

            if (buscar.EmpleadoSeleccionado != null)
            {
                EmpleadoActual = buscar.EmpleadoSeleccionado;
                txtCodigoPerfil.Text = Convert.ToString(buscar.EmpleadoSeleccionado.Id);
                txtNombrePerfil.Text = buscar.EmpleadoSeleccionado.Nombre;


            }
            this.Hide();
            
        }

        private void btnLimpiarPerfil_Click(object sender, EventArgs e)
        {
            string sIdUser = txtCodigoPerfil.Text;
            N_Rol Nego = new N_Rol();
            Nego.quitarAllApps(sIdUser);
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig(sIdUser);
        }

        

        //private void CargarDatos()
        //{
        //    try
        //    {
        //        lbxAppAsignadas.DisplayMember = "NombreCompleto";
        //        lbxAppAsignadas.ValueMember = "iidUsuario";
        //        lbxAppAsignadas.DataSource = new N_Rol().GetAll(); // tiene todos los registro del datatable
        //        lbxAppAsignadas.Refresh();
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    } 
        //}


    }
}
