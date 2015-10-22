//La función del siguiente formulario es la de gestionar los detalles acerca de los registros de los usuarios en el sistema
//incluyendo la siguiente información: nombre del equipo, usuario, IP del equipo, hora, fecha, aplicacion, accion y detalle

//Programador y Analista: José Wilfredo Chacón Cartagena
//Fecha de Asignación: 08/10/2015
//Fecha de Entrega: 21/10/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class Presentacion : Form
    {
        private Presentacion instace;
        
         public Presentacion()
        {
            InitializeComponent();
            instace = this;
        }

        //Esta funcion me permite obtener la lista de usuarios para mostrarlos en el datagrid
        public void Usuario(int id){
            dGVBitacora.DataSource = new N_Bitacora().SUSER(id, Convert.ToInt32(cmbAplicacion.SelectedValue), E_Usuario.date1, E_Usuario.date2);
            dGVBitacora.Refresh();
        }

        //Funcion que permite obtener la fecha seleccionada
        public void Fecha(string fech1)
        {
            dGVBitacora.DataSource = new N_Bitacora().Horarios(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue), fech1, E_Usuario.date2);
            dGVBitacora.Refresh();
        }

        //Funcion que permite obtener las fechas seleccionadas
        public void Fechas(string fech1,string fech2)
        {
            dGVBitacora.DataSource = new N_Bitacora().Horarios(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue), fech1, fech2);
            dGVBitacora.Refresh();
        }

        //Se utiliza para poder actualizar el datagrid al iniciar el formulario
         private void Presentacion_Load(object sender, EventArgs e)
         {  
             cagabox();
             ActualizarForm();
         }

        //La función de ActualizarForm sirve para poder obtener los registros del datatable situado en la clase N_Bitacora para poder
        //mostrarlos en el datagrid
         private void ActualizarForm()
         {
             try
             {
                 dGVBitacora.DataSource = new N_Bitacora().GetAll();
                 dGVBitacora.Refresh();
             }
             catch (Exception Ex)
             {
                 
             }
         }
        
        //Su función es buscar un registro. Abre el form de consulta y se puede buscar ya sea por nombre o apellido utilizando los
        //parametros de la clase E_usuario
         private void btnsearch_Click(object sender, EventArgs e)
         {
             frmConsulta consulta = new frmConsulta(this);
             E_Usuario.id = 0;
             consulta.Show();
         }

        //Su funcion es la de cargar las aplicaciones disponibles en un combobox para poder ser seleccionadas al momento de una busqueda
         private void cagabox() 
         {
             cmbAplicacion.DataSource = new N_Bitacora().aplicacion();
             cmbAplicacion.DisplayMember = "vnombreAplicacion";
             cmbAplicacion.ValueMember = "iidAplicacion";
             cmbAplicacion.Refresh();
             cmbAplicacion.SelectedValue = 0;
         }

        //Su funcion es de la refrescar los datos del formulario principal
         private void btnRefrescar_Click(object sender, EventArgs e)
         {
             ActualizarForm();
             E_Usuario.id = 0;
         }

         private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                 dGVBitacora.DataSource = new N_Bitacora().Horarios(E_Usuario.id, Convert.ToInt32(cmbAplicacion.SelectedValue), E_Usuario.date1, E_Usuario.date2);
                 dGVBitacora.Refresh();
             }
             catch { }
         }

        //Abre un nuevo formulario con la opcion de seleccionar 1 o 2 fechas para realizar la busqueda
         private void btnFecha_Click(object sender, EventArgs e)
         {
             frmFechas consulta = new frmFechas(this);
             consulta.Show();
         }

    }
}
