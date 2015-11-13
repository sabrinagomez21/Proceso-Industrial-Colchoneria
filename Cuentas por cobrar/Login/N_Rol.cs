using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DllSeguridad;

namespace Login
{
    public class N_Rol:D_Rol
    {
        //funcion el cual obtiene los datos del usuario
        public E_Rol Get_User(string sUser)
        {
            E_Rol pCliente = new E_Rol();
            pCliente.Usuario = sUser;
            //devuelve la funcion Consultar en la capa de Datos
            return D_Rol.Consultar(pCliente); 
        }
        //funcion el cual el usuario envia los datos y verifica que el usuario exista en el sistema
        public int Login(string sUser, string sContra)
        {
            //declaramos la variable resultado de tipo entero
            int resultado = 0;
            if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cError Error = new cError();
                Error.iIdUsuario = 0;
                Error.iAplicacion = 1;
                Error.iTipo = 1;
                Error.sAccion = "Hay Uno o mas Campos Vacios";
                cErrorN negocio = new cErrorN();
                negocio.insert(Error);
            }
            else
            {

                resultado = D_Rol.LoginD(sUser, sContra);
                //si resulta es mayor a 0 
                if (resultado > 0)
                {
                    //entonces resultado se vuelve 1 y es que existe un dato
                    resultado = 1;
                    E_Rol res = new N_Rol().Get_User(sUser);
                    N_Bitacora bita = new N_Bitacora();
                    N_Bitacora negocio = new N_Bitacora();
                    bita.Id = res.Id;
                    bita.Aplicacion = 1;
                    bita.Accion = 1;
                    bita.detalle = "Ingreso al sistema";
                    //negocio.Insertar_Registro(bita);
                }
                else
                {
                    //muestra un mensaje de error si la contraseña es incorrecta
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    E_Rol res = new N_Rol().Get_User(sUser);
                    cError Error = new cError();
                    Error.iIdUsuario = res.Id;
                    Error.iAplicacion = 1;
                    Error.iTipo = 1;
                    Error.sAccion = "Usuario o Contraseña Incorrecta";
                    cErrorN negocio = new cErrorN();
                    negocio.insert(Error);
                }
            }
            //devuelve el resulta 
            return resultado;
        }
        //funcion el cual obtiene los nombre de los modulos
        public string NombreModulos(int idMod)
        {
            return D_Rol.NameModu(idMod);
        }
        //funcion el cual obtiene el nombre del formulario
        public string NombreFormulario( int idApp)
        {
            return D_Rol.NameFormulario( idApp);
        }
        //funcion el cual obtiene el nombre del rol
        public string NombreRol(int idUsu)
        {
            return D_Rol.NameRol(idUsu);
        }

        public string NumeroRol(int idUsu)
        {
            return D_Rol.idRol(idUsu);
        }

        public string NumeroUser(int idUsu)
        {
            return D_Rol.idUser(idUsu);
        }
        //funcion de tipo entero el cual obtiene cuantos modulos hay
        public int ContarModulos()
        {
            return D_Rol.ContModu();
        }
        //funcion el cual obtiene cuantas aplicaciones tiene el modulo
        public int ContarAplicaciones(int idModu)
        {
            return D_Rol.ContAplica(idModu);
        }
        //funcion el cual obtiene el id de la aplicacion
        public int IdAplica(string nameApp)
        {
            return D_Rol.IdAppli(nameApp);
        }
        //funcion el cual devuelve una lista del nombre de las aplicaciones
        public List<string> NombreAplica(int idApp)
        {
            return D_Rol.NameAppli(idApp);
        }
        //funcion el cual devuelve una lista con las aplicaciones asignadas al usuario
        public List<string> NombreAppUsuario(int idUsu)
        {
            return D_Rol.NameApUsu(idUsu);
        }
        //funcion el cual devuelve una lista con los roles de las aplicaciones
        public List<string> NombreRolUsuarioApp(int idUsu)
        {
            return D_Rol.NameRolUsuAp(idUsu);
        }
        //funcion el cual convierte en objeto el string enviado
        public object GetInstance(string strFullyQualifiedName)
        {

            Type t = Type.GetType(Application.ProductName + "." + strFullyQualifiedName);
            return Activator.CreateInstance(t);
        }
    }
}
