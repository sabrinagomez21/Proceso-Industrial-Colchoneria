using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;
using ConexionODBC;
using System.Data.Odbc;
using prueba1;

/*
 *Formulario Mantenimiento Proveedor
 *Autor: José Arredondo
 */

namespace CuentasPorCobrar
{
    public partial class frmmantenimientoProveedores : Form
    {
        int idusuario;
        string nomformulario;
        string privilegio;
        int idaplicacion; //id que se le asigno al formulario 
        int idmodulo;
        public frmmantenimientoProveedores(int id, string priv)
        {
            idusuario = id;
            privilegio = priv;
            InitializeComponent();

            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
           // cnegocio.funactivarDesactivarTextbox(txtcod, true);
            cnegocio.funactivarDesactivarTextbox(txtnombre, true);
            cnegocio.funactivarDesactivarTextbox(txtdescripcion,true);
            cnegocio.funactivarDesactivarTextbox(txtdireccion,true);
            cnegocio.funactivarDesactivarTextbox(txttelefono,true);
            cnegocio.funactivarDesactivarTextbox(txtciudad,true);
            cnegocio.funactivarDesactivarCombobox(cmbpais, true);
            cnegocio.funactivarDesactivarCombobox(cmbestado, true);
        }

        private void dgvproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ncodproveedor, vnombre, vdescripcion, vpais, vciudad, vdireccion, vtelefono
            //    0              1         2           3       4        5          6 
            txtcod.Text = dgvproveedores[0, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            txtdescripcion.Text = dgvproveedores[2, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            cmbpais.Text = dgvproveedores[3, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            txttelefono.Text = dgvproveedores[6, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            txtciudad.Text = dgvproveedores[4, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            txtnombre.Text = dgvproveedores[1, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            txtdireccion.Text = dgvproveedores[5, dgvproveedores.CurrentCell.RowIndex].Value.ToString();
            //cmbestado.Text = dgvproveedores[7, dgvproveedores.CurrentCell.RowIndex].Value.ToString();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maproveedor", "select ncodproveedor, vnombre, vdescripcion, vpais, vciudad, vdireccion, vtelefono from maproveedor where vestado = 'ACTIVO';", "consulta", dgvproveedores);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            textBox1.Text = cmbpais.SelectedItem.ToString();
            textBox2.Text = cmbestado.SelectedItem.ToString();
            TextBox[] aDatos = { txtcod, txtdescripcion, textBox1, txttelefono, txtciudad, txtnombre, txtdireccion, textBox2 };
            string sTabla = "maproveedor";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            txtcod.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtciudad.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
        }

        private static OdbcCommand odbcComando;
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "maproveedor";
            codEliminar = txtcod.Text;
            campoLlavePrimaria = "ncodproveedor";
            campoEstado = "vestado";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            

            /*
             * codigo eliminar con conexion obdc
             * 
            int ivalorRetorno = 0;
            odbcComando = new OdbcCommand(string.Format("delete from maproveedor where ncodproveedor ='" + txtcod.Text + "' "), CAD.obtenerConexion());
            ivalorRetorno = odbcComando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            txtcod.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtciudad.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";*/


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            textBox1.Text = cmbpais.SelectedItem.ToString();
            textBox2.Text = cmbestado.SelectedItem.ToString();
            TextBox[] aDatos = { txtcod, txtdescripcion, textBox1, txttelefono, txtciudad, txtnombre, txtdireccion, textBox2 };
            clasnegocio cn = new clasnegocio();
            string sTabla = "maproveedor";
            Boolean bPermiso = true;
            string codigo = txtcod.Text.Trim();
            cn.EditarObjetos("maproveedor", bPermiso, aDatos, codigo, "ncodproveedor");
            txtcod.Text = "";
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtciudad.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = ""; 
            MessageBox.Show("registro Editado");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funactivarDesactivarTextbox(txtcod, false); 
            cnegocio.funactivarDesactivarTextbox(txtnombre, false);
            cnegocio.funactivarDesactivarTextbox(txttelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtdescripcion,false);
            cnegocio.funactivarDesactivarTextbox(txtciudad, false);
            cnegocio.funactivarDesactivarTextbox(txtdireccion, false);
            cnegocio.funactivarDesactivarCombobox(cmbpais,false);
            cnegocio.funactivarDesactivarCombobox(cmbestado, false);

        }
   

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            nomformulario = "nombre de su formulario";
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario, idaplicacion, idmodulo, idusuario, privilegio);
            FormCarga.Show();
        }

        private void btnIrPrimero_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvproveedores);
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvproveedores);
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvproveedores);
        }

        private void btnIrUltimo_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvproveedores);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar busc = new buscar();
            busc.Show(); 
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890, " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890,- " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890-, " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void frmmantenimientoProveedores_Load(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
