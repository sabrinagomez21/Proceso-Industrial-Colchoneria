//La función del siguiente formulario es la de gestionar las consultas acerca de los usuarios ya sea por nombre o por apellido
//mostrando los detalles en un datagrid y pudiendo seleccionar el registro para cargarlo en el datagrid principal de la bitacora

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
    public partial class frmConsulta : Form
    {
        private Presentacion presentacionHandler;
        public frmConsulta()
        {
            InitializeComponent();
        }
        
        public frmConsulta(Presentacion Form)
        {
            InitializeComponent();
            presentacionHandler = Form;
        }

        //Su funcion es la de buscar el registro ya sea por medio del nombre o por medio del apellido, luego muestra los resultados
        //de la busqueda en un datagrid
        private void btnsearch_Click(object sender, EventArgs e)
        {
            dvgbuscar.DataSource = D_Bitacora.Buscar(txtname.Text, txtlastname.Text);

            if (dvgbuscar.Rows.Count > 0)
            {
                MessageBox.Show("Registro Encontrado");
                btnaccept.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro No Encontrado !");
                btnaccept.Enabled = false;
                dvgbuscar.DataSource = null;
                dvgbuscar.Refresh();
            }
        }

        //Su funcion es trasladar los resultados de la busqueda al datagrid principal, en caso de no seleccionar algun registro
        //muestra un mensaje
        private void btnaccept_Click(object sender, EventArgs e)
        {
            if(E_Usuario.id>0){
                presentacionHandler.Usuario(E_Usuario.id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
                        
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            
        }

        //Funcion que permite deshacer los cambios realizados en la busqueda. Refrescar el formulario
        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.ResetText();
            txtlastname.ResetText();
            btnaccept.Enabled = false;
            dvgbuscar.DataSource = null;
            dvgbuscar.Refresh();
        }

        //Funcion que permite poder seleccionar un usuario previamente buscado para que al seleccionarlo se pueda cargar en el datagrid
        //principal
        private void dvgbuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            DataGridViewRow row = dvgbuscar.Rows[e.RowIndex];
            int valor = (int)row.Cells[0].Value;
            E_Usuario.id=valor;
            MessageBox.Show("Usuario Seleccionado");        
        }

        //Cierra el formulario
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
