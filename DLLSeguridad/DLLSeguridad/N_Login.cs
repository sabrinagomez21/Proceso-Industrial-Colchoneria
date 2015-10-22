using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLSeguridad
{
    public class N_Login:D_Login
    {

        //public void Insert_Rol(E_Rol pNameRol)
        //{
        //    if (string.IsNullOrWhiteSpace(pNameRol.NombreRol))
        //    {
        //        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    else
        //    {

        //        int resultado = D_Rol.AgregarRol(pNameRol);

        //        if (resultado > 0)
        //        {
        //            MessageBox.Show("Rol Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se pudo guardar el Rol", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //}

        public E_Login Get_User(string sUser)
        {


            E_Login pCliente = new E_Login();
            pCliente.Usuario = sUser;
            return D_Login.Consultar(pCliente); 
        }
        public int Login(string sUser, string sContra)
        {
            int resultado = 0;
            if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                resultado = D_Login.LoginD(sUser, sContra);
                if (resultado > 0)
                {
                    resultado = 1;
                }
                else
                {
                    //frmLogin Log = new frmLogin();
                    //Log.ShowDialog();
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            return resultado;
        }

        public string NombreModulos(int idMod)
        {
            return D_Login.NameModu(idMod);
        }
        public int ContarModulos()
        {
            return D_Login.ContModu();
        }
        public int ContarAplicaciones(int idModu)
        {
            return D_Login.ContAplica(idModu);
        }
        public List<string> NombreAplica(int idApp)
        {
            return D_Login.NameAppli(idApp);
        }
        public List<string> NombreAppUsuario(int idUsu)
        {
            return D_Login.NameApUsu(idUsu);
        }
    }
}
