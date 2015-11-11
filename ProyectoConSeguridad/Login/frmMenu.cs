using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DllSeguridad;
using System.Reflection;
using System.IO;

namespace Login
{
    public partial class frmMenu : Form
    {
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton dropDownButton1;
        private ToolStripMenuItem MenuItem;
        private static string btnimprimir;
        private static string btnnuevo;
        private static string btnirUltimo;
        private static string btnirPrimero;
        private static string btnanterior;
        private static string btnsiguiente;
        private static string btneditar;
        private static string btncancelar;
        private static string btnrefrescar;
        private static string btnbuscar;
        private static string btneliminar;
        private static string btnguardar;

        public frmMenu()
        {
            InitializeComponent();
            CargarInfo();

        }
        //Programador y Analista: Luis Fernando Linares Garzaro
        //Fecha de Asignación: 10/10/2015
        //Fecha de Entrega: 13/10/2015
        //Esta funcion Carga la informacion conforme las aplicaciones y/o rol que el usuario tenga asignados
        public void CargarInfo()
        {
            //funcion para contar los modulos del sistema
            int TotModul = new N_Rol().ContarModulos();
            //instancia un nuevo objeto que es ToolStrip
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            // hace un for para recorrer los modulos
            for (int i = 1; i <= TotModul; i++)
            {
                //Esta funcion devuelve los nombres de los modulos
                string nameddB = new N_Rol().NombreModulos(i);
                //instancia un nuevo objet que es ToolStripDropDownButton
                dropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
                //al objeto ToolStripDropDownButton le asignamos el nombre del modulo y el tag
                dropDownButton1.Text = nameddB;
                dropDownButton1.Tag = i;
                //Cuenta las aplicaciones de los modulos 
                int TotAppli = new N_Rol().ContarAplicaciones(i);

                

                //devuelve una lista de aplicaciones segun el rol del usuario
                List<string> NameRolUsu = new N_Rol().NombreRolUsuarioApp(E_Rol.IdUser);
                // devuelve una lista de los nombres de las aplicaciones que tiene el modulo
                List<string> NomAppli = new N_Rol().NombreAplica(i);
                //devuelve una lista de las aplicaciones que tiene el usuario
                List<string> NameAppUsu = new N_Rol().NombreAppUsuario(E_Rol.IdUser);
               
                //agregamos la variable j y m para un contador         
                int j = 0;
                int m = 0;
                //Recorre la lista de las aplicaciones que hay en el modulo  
                foreach (string nA in NomAppli)
                {
                    string idRoll = new N_Rol().NumeroRol(E_Rol.IdUser); //ID DEL USUARIO
                    string idUserr = new N_Rol().NumeroUser(E_Rol.IdUser);
                    //instancia y agrega con un ToolStripMenuItem las aplicaciones totales y las marca como false
                    MenuItem = new System.Windows.Forms.ToolStripMenuItem();
                    //le agregamos al menuitem el texto de las aplicaciones existentes
                    MenuItem.Text = nA;
                    //deshabilitamos todos los menuitems
                    MenuItem.Enabled = false;
                    int noAplicacion = new N_Rol().IdAplica(nA); // numero de aplicacion ..
                    string NombreForm = new N_Rol().NombreFormulario(noAplicacion);
                   
                    //evento al presionar el menu item abre el formulario asignado
                    MenuItem.Click += delegate(object sender, EventArgs e) {
                        //object form = new N_Rol().GetInstance(NombreForm);
                        //(form as Form).ShowDialog();
                        AbrirFormulario(sender, e, NombreForm, idRoll, idUserr); 
                    };
                    //obtiene el nombre del rol asignado al usuario
                    string NombreRol = new N_Rol().NombreRol(E_Rol.IdUser);
                  
                    //si el rol asignado es de super usuario habilita todos los botones
                    if (NombreRol == "Superusuario")
                    {
                        //habilita el menu item si es superusuario
                        MenuItem.Enabled = true;
                        //agrega el menuitem al dropdownboton
                        dropDownButton1.DropDownItems.Add(MenuItem);
                    }
                    foreach (string NRU in NameRolUsu)
                    {
                        //si el nombre de la aplicacion es igual a las asignadas al usuario
                        if (NRU == nA)
                        {
                            // si la aplicacion del rol esta asignada habilita el boton
                            MenuItem.Enabled = true;
                        }
                        //Recorre la lista de las aplicaciones que tiene asignado el usuario
                        foreach (string NAU in NameAppUsu)
                        {
                            //si el usuario y el nombre de aplicacion son iguales habilita el permiso
                            if (NAU == nA)
                            {
                                MenuItem.Enabled = true;
                            }
                            //agrega el MenuItem al ToolStripDropDownButton
                            dropDownButton1.DropDownItems.Add(MenuItem);
                        }
                        j++;
                    }
                    //Entra si el usuario no tiene ningun Rol asignado,es solo para las aplicaciones que tiene el usuario
                    if (j == 0)
                    {
                        //Recorre la lista de las aplicaciones que tiene asignado el usuario
                        foreach (string NAU in NameAppUsu)
                        {
                            //si el usuario y el nombre de aplicacion son iguales habilita el permiso
                            if (NAU == nA)
                            {
                                MenuItem.Enabled = true;
                            }
                            //agrega el MenuItem al ToolStripDropDownButton
                            dropDownButton1.DropDownItems.Add(MenuItem);
                        }
                    }
                }
                //agrega el ToolStripDropDownButton al toolStrip1 que esta en formulario
                toolStrip1.Items.Add(dropDownButton1);
                // agrega el toolStrip1 al formulario
                Controls.Add(toolStrip1);
            }
        }
        //Funcion el cual abrira el formulario el cual recibe el nombre del formulario
        public void AbrirFormulario(object sender, EventArgs e, string FormName, string idRol,string idUser)
        {


            if (FormName == "frmAsignacionAplicacion" || FormName == "frmBuscarApli" || FormName == "frmBuscarUser" || FormName == "frmBuscarUsuari" || FormName == "frmConsulta" || FormName == "frmConsultaRol" || FormName == "frmConsultaUsuarioAsignacion" || FormName == "frmEditar" || FormName == "frmEditarAplicacion" || FormName == "frmEditUser" || FormName == "frmErrores" || FormName == "frmFecha" || FormName == "frmFechas" || FormName == "frmIngresoRol" || FormName == "frmManejoRol" || FormName == "frmPermisosRol" || FormName == "frmRegistro" || FormName == "frmRegistroAplicacion" || FormName == "Presentacion" || FormName == "frmRegistroModulo" || FormName == "frmEditModulo" || FormName == "frmBuscaModulo")
            {
                Assembly assembly = Assembly.LoadFile(Path.GetFullPath("DllSeguridad.dll"));
                Type type1 = assembly.GetType("DllSeguridad." + FormName);
                Activator.CreateInstance(type1);
                object obj = Activator.CreateInstance(type1);
                (obj as Form).MdiParent = this;
                (obj as Form).Show();
            }
            else if(FormName == "Salir"){
                this.Hide();
                frmLogin Login = new frmLogin();
                Login.Show();
                
            }
            else 
            {
                //Obtiene el nombre del formulario para cambiarlo de tipo objeto
                Type type = Type.GetType(Application.ProductName + "." + FormName);
                object obj = Activator.CreateInstance(type);
                // abre el formulario de tipo de objeto
                //los cargan los permisos en un data table 
                // new N_Aplicacion().Permisos(FormName);



                 foreach (DataRow row in new N_Aplicacion().Permisos(FormName,idRol,idUser).Rows)
                 {

                     btnimprimir = row["btnimprimir"].ToString();
                     Permisos.btnimprimir = Convert.ToInt16( btnimprimir);

                     btnnuevo = row["btnnuevo"].ToString();
                     Permisos.btnnuevo = Convert.ToInt16(btnnuevo);

                     btnirUltimo = row["btnirUltimo"].ToString();
                     Permisos.btnirUltimo = Convert.ToInt16(btnirUltimo);

                     btnirPrimero = row["btnirPrimero"].ToString();
                     Permisos.btnirPrimiero = Convert.ToInt16(btnirPrimero);

                     btnanterior = row["btnanterior"].ToString();
                     Permisos.btnanterior = Convert.ToInt16(btnanterior);

                     btnsiguiente = row["btnsiguiente"].ToString();
                     Permisos.btnsiguiente = Convert.ToInt16(btnsiguiente);

                     btneditar = row["btneditar"].ToString();
                     Permisos.btneditar = Convert.ToInt16(btneditar);

                     btncancelar = row["btncancelar"].ToString();
                     Permisos.btncancelar = Convert.ToInt16(btncancelar);

                     btnrefrescar = row["btnrefrescar"].ToString();
                     Permisos.btnrefrescar = Convert.ToInt16(btnrefrescar);

                     btnbuscar = row["btnbuscar"].ToString();
                     Permisos.btnbuscar = Convert.ToInt16(btnbuscar);

                     btneliminar = row["btneliminar"].ToString();
                     Permisos.btneliminar = Convert.ToInt16(btneliminar);

                     btnguardar = row["btnguardar"].ToString();
                     Permisos.btnguardar = Convert.ToInt16(btnguardar);
                     
                     
                     

                    
                 }


              //  MessageBox.Show();
                 (obj as Form).MdiParent = this;
                (obj as Form).Show();
            }
           


            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
