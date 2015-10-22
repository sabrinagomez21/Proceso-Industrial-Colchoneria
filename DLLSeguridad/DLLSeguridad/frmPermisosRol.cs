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
    public partial class frmPermisosRol : Form
    {
        public frmPermisosRol()
        {
            InitializeComponent();
        }

        private void frmPermisosRol_Load(object sender, EventArgs e)
        {
            mostrarPerfil();
            CargarAppDispo();
            ActualizarLista();
        }


        private void ActualizarLista()
        {
            try
            {
                comboRoles.DataSource = D_Permisos.BuscarAllRoles();
                comboRoles.DisplayMember = "vnombreRole";
                // valuemember es el valor del list
                comboRoles.ValueMember = "iidRole";
               
               

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void CargarAppAsignadas()
        {
            try
            {
                lbAppsAsignadas.DisplayMember = "vnombreAplicacion";
                lbAppsAsignadas.ValueMember = "iidAplicacion";
                lbAppsAsignadas.DataSource = new N_Permisos().AppAsig(comboRoles.SelectedValue.ToString()); // tiene todos los registro del datatable
                lbAppsAsignadas.Refresh();
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
                lbPerfiles.DataSource = D_ManejoRol.consultaPerfil();
                // dysplaymember es el valor que se vera en el list
                lbPerfiles.DisplayMember = "vnombreRole";
                // valuemember es el valor del list
                lbPerfiles.ValueMember = "iidRole";
            }
            catch (Exception e)
            {

            }
        }

        private void CargarAppDispo()
        {
            try
            {
                lbAppsDisponibles.DisplayMember = "vnombreAplicacion";
                lbAppsDisponibles.ValueMember = "iidAplicacion";
                lbAppsDisponibles.DataSource = new N_ManejoRol().AppDispo(); // tiene todos los registro del datatable
                lbAppsDisponibles.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        //insercion de datos

        private int BuscarRegistro(string sApp)
        {
            int app = new N_Permisos().getName_App(sApp);
            return app;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lbAppsDisponibles.Items.Count; i++)
            {
                if (lbAppsDisponibles.GetSelected(i))
                {
                    string selectedItem = lbAppsDisponibles.GetItemText(lbAppsDisponibles.Items[i]).ToString();
                    string sRol = lbPerfiles.GetItemText(lbPerfiles.SelectedValue);

                    //MessageBox.Show(selectedItem);
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Permisos Nego = new N_Permisos();
                    string siApp = System.Convert.ToString(iiApp);
                   
                    Nego.agregaAplicaciones(sRol,siApp, cbNuevo(),cbEdit(),cbElimina(),cbInser(),cbCancela(),cbUpdate(),cbImprimir(),
                        cbBusca(),cbPrimerReg(),cbAnterior(),cbSiguiente(),cbUltimoDato());
                    CargarAppAsignadas();
                   
                }
            }
            ckboxNuevo.Checked = false;
            ckboxEditar.Checked = false;
            ckboxEliminar.Checked = false;
            ckboxInsertar.Checked = false;
            ckboxCancelar.Checked = false;
            ckboxActualizar.Checked = false;
            ckboxImprimir.Checked = false;
            ckboxBuscar.Checked = false;
            ckboxFirstData.Checked = false;
            ckboxPrevious.Checked = false;
            ckboxNext.Checked = false;
            ckboxLastData.Checked = false;
        }


        private bool cbInser()
        {
            bool bPermisoInserta;
            if (ckboxInsertar.Checked)
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

        private bool cbUpdate()
        {
            bool bPermisoActualizar;
            if (ckboxActualizar.Checked)
            {
                bPermisoActualizar = true;
            }
            else
            {
                bPermisoActualizar = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoActualizar;
        }
        private bool cbPrimerReg()
        {
            bool bPermisoPrimerReg;
            if (ckboxFirstData.Checked)
            {
                bPermisoPrimerReg = true;
            }
            else
            {
                bPermisoPrimerReg = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoPrimerReg;
        }

        private bool cbImprimir()
        {
            bool bPermisoImprimir;
            if (ckboxImprimir.Checked)
            {
                bPermisoImprimir = true;
            }
            else
            {
                bPermisoImprimir = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoImprimir;
        }

        private bool cbUltimoDato()
        {
            bool bPermisoUltimoReg;
            if (ckboxLastData.Checked)
            {
                bPermisoUltimoReg = true;
            }
            else
            {
                bPermisoUltimoReg = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoUltimoReg;
        }
      

        private bool cbSiguiente()
        {
            bool bPermisoSiguienteData;
            if (ckboxNext.Checked)
            {
                bPermisoSiguienteData = true;
            }
            else
            {
                bPermisoSiguienteData = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoSiguienteData;
        }

        private bool cbNuevo()
        {
            bool bPermisoNuevo;
            if (ckboxNuevo.Checked)
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

        private bool cbAnterior()
        {
            bool bPermisoAnterior;
            if (ckboxPrevious.Checked)
            {
                bPermisoAnterior = true;
            }
            else
            {
                bPermisoAnterior = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoAnterior;
        }
        private bool cbElimina()
        {
            bool bPermisoElimina;
            if (ckboxEliminar.Checked)
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
            if (ckboxEditar.Checked)
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
            if (ckboxBuscar.Checked)
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
            if (ckboxCancelar.Checked)
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

        private void gbPermisos_Enter(object sender, EventArgs e)
        {

        }

        private void comboRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarAppAsignadas();
            ckboxNuevo.Checked = false;
            ckboxEditar.Checked = false;
            ckboxEliminar.Checked = false;
            ckboxInsertar.Checked = false;
            ckboxCancelar.Checked = false;
            ckboxActualizar.Checked = false;
            ckboxImprimir.Checked = false;
            ckboxBuscar.Checked = false;
            ckboxFirstData.Checked = false;
            ckboxPrevious.Checked = false;
            ckboxNext.Checked = false;
            ckboxLastData.Checked = false;
            lbPerfiles.SelectionMode = SelectionMode.One;
            lbAppsDisponibles.SelectionMode = SelectionMode.MultiExtended;
            lbPerfiles.Refresh();
            lbAppsDisponibles.Refresh();
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string sIdRol = comboRoles.SelectedValue.ToString();
            for (int i = 0; i < lbAppsAsignadas.Items.Count; i++)
            {
                if (lbAppsAsignadas.GetSelected(i))
                {
                    string selectedItem = lbAppsAsignadas.GetItemText(lbAppsAsignadas.Items[i]).ToString();
                    //insert command
                    //MessageBox.Show(selectedItem);
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Permisos Nego = new N_Permisos();
                    string siApp = System.Convert.ToString(iiApp);
                    //MessageBox.Show(siApp);

                    Nego.quitaAplicaciones(sIdRol, siApp);

                }
            }
            CargarAppAsignadas();
            ckboxNuevo.Checked = false;
            ckboxEditar.Checked = false;
            ckboxEliminar.Checked = false;
            ckboxInsertar.Checked = false;
            ckboxCancelar.Checked = false;
            ckboxActualizar.Checked = false;
            ckboxImprimir.Checked = false;
            ckboxBuscar.Checked = false;
            ckboxFirstData.Checked = false;
            ckboxPrevious.Checked = false;
            ckboxNext.Checked = false;
            ckboxLastData.Checked = false;
        }

        private void BuscarApp(string sRol, string sApp)
        {
            E_Permisos Permisos = new N_Permisos().GetPermisoApp(sRol,sApp); // busca los atributos de la llave y los obtiene para cada registro 
           
            ckboxNuevo.Checked = Permisos.botonNuevo;
            ckboxEditar.Checked = Permisos.botonEditar;
            ckboxEliminar.Checked = Permisos.botonEliminar;
            ckboxInsertar.Checked = Permisos.botonInsertar;
            ckboxCancelar.Checked = Permisos.botonCancelar;
            ckboxActualizar.Checked = Permisos.botonActualizar;
            ckboxImprimir.Checked = Permisos.botonImprimir;
            ckboxBuscar.Checked = Permisos.botonBuscar;
            ckboxFirstData.Checked = Permisos.botonPrimerReg;
            ckboxPrevious.Checked = Permisos.botonAnterior;
            ckboxNext.Checked = Permisos.botonSiguiente;
            ckboxLastData.Checked = Permisos.botonUltimoReg;

        }

        private void lbAppsAsignadas_DoubleClick(object sender, EventArgs e)
        {
            string idRol = comboRoles.SelectedValue.ToString();
            string idApp = lbAppsAsignadas.SelectedValue.ToString();
            BuscarApp(idRol, idApp);
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
          
            lbPerfiles.SelectionMode = SelectionMode.None;
            lbAppsDisponibles.SelectionMode = SelectionMode.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ckboxNuevo.Checked = false;
            ckboxEditar.Checked = false;
            ckboxEliminar.Checked = false;
            ckboxInsertar.Checked = false;
            ckboxCancelar.Checked = false;
            ckboxActualizar.Checked = false;
            ckboxImprimir.Checked = false;
            ckboxBuscar.Checked = false;
            ckboxFirstData.Checked = false;
            ckboxPrevious.Checked = false;
            ckboxNext.Checked = false;
            ckboxLastData.Checked = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = true;
           
            lbPerfiles.SelectionMode = SelectionMode.One;
            lbAppsDisponibles.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ckboxNuevo.Checked = false;
            ckboxEditar.Checked = false;
            ckboxEliminar.Checked = false;
            ckboxInsertar.Checked = false;
            ckboxCancelar.Checked = false;
            ckboxActualizar.Checked = false;
            ckboxImprimir.Checked = false;
            ckboxBuscar.Checked = false;
            ckboxFirstData.Checked = false;
            ckboxPrevious.Checked = false;
            ckboxNext.Checked = false;
            ckboxLastData.Checked = false;
            lbPerfiles.SelectionMode = SelectionMode.One;
            lbAppsDisponibles.SelectionMode = SelectionMode.MultiExtended;
            lbAppsAsignadas.SelectionMode = SelectionMode.MultiExtended;
          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            E_Permisos pRol = new E_Permisos();
            pRol.iRol = comboRoles.SelectedValue.ToString();
            pRol.iApp = lbAppsAsignadas.SelectedValue.ToString();
            pRol.botonNuevo = ckboxNuevo.Checked;
            pRol.botonEditar = ckboxEditar.Checked;
            pRol.botonEliminar = ckboxEliminar.Checked;
            pRol.botonInsertar = ckboxInsertar.Checked;
            pRol.botonCancelar = ckboxCancelar.Checked;
            pRol.botonActualizar = ckboxActualizar.Checked;
            pRol.botonImprimir = ckboxImprimir.Checked;
            pRol.botonBuscar = ckboxBuscar.Checked;
            pRol.botonPrimerReg = ckboxFirstData.Checked;
            pRol.botonAnterior = ckboxPrevious.Checked;
            pRol.botonSiguiente = ckboxNext.Checked;
            pRol.botonUltimoReg = ckboxLastData.Checked;

            new N_Permisos().Update_Permisos(pRol);
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = true;

            ckboxNuevo.Checked = false;
            ckboxEditar.Checked = false;
            ckboxEliminar.Checked = false;
            ckboxInsertar.Checked = false;
            ckboxCancelar.Checked = false;
            ckboxActualizar.Checked = false;
            ckboxImprimir.Checked = false;
            ckboxBuscar.Checked = false;
            ckboxFirstData.Checked = false;
            ckboxPrevious.Checked = false;
            ckboxNext.Checked = false;
            ckboxLastData.Checked = false;
            lbPerfiles.SelectionMode = SelectionMode.One;
            lbAppsDisponibles.SelectionMode = SelectionMode.MultiExtended;
            lbAppsAsignadas.SelectionMode = SelectionMode.MultiExtended;

        }


    }
}
