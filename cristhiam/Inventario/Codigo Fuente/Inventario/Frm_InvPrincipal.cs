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
using Navegador;
using prueba1;

namespace Inventario
{

    //Programador y Analista: Jose David Yool Barrios
    //Fecha de Asignación: 06/11/2015
    //Fecha de Entrega: 11/11/2015
    //Realiza Mantenimiento a la tabla MaMaterial
    public partial class Frm_InvPrincipal : Form
    {
        #region Variables
        string tablaviene;
        string datos;
        int idusuario; 
        string nomformulario; 
        int idaplicacion; //id que se le asigno al formulario 
        int idmodulo;
        string privilegio;
        decimal total;
        decimal precio;
        int cantidad;
        #endregion

        #region Inicio y toma de variables
        public Frm_InvPrincipal(int idtoma, string priv)
        {
            idusuario = idtoma;
            privilegio = priv;
            InitializeComponent();
        }
        #endregion

        #region Cellcontent
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Id.Text = DGV_Inventario[0, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            Txt_Nombre.Text = DGV_Inventario[1, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            Txt_Cantidad.Text = DGV_Inventario[2, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            txt_precio.Text = DGV_Inventario[3, DGV_Inventario.CurrentCell.RowIndex].Value.ToString();
            total = Convert.ToDecimal(Txt_Cantidad.Text) * Convert.ToDecimal(txt_precio.Text);
            txt_total.Text = total.ToString("#.##");
            txt_total.Visible = true;
            label8.Visible = true;
            btnIrPrimero.Enabled = true;
            btnAnterior.Enabled = true;
            btnSiguiente.Enabled = true;
            btnIrUltimo.Enabled = true;
            btnEliminar.Enabled = true;
        }
        #endregion

        #region Funcion para cargar grid

        public void Fnc_Cargagrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mamaterial", "SELECT ncodmaterial, vnombre, ncantidad, nprecio, nconsulta from mamaterial WHERE vestatus='ACTIVO'", "consulta", DGV_Inventario);
            }
        #endregion

        #region Form Load
        public void Frm_InvPrincipal_Load(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region Btn Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Txt_Status.Text = "ACTIVO";
            TextBox[] aDatos = { Txt_Nombre, Txt_Cantidad, Txt_Status, txt_precio };
            string sTabla = "mamaterial";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
            txt_precio.Clear();
            txt_total.Clear();
            Cancelar();
        }
        #endregion

        #region Btn Regargar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Fnc_Cargagrid();
        }
        #endregion

        #region Btn Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(Txt_Cantidad.Text);
            if (cantidad >= 1)
            {
                MessageBox.Show("Aun Hay cantidades existentes por lo cual no se puede eliminar");
            }
            else
            {
                clasnegocio cnegocio = new clasnegocio();
                string tabla, codEliminar, campoLlavePrimaria, campoEstado;
                tabla = "mamaterial";
                codEliminar = Txt_Id.Text;
                campoLlavePrimaria = "ncodmaterial";
                campoEstado = "vestatus";
                cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            }
            Fnc_Cargagrid();
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
            txt_precio.Clear();
            txt_total.Clear();
            Cancelar();
        }
        #endregion

        #region Btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { Txt_Nombre, Txt_Cantidad, txt_precio};  
            clasnegocio cn = new clasnegocio();             
            string tabla = "mamaterial";             
            Boolean permiso = true;
            string codigo = Txt_Id.Text;
            cn.EditarObjetos("mamaterial", permiso, arraytexto, codigo, "ncodmaterial");
            MessageBox.Show("Registro Actualizado");
            Fnc_Cargagrid();
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
            txt_precio.Clear();
            txt_total.Clear();
            Cancelar();
        }
        #endregion

        #region Btn Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funactivarDesactivarTextbox(Txt_Cantidad, true); 
            cnegocio.funactivarDesactivarTextbox(Txt_Nombre, true);
            cnegocio.funactivarDesactivarTextbox(txt_precio, true);
            cnegocio.funactivarDesactivarTextbox(txt_total, true);
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        #endregion

        #region Cancelar
        public void Cancelar()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_Cantidad, false);
            cnegocio.funactivarDesactivarTextbox(Txt_Nombre, false);
            cnegocio.funactivarDesactivarTextbox(txt_precio, false);
            cnegocio.funactivarDesactivarTextbox(txt_total, false);
            cnegocio.funactivarDesactivarTextbox(txt_total, false);
            label8.Visible = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
            txt_precio.Clear();
            txt_total.Clear();
        }
        #endregion

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        #endregion

        #region Btn Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tablaviene = "mamaterial";
            datos = "ncodmaterial,vnombre,ncantidad, precio";
            buscar busc = new buscar(tablaviene,datos); 
            busc.Show(); 
        }
        #endregion

        #region Btn IrPrimero
        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funPrimero(DGV_Inventario); 
        }
        #endregion

        #region Btn Anterior
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(DGV_Inventario);
        }
        #endregion

        #region Btn Siguiente
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funSiguiente(DGV_Inventario); 
        }
        #endregion

        #region Btn IrUltimo
        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funUltimo(DGV_Inventario);
        }
        #endregion

        #region Btn Imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            nomformulario = "nombre de su formulario"; 
            idaplicacion = 1; //id que se le asigno al formulario 
            idmodulo = 1; // id que se le asigno a su modulo 
            prueba1.Frm_Reporte FormCarga = new prueba1.Frm_Reporte(nomformulario,idaplicacion,idmodulo,idusuario,privilegio); 
            FormCarga.Show();
        }
        #endregion

        #region Btn Salir
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Llama Form consulta
        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Consulta form = new Frm_Consulta();
            form.Show();
        }
        #endregion

        #region Validaciones
        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz " + (char)8;

            if (!cadena .Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890. " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
