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
    public partial class frmPermisosRol : Form
    {
        public frmPermisosRol()
        {
            InitializeComponent();
        }
        //muestra toda la data del formulario
        private void frmPermisosRol_Load(object sender, EventArgs e)
        {
            mostrarPerfil(); // muestra todos los roles
            CargarAppDispo(); // muestra las applicaciones disponibles
            ActualizarLista(); // muestra los roles  en un combobox junto con las apps asignadas
        }


        private void ActualizarLista()
        {
            try
            {
                // carga los roles en el combobox
                comboRoles.DataSource = D_Permisos.BuscarAllRoles();
                comboRoles.DisplayMember = "vnombreRole"; // muestra los nombre de los roles
                // valuemember es el valor del list
                comboRoles.ValueMember = "iidRole";  // cada rol obtiene su id
               
               

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
                //carga al listbox las apps asignadas
                lbAppsAsignadas.DisplayMember = "vnombreAplicacion"; // muestra las apps
                lbAppsAsignadas.ValueMember = "iidAplicacion"; // a cada app le asigna un id
                lbAppsAsignadas.DataSource = new N_Permisos().AppAsig(comboRoles.SelectedValue.ToString()); // tiene todos los registro del datatable
                lbAppsAsignadas.Refresh(); // refresca el listbox
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

        private void CargarAppDispo()
        {
            try
            {
                // carga todas apps que se le pueden asignar al usuario
                lbAppsDisponibles.DisplayMember = "vnombreAplicacion"; // obtiene los nombres de las apps
                lbAppsDisponibles.ValueMember = "iidAplicacion"; // le asigna a cada app un id
                lbAppsDisponibles.DataSource = new N_Rol().AppDispo(); // tiene todos los registro del datatable
                lbAppsDisponibles.Refresh(); // refresca el listbox
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        //insercion de datos

        private int BuscarRegistro(string sApp)
        {
            // busca la app
            int app = new N_Permisos().getName_App(sApp); // instancia para la capa de negocios con el id de la app
            return app; // returna el id
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // obtiene el numero de apps que se seleccione
            for (int i = 0; i < lbAppsDisponibles.Items.Count; i++)
            {
                // si la seleccion tiene un numero
                if (lbAppsDisponibles.GetSelected(i))
                {
                    // seleciona los items de las apps seleccionadas
                    string selectedItem = lbAppsDisponibles.GetItemText(lbAppsDisponibles.Items[i]).ToString();
                    string sRol = lbPerfiles.GetItemText(lbPerfiles.SelectedValue); // obtiene el valor del rol que se selecciono

                    // busca las apps
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Permisos Nego = new N_Permisos(); // y las manda a la capa de negocios
                    string siApp = System.Convert.ToString(iiApp);
                    // manda cada rol y app y permisos para su insercion.
                    Nego.agregaAplicaciones(sRol,siApp, cbNuevo(),cbEdit(),cbElimina(),cbInser(),cbCancela(),cbUpdate(),cbImprimir(),
                        cbBusca(),cbPrimerReg(),cbAnterior(),cbSiguiente(),cbUltimoDato());
                    CargarAppAsignadas();
                   
                }
            }
            // deshabilita cada permiso
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

        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado

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

        // referencia para la inserion de permiso cuando es seleccionado
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


        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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


        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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

        // referencia para la inserion de permiso cuando es seleccionado
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
            // carga cada permiso de la applicacion
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
            lbPerfiles.SelectionMode = SelectionMode.One; // modo de seleccion del listbox
            lbAppsDisponibles.SelectionMode = SelectionMode.MultiExtended;// modo de seleccion del listbox
            lbPerfiles.Refresh(); // limpia el listbox
            lbAppsDisponibles.Refresh();
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string sIdRol = comboRoles.SelectedValue.ToString(); // seleccion del rol
            for (int i = 0; i < lbAppsAsignadas.Items.Count; i++) // obtiene un numero de los items que fueron selecionados
            {
                if (lbAppsAsignadas.GetSelected(i)) // si se obtiene un numero de apps
                {
                    // seleccion de los items de las apps
                    string selectedItem = lbAppsAsignadas.GetItemText(lbAppsAsignadas.Items[i]).ToString();
                    // busca los id de las apps
                    int iiApp = BuscarRegistro(selectedItem);
                    N_Permisos Nego = new N_Permisos(); // se crea un metodo para eliminar permisos
                    string siApp = System.Convert.ToString(iiApp);
                   
                    // se mandan como parametros el id del rol y el id de la app
                    Nego.quitaAplicaciones(sIdRol, siApp);

                }
            }
            //
            CargarAppAsignadas();// carga apps asignadas al usuario
            // deshabilita permisso
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
            // se obtiene el estado del permiso y los manda a cada checkbox
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
            // carga apps al darle doble click al listbox
            string idRol = comboRoles.SelectedValue.ToString(); // obtiene el id rol
            string idApp = lbAppsAsignadas.SelectedValue.ToString(); //obtiene el id app
            BuscarApp(idRol, idApp); // manda como parametros los 2 ids
             //habilita y deshabilita
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
           // deshabilita listbox
            lbPerfiles.SelectionMode = SelectionMode.None;
            lbAppsDisponibles.SelectionMode = SelectionMode.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // deshabilita y limpia objetos de listbox y checkbox
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
            //habilita objetos
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
            // edita permisos
            E_Permisos pRol = new E_Permisos();
            // se obtiene cada estado del los checkbox y id del rol y app
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

            new N_Permisos().Update_Permisos(pRol); // se manda cada valor a la capa de negocios
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

        private void btnsalir_Click(object sender, EventArgs e)
        {
            frmManejoRol rol = new frmManejoRol();
            rol.Show();
            this.Hide();
        }


    }
}
