/* Proyecto Desarrollado y Elaborado Por: Hector Joannes Gil Cardona
 * Fecha de Asignacion: 23 de Septiembre
 * Fecha de Entrega: 10 de Octubre
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
using System.Data.Odbc;

namespace Manejo_Rol
{
    public partial class frmManejoRol : Form
    {
        public frmManejoRol()
        {
            InitializeComponent();
        }

        // guarda el rol actual
        public E_Rol EmpleadoActual { get; set; }
        // evento buscar
        private void btnbuscar_Click(object sender, EventArgs e)

        {
            // instancia del formulario Consulta
            frmConsulta buscar = new frmConsulta();
            
            buscar.Show(); // muestra el formulario Consulta Rol
            // si el rol seleccionado es diferente de null 
            if (buscar.EmpleadoSeleccionado != null)
            {
                // selecciona el rol actual y los añade los textbox correspondientes
                EmpleadoActual = buscar.EmpleadoSeleccionado;
                // asignacion de valores de usuario y nombre en los textbox 
                txtUsuario.Text = Convert.ToString( buscar.EmpleadoSeleccionado.Id);
                txtNombreUsuario.Text = buscar.EmpleadoSeleccionado.Nombre;
              

            }
            this.Hide(); // esconde el formulario
        }

        private void frmManejoRol_Load(object sender, EventArgs e)
        {
//            frmManejoRol.ActiveForm.Refresh();
            mostrarPerfil(); // void que muestra todos los roles para el usuario
            PresionarBotones(); // habilita y deshabilita botones
        }

        private void PresionarBotones()
        {
             // si el textbox es igual a null
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                // deshabilita los botones de asignacion de rol
                btnAsignarSimple.Enabled = false;
                btnAsignarMuchos.Enabled = false;
                btnQuitarSimple.Enabled = false;
                lblQuitarMuchos.Enabled = false;
            }
        }
        public void CargarRolAsig() // carga los roles que tiene el usuario
        {
            try
            { 
                // si tiene roles los carga
                lbRolAsignado.DisplayMember = "vnombreRole"; // llama al campo vnombre de la tabla roles
                lbRolAsignado.ValueMember = "iidRole"; // toma el valor del id del rol
                lbRolAsignado.DataSource = new N_Rol().RolAsig(txtUsuario.Text); // tiene todos los registro del datatable
                lbRolAsignado.Refresh(); // refresca el listbox
            }
            catch (Exception Ex)
            {
                // no  puede leer roles del usuario
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

        
        
        // asignacion de un solo rol
        private void btnAsignarSimple_Click(object sender, EventArgs e)
        {
            // variable string Rol el cual obtiene los items del perfil seleccionado
            string sRol = lbPerfiles.GetItemText(lbPerfiles.SelectedValue);
            // instancia de la capa de Negocio Rol
            N_Rol Nego = new N_Rol();
            // se crea un nuevo metodo para la insercion del rol al usuario
          
            Nego.agregarRol(sRol, txtUsuario.Text);
            // se selecciona el id del usuario para mostrar los roles que tiene asignado
            string sIdUser = txtUsuario.Text;
            lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser); // carga roles asignados 
            
        }

        private int BuscarRegistro(string sRol)
        {
            //  busca todos los roles
            int app = new N_Rol().getName_Rol(sRol);
            return app; // retorna el rol
        }

        private void btnAsignarMuchos_Click(object sender, EventArgs e)
        {
            string sIdUser = txtUsuario.Text;
            // para la asignacion de muchos roles
                for (int i = 0; i < lbPerfiles.Items.Count; i++) // obtiene los roles seleccionados
                {
                    if (lbPerfiles.GetSelected(i)) // si se selecciono mas de alguno
                    {
                        // obtiene el item o los items
                        string selectedItem = lbPerfiles.GetItemText(lbPerfiles.Items[i]).ToString();
                        // obtiene el id del rol seleccionado
                        int iiRol = BuscarRegistro(selectedItem);
                        // manda el item seleccionado al la capa de negocio Rol
                        N_Rol Nego = new N_Rol();
                        //  convierte el id en string
                        string siRol = System.Convert.ToString(iiRol);
                        string sID = txtUsuario.Text;
                        //manda parametros del rol y el id del rol
                        Nego.agregarRol(siRol, sID);
                        // obtienen el id del usuario
                       
                       
                    } 
                }
                lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser); // carga roles asignados 
        }

        private void lblQuitarMuchos_Click(object sender, EventArgs e)
        {
            string sIdUser = txtUsuario.Text; // obtiene el id del usuario
            for (int i = 0; i < lbRolAsignado.Items.Count; i++) // seleccion de varios roles que el usuario ya tiene
            {
                // si el id del rol es obtenido.
                if (lbRolAsignado.GetSelected(i))
                {
                    // obtiene los items de los roles asignados del usuario
                    string selectedItem = lbRolAsignado.GetItemText(lbRolAsignado.Items[i]).ToString();
                   // obtiene los id's de los roles
                    int iiRol = BuscarRegistro(selectedItem);
                    // creacion del metodo para la busqueda del rol
                    N_Rol Nego = new N_Rol();
                    string siApp = System.Convert.ToString(iiRol); // obtiene los ids's de los roles
                    // metodo para eliminar los roles
                    Nego.quitaAplicaciones(siApp, sIdUser);

                }

            }
            // muestra los roles actuales del usaurio
            lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser);
        }

        private void btnQuitarSimple_Click(object sender, EventArgs e)
        {
            // obtiene el id del rol ya asignado del usuario
            string sRol = lbRolAsignado.GetItemText(lbRolAsignado.SelectedValue);
            // se crea un metodo para la eliminacion
            N_Rol Nego = new N_Rol();
            // obtiene el id del rol
            string sIdUser = txtUsuario.Text;
            // metodo para elminar rol por medio del id del usuario
            Nego.quitaAplicaciones(sRol, sIdUser);
            lbRolAsignado.DataSource = new N_Rol().RolAsig(sIdUser); // muestra los roles que le quedan.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmPermisosRol permisos = new frmPermisosRol();
            permisos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIngresoRol rol = new frmIngresoRol();
            rol.Show();
            
        }

    }
}
