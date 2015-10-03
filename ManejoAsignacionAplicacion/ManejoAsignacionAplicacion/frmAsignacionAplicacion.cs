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

namespace Manejo_Rol
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
            CargarAppAsig();

        }

        private void CargarAppAsig()
        {
            try
            {
                lbxAppAsignadas.DisplayMember = "vnombreAplicacion";
                lbxAppAsignadas.ValueMember = "iidAplicacion";
                lbxAppAsignadas.DataSource = new N_Rol().AppAsig(); // tiene todos los registro del datatable
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
            Nego.agregaAplicaciones(sApp);
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig();
            
        }

        private void btnQuitarSimple_Click(object sender, EventArgs e)
        {
            string sApp = lbxAppAsignadas.GetItemText(lbxAppAsignadas.SelectedValue);
            //MessageBox.Show(sApp);
            N_Rol Nego = new N_Rol();
            Nego.quitaAplicaciones(sApp);
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig();
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
                    Nego.agregaAplicaciones(siApp);
                    lbxAppAsignadas.DataSource = new N_Rol().AppAsig();
                }   
            }
        }

        private void btnQuitarMuchas_Click(object sender, EventArgs e)
        {
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
                    Nego.quitaAplicaciones(siApp);
                    
                }
                
            }
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig();
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
