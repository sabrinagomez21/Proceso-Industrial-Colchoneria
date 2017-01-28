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
            cnegocio.funconsultarRegistros("mamaterial", "SELECT ncodmaterial, vnombre, ncantidad from mamaterial WHERE vestatus='ACTIVO'", "consulta", DGV_Inventario);
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
            TextBox[] aDatos = { Txt_Nombre, Txt_Cantidad, Txt_Status };
            string sTabla = "mamaterial";
            Boolean bPermiso = true;
            clasnegocio cn = new clasnegocio();
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            MessageBox.Show("Registro Guardado");
            Fnc_Cargagrid();
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
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
            clasnegocio cnegocio = new clasnegocio(); 
            string tabla, codEliminar, campoLlavePrimaria, campoEstado; 
            tabla = "mamaterial"; 
            codEliminar = Txt_Id.Text; 
            campoLlavePrimaria = "ncodmaterial"; 
            campoEstado = "vestatus"; 
            cnegocio.funeliminarRegistro(tabla, codEliminar, campoLlavePrimaria, campoEstado);
            Fnc_Cargagrid();
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
        }
        #endregion

        #region Btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            TextBox[] arraytexto = { Txt_Nombre, Txt_Cantidad};  
            clasnegocio cn = new clasnegocio();             
            string tabla = "mamaterial";             
            Boolean permiso = true;
            string codigo = Txt_Id.Text;
            cn.EditarObjetos("mamaterial", permiso, arraytexto, codigo, "ncodmaterial");
            MessageBox.Show("Registro Actualizado");
            Fnc_Cargagrid();
            Txt_Cantidad.Clear();
            Txt_Nombre.Clear();
        }
        #endregion

        #region Btn Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funactivarDesactivarTextbox(Txt_Cantidad, true); 
            cnegocio.funactivarDesactivarTextbox(Txt_Nombre, true);
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        #endregion

        #region Btn Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(Txt_Cantidad, false);
            cnegocio.funactivarDesactivarTextbox(Txt_Nombre, false);
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
        }
        #endregion

        #region Btn Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tablaviene = "mamaterial";
            datos = "ncodmaterial,vnombre,ncantidad";
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
    }
}
