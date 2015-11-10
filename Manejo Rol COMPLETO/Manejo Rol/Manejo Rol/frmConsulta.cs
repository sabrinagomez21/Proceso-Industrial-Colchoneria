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

namespace Manejo_Rol
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }
        // variable capa entidad para la seleccion del cliente seleccionado
        public E_Rol EmpleadoSeleccionado { get; set; }

        //evento click para la busqueda 
        private void btnsearch_Click(object sender, EventArgs e)
        {
            // se instancia el datagrid hacia la capa de datos con parametros de nombre y apellido
            dvgbuscar.DataSource = D_Rol.Buscar(txtname.Text, txtlastname.Text);

            // si en tal caso el datagrid recive un dato, muestra un mensaje de registro encontrado
            if (dvgbuscar.Rows.Count > 0)
            {
                // mensaje y habilita los botones de aceptar y cancelar
                MessageBox.Show("Registro Encontrado");
                btnaccept.Enabled = true;
                btncancel.Enabled = true;
            }
            else
            {
                // registro no encontrado y deshabilita los botones y limpia grid y textbox
                MessageBox.Show("Registro No Encontrado !");
                txtname.ResetText();
                txtlastname.ResetText();
                btnaccept.Enabled = false;
                btncancel.Enabled = false;
                dvgbuscar.DataSource = null;
                dvgbuscar.Refresh();
            }
        }

        //boton aceptar registro al momento de haber encontrado el dato.
        private void btnaccept_Click(object sender, EventArgs e)
        {

            frmManejoRol Empleado = new frmManejoRol(); // se instancia el formulario manejo rol el cual recibira el dato.
            // se selecciona las celdas 0 y 1 del grid los cuales son los datos seleccionados y los direcciona a los textbox del formulario manejo rol
            Empleado.txtUsuario.Text = this.dvgbuscar.CurrentRow.Cells[0].Value.ToString();
            Empleado.txtNombreUsuario.Text = this.dvgbuscar.CurrentRow.Cells[1].Value.ToString();
            this.Close(); // cierra formulario
            Empleado.Show(); // muestra formulario manejo rol
            Empleado.CargarRolAsig(); // carga roles asignados para esa persona
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // limpia el grid y textbox del formulario
            txtname.ResetText();
            txtlastname.ResetText();
            btnaccept.Enabled = false;
            dvgbuscar.DataSource = null;
            dvgbuscar.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();// cierra formulario
            frmManejoRol rol = new frmManejoRol(); //instancia del form manejo rol
            rol.Show(); //muestra formulario
        }
    }
}
