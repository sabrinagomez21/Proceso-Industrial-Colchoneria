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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        public E_Login UsuarioActual { get; set; }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string sUser = tbxUser.Text;
            string sContra = tbxContra.Text;
           

            
            int result = new N_Login().Login(sUser, sContra);
            if (result > 0)
            {
                E_Login resultado = new N_Login().Get_User(sUser); 
                    E_Login.IdUser = resultado.Id;
                    E_Login.UserName = resultado.Nombre;
                    E_Login.UserApellido = resultado.Apellido;
                    E_Login.UserEmail = resultado.Email;
                    //MessageBox.Show(E_Rol.UserName);
                    this.Hide();
                    frmMenu Menu = new frmMenu();
                    Menu.Show();
                    
            }
                
                
            
            
        }
        
       

    }   
}
