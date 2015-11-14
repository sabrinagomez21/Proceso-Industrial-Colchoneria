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
 *Formulario Mantenimiento Transacciones
 *Autor: José Arredondo
 */

namespace CuentasPorCobrar
{
    public partial class MantenimientoTransaccion : Form
    {

        int idusuario;
        string nomformulario;
        string privilegio;
        int idaplicacion; //id que se le asigno al formulario 
        int idmodulo;
        public MantenimientoTransaccion(int id, string priv)
        {
            idusuario = id;
            privilegio = priv;
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombreTr, true);
            cnegocio.funactivarDesactivarCombobox(cmbOperacionTr, true);
            cnegocio.funactivarDesactivarCombobox(cmbestado, true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            textBox2.Text = cmbestado.SelectedItem.ToString();
            textBox1.Text = cmbOperacionTr.SelectedItem.ToString();
            TextBox[] aDatos = { txtNombreTr, textBox1 , textBox2};
            clasnegocio cn = new clasnegocio();
            string sTabla = "matipotransaccion";
            Boolean bPermiso = true; 
            string codigo = txtOperacionTr.Text.Trim();
            cn.EditarObjetos("matipotransaccion", bPermiso, aDatos, codigo, "ncodtipotransaccion");
            txtNombreTr.Text = "";
            MessageBox.Show("registro Editado");
        }

        private static OdbcCommand odbcComando;
       // private static OdbcDataAdapter odbcAdaptador;
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clasnegocio cnegocio = new clasnegocio();
            string tabla, codEliminar, campoLlavePrimaria, campoEstado;
            tabla = "matipotransaccion";
            codEliminar = txtOperacionTr.Text;
            campoLlavePrimaria = "ncodtipotransaccion";
            campoEstado = "vestado";
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            textBox1.Text = cmbOperacionTr.SelectedItem.ToString();
            textBox2.Text = cmbestado.SelectedItem.ToString();
            TextBox[] aDatos = { txtNombreTr, textBox1 , textBox2};
            string sTabla = "matipotransaccion";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("matipotransaccion", "SELECT *from matipotransaccion where vestado = 'ACTIVO'", "consulta", dataGridView1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOperacionTr.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            cmbOperacionTr.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            txtNombreTr.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            cmbestado.Text = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombreTr, false);
            cnegocio.funactivarDesactivarCombobox(cmbOperacionTr, false);
            cnegocio.funactivarDesactivarCombobox(cmbestado, false);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            nomformulario = "nombre de su formulario";
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario, idaplicacion, idmodulo, idusuario, privilegio);         FormCarga.Show();

        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dataGridView1); 


        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dataGridView1);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dataGridView1); 
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dataGridView1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscartransaccion busc = new buscartransaccion();
            busc.Show(); 
        }

        private void txtNombreTr_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void MantenimientoTransaccion_Load(object sender, EventArgs e)
        {

        }
    }
}
