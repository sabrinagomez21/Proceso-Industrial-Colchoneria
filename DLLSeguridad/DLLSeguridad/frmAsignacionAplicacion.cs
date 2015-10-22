/* Creacion y Diseño: Hector Joannes Gil Cardona
 * Programador y Analista: Luis Fernando Linares Garzaro
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
        //No se pueden presionar ningun boton hasta que se seleccione algun usuario
        private void PresionarBotones()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoPerfil.Text))
            {
                btnAsignacionSimple.Enabled = false;
                btnAsignacionMuchas.Enabled = false;
                btnQuitarSimple.Enabled = false;
                btnQuitarMuchas.Enabled = false;
                btnEditar.Enabled = false;
            }

        }

        public void CargarAppAsig()
        {
            try
            {
                lbxAppAsignadas.DisplayMember = "vnombreAplicacion";
                lbxAppAsignadas.ValueMember = "iidAplicacion";
                lbxAppAsignadas.DataSource = new N_Rol().AppAsig(Convert.ToString(E_Rol.IdUser)); // tiene todos los registro del datatable
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
        //se llama para saber el nombre de la applicacion escojida
        private int BuscarRegistro(string sApp)
        {
            int app = new N_Rol().getName_App(sApp);
            return app;
        }
        //asigna las aplicacion simples 
        private void btnAsignacionSimple_Click(object sender, EventArgs e)
        {

            string sApp = lbxAppDisponibles.GetItemText(lbxAppDisponibles.SelectedValue);
            N_Rol Nego = new N_Rol();
            string sIdUser = txtCodigoPerfil.Text;
            Nego.agregaAplicaciones(sApp, sIdUser, cbNuevo(), cbInser(), cbElimina(), cbEdit(), cbBusca(), cbCancela(), cbActualiza(), cbImprime(), cbPrimRegistro(), cbAnteriorRegistro(), cbSiguienteRegistro(), cbUltimoRegistro());
            lbxAppAsignadas.DataSource = new N_Rol().AppAsig(sIdUser);

        }
        //quita las aplicaciones del usuario simples
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
                    //MessageBox.Show(selectedItem);
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Rol Nego = new N_Rol();
                    string siApp = System.Convert.ToString(iiApp);
                    string sID = txtCodigoPerfil.Text;
                    Nego.agregaAplicaciones(siApp, sID, cbNuevo(), cbInser(), cbElimina(), cbEdit(), cbBusca(), cbCancela(), cbActualiza(), cbImprime(), cbPrimRegistro(), cbAnteriorRegistro(), cbSiguienteRegistro(), cbUltimoRegistro());
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
            frmConsul buscar = new frmConsul();

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

        private bool cbNuevo()
        {
            bool bPermisoNuevo;
            if (cBNuevo.Checked)
            {
                bPermisoNuevo = true;
            }
            else
            {
                bPermisoNuevo = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoNuevo;
        }
        private bool cbInser()
        {
            bool bPermisoInserta;
            if (cBInserta.Checked)
            {
                bPermisoInserta = true;
            }
            else
            {
                bPermisoInserta = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoInserta;
        }

        private bool cbElimina()
        {
            bool bPermisoElimina;
            if (cBEliminar.Checked)
            {
                bPermisoElimina = true;
            }
            else
            {
                bPermisoElimina = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoElimina;
        }

        private bool cbEdit()
        {
            bool bPermisoEdita;
            if (cBEditar.Checked)
            {
                bPermisoEdita = true;
            }
            else
            {
                bPermisoEdita = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoEdita;
        }

        private bool cbBusca()
        {
            bool bPermisoBusca;
            if (cBBuscar.Checked)
            {
                bPermisoBusca = true;
            }
            else
            {
                bPermisoBusca = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoBusca;
        }

        private bool cbCancela()
        {
            bool bPermisoCancelar;
            if (cBCancelar.Checked)
            {
                bPermisoCancelar = true;
            }
            else
            {
                bPermisoCancelar = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoCancelar;
        }

        private bool cbActualiza()
        {
            bool bPermisoActualiza;
            if (cBActualizar.Checked)
            {
                bPermisoActualiza = true;
            }
            else
            {
                bPermisoActualiza = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoActualiza;
        }

        private bool cbImprime()
        {
            bool bPermisoImpirmir;
            if (cBImprimir.Checked)
            {
                bPermisoImpirmir = true;
            }
            else
            {
                bPermisoImpirmir = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoImpirmir;
        }

        private bool cbPrimRegistro()
        {
            bool bPermisoPrimRegis;
            if (cBPrimRegis.Checked)
            {
                bPermisoPrimRegis = true;
            }
            else
            {
                bPermisoPrimRegis = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoPrimRegis;
        }

        private bool cbAnteriorRegistro()
        {
            bool bPermisoAntRegis;
            if (cBAntRegis.Checked)
            {
                bPermisoAntRegis = true;
            }
            else
            {
                bPermisoAntRegis = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoAntRegis;
        }

        private bool cbSiguienteRegistro()
        {
            bool bPermisoSigRegis;
            if (cBSigRegis.Checked)
            {
                bPermisoSigRegis = true;
            }
            else
            {
                bPermisoSigRegis = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoSigRegis;
        }

        private bool cbUltimoRegistro()
        {
            bool bPermisoUlitimoRegis;
            if (cBUltRegis.Checked)
            {
                bPermisoUlitimoRegis = true;
            }
            else
            {
                bPermisoUlitimoRegis = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoUlitimoRegis;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            frmEditar Edita = new frmEditar();

            //Edita.txtIdUser.Text = this.txtCodigoPerfil.Text;
            //Edita.txtNameUser.Text = this.txtNombrePerfil.Text;
            Edita.txtIdUser.Text = Convert.ToString(E_Rol.IdUser);
            Edita.txtNameUser.Text = E_Rol.NameUser;

            Edita.Show();



            this.Hide();
        }
       

        private void lbxAppAsignadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sApp = lbxAppAsignadas.GetItemText(lbxAppAsignadas.SelectedValue);
            string sIdUser = Convert.ToString(E_Rol.IdUser);
            N_Rol Nego = new N_Rol();
            //Nego.PermisosAsigna(sIdUser, sApp);
            //Contador para ver cuantos permisos hay 
            int i = 0;
            lbxPermisoAsig.Items.Clear();
            foreach (int Variable in Nego.PermisosAsigna(sIdUser, sApp))
            {
                if (i == 0)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Nuevo");
                    }                
                }
                else if (i == 1)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Insertar");
                    }
                }
                else if (i == 2)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Eliminar");
                    }
                }
                else if (i == 3)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Editar");
                    }
                }
                else if (i == 4)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Buscar");
                    }
                }
                else if (i == 5)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Cancelar");
                    }
                }
                else if (i == 6)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Actualizar");
                    }
                }
                else if (i == 7)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Imprimir");
                    }
                }
                else if (i == 8)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Primer Registro");
                    }
                }
                else if (i == 9)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Anterior Registro");
                    }
                }
                else if (i == 10)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Siguente Registro");
                    }
                }
                else if (i == 11)
                {
                    if (Variable == 1)
                    {
                        lbxPermisoAsig.Items.Add("Ultimo Registro");
                    }
                }

                i++;
            }
           
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
