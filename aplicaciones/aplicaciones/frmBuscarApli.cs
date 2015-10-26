//Modulo de Busqueda de una aplicacion.
// Programador: Melvin Alejandro Batz Farfan
// carné: 0901-12-1049
// Diseño por: Melvin Batz

//LLmada a las librerias a utilizarse en nuestro modulo
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicaciones
{
    public partial class frmBuscarApli : Form
    {
        public frmBuscarApli()
        {
            InitializeComponent();
        }

        private void frmBuscarApli_Load(object sender, EventArgs e)
        {

        }

        private void gbUsuarioSeleccionado_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //En este metodo validaremos y obtendremos el valor que se desea buscar.
            if (string.IsNullOrWhiteSpace(txtNombreAplicacion.Text))
            {
                MessageBox.Show("Ingrese un valor");
            }
            else { 
                dgvBusquedaAplicacion.DataSource = D_BusquedaApli.Buscar(txtNombreAplicacion.Text);
            
                if (dgvBusquedaAplicacion.Rows.Count > 0)//si la busqueda nos da un resultado sera cargado al data grid y obtedremos un mensaje de que la busqueda se realizo con exito.
                {

                    MessageBox.Show("Registro Encontrado");
                    btnAceptar.Enabled = true;
                    btncancelar.Enabled = true;
                }
                
        else
                {
                    MessageBox.Show("ususario no encontrado");
                    txtNombreAplicacion.ResetText();
                    btnAceptar.Enabled = false;
                    btncancelar.Enabled = false;
                    dgvBusquedaAplicacion.DataSource = null;
                    dgvBusquedaAplicacion.Refresh();
                }
                }
            }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Luego de realizar la busqueda, tendremos la opcion de realizar una edicion o eliminacion de los valores buscados.
            frmEditarAplicacion usuario = new frmEditarAplicacion();
            //cargaremos los datos que tengamos en las cajas de texto al data grid que tendremos en el formulario frmEditarApliacion
            usuario.txtIdAplicacion.Text = this.dgvBusquedaAplicacion.CurrentRow.Cells[0].Value.ToString();
            usuario.txtNombreAplicacion.Text = this.dgvBusquedaAplicacion.CurrentRow.Cells[1].Value.ToString();
            usuario.txtNombreFormulario.Text = this.dgvBusquedaAplicacion.CurrentRow.Cells[2].Value.ToString();
            
            usuario.btnCancelar.Enabled = true;
            usuario.btnEditar.Enabled = true;
            usuario.btnEliminar.Enabled = true;
            usuario.Show();
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // en caso de no querer realizar otra accion este metodo limpiara el valor de la caja de texto.
            btnAceptar.Enabled = false;
            btncancelar.Enabled = false;

            txtNombreAplicacion.ResetText();
            dgvBusquedaAplicacion.DataSource = null;
            dgvBusquedaAplicacion.Refresh();
        }
        }


    }
