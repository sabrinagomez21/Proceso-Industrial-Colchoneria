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
using ConexionODBC;

namespace Inventario
{
    public partial class Frm_Logueo : Form
    {
        public Frm_Logueo()
        {
            InitializeComponent();
        }

        private void Frm_Logueo_Load(object sender, EventArgs e)
        {

        }
        private static OdbcCommand mySqlComando;

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
                    //Esconde este formulario y muestra el formulario de menu
                    this.Hide();
                    Mdi_Form Menu = new Mdi_Form(resultado.Id);
                    Menu.Show();

                }
            }
            catch (Exception Ex)//Bloque Catch
            {
                MessageBox.Show(Ex.ToString());//Muestra el error
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
