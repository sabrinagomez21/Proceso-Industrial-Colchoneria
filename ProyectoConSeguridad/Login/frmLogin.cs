using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }
        //Programador y Analista: Luis Fernando Linares Garzaro
        //Fecha de Asignación: 15/10/2015
        //Fecha de Entrega: 18/10/2015
        //Esta funcion se utiliza para entrar al sistema
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try//bloque try
            {
                //obtenemos las variables de usuario y contraseña
                string sUser = tbxUser.Text;
                string sContra = tbxContra.Text;

                //agregar try catch
                // contraseña encriptada
                //Funcion el cual envia los parametros para la consulta 
                int result = new N_Rol().Login(sUser, sContra);
                //variable el cual si devuelve un valor mayor a 0 entra al sistema, si no se queda en el login
                if (result > 0)
                {

                    E_Rol resultado = new N_Rol().Get_User(sUser);//Funcion el cual obtiene los datos el usuario ingresado
                    E_Rol.IdUser = resultado.Id;
                    E_Rol.UserName = resultado.Nombre;
                    E_Rol.UserApellido = resultado.Apellido;
                    E_Rol.UserEmail = resultado.Email;
                    //E_Rol.IdUser = Permisos.IdUser;
                    //Esconde este formulario y muestra el formulario de menu
                    this.Hide();
                    frmMenu Menu = new frmMenu();
                    Menu.Show();

                }
            }
            catch (Exception Ex)//Bloque Catch
            {
                MessageBox.Show(Ex.ToString());//Muestra el error
            }
        }

        

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {         
            e.Cancel = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
            
        }

       
    }
}
