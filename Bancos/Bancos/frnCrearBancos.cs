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

namespace Bancos
{
    public partial class frmCrearBancos : Form
    {
        string estado = "";
        string sCod;
        string sCodigoBanco;
        public frmCrearBancos()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            funLlenarcmbBancos();
            funLlenarTabla();
            cmbEstado.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtSaldo, true); 
            cnegocio.funactivarDesactivarTextbox(txtNoCuenta, true);
            cnegocio.funactivarDesactivarCombobox(cmbBanco, true);
            lblEstado.Visible = false;
            txtBuscar.Visible = false;
            //lblAgregar.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //string tabla = "macuenta";
            //Boolean permiso = true;

            string sTabla = "macuenta";
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            string sCadena = cmbBanco.Text;
            System.Console.WriteLine(sCadena);
            txtBancos.Clear();
            txtBancos.Text = sCadena.Substring(0, 1);
            txtEstado.Text = cmbEstado.SelectedItem.ToString();




            if (estado.Equals("editar"))
            {
                TextBox[] aDatosEdit = { txtSaldo, txtNoCuenta, txtEstado, txtBancos };
                string sCodigo = "ncodcuenta";

                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
                funLlenarTabla();


            }
            else if (estado.Equals("eliminar"))
            {
                //string sTabla = "matipotransaccion";
                string sCampoLlavePrimaria = "ncodcuenta";
                string sCampoEstado = "cestado";
                //System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {                
                txtEstado.Text = "Activo";
                
                System.Console.WriteLine(txtBancos.Text);
                //MessageBox.Show("INFO", "Los datos son:" + txtBancos.Text);
                TextBox[] datos = { txtSaldo, txtNoCuenta, txtEstado, txtBancos };
                
                cn.AsignarObjetos(sTabla, bPermiso, datos);                

                funLimpiar();
                //funLlenarTabla();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtSaldo, false);
            cn.funactivarDesactivarTextbox(txtNoCuenta, false);
            cn.funactivarDesactivarCombobox(cmbBanco, false);
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
            lblEstado.Visible = false;
            txtEstado.Visible = false;
            funLimpiar();
            funLlenarTabla(); 



            
        }

        void funLimpiar(){
            txtNoCuenta.Text = "";
            txtSaldo.Text = "";
            txtEstado.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funLimpiar();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtSaldo, false);
            cnegocio.funactivarDesactivarTextbox(txtNoCuenta, false);
            cnegocio.funactivarDesactivarCombobox(cmbBanco, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
            lblAgregar.Enabled = false;

            txtBuscar.Visible = false;
            //lblBuscar.Visible = false;
            lblNoCuenta.Visible = true;
            lblSaldo.Visible = true;
            //lblEstado.Visible = true;
            txtNoCuenta.Visible = true;
            txtSaldo.Visible = true;
            txtSaldo.Clear();
            txtNoCuenta.Clear();            
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;
            cmbEstado.Visible = false;
            lblEstado.Visible = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;

            funLlenarTabla();
        }

        void funLlenarTabla()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("macuenta", "SELECT ncodcuenta as Codigo, nsaldo as Saldo, nnocuenta as NoCuenta, cestado as Estado, ncodbanco as Banco from macuenta", "consulta", grdDatos);
        }
        void funLlenarcmbBancos()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodbanco", "SELECT concat(ncodbanco, '.', vnombrebanco) as nombre from mabanco WHERE cestado='Activo'", "nombre", cmbBanco);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNoCuenta.Clear();
            txtSaldo.Clear();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
            txtBuscar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNoCuenta, false);
            cn.funactivarDesactivarTextbox(txtSaldo, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
            cn.funactivarDesactivarCombobox(cmbBanco, false);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
            btnAnterior.Enabled = false;
            btnIrPrimero.Enabled = false;
            btnSiguiente.Enabled = false;
            btnIrUltimo.Enabled = false;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funLlenarTabla();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNoCuenta.Visible = false;
            lblSaldo.Visible = false;
            txtSaldo.Visible = false;
            cmbEstado.Visible = false;
            lblEstado.Visible = false;
            lblBancos.Enabled = false;
            cmbBanco.Visible = false;
            txtBuscar.Visible = true;
            txtBuscar.Enabled = true;
            lblBancos.Visible = false;
            cmbBanco.Visible = false;
            lblAgregar.Visible = false;            
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdDatos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDatos);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtNoCuenta, true);
                cn.funactivarDesactivarTextbox(txtSaldo, true);
                cn.funactivarDesactivarCombobox(cmbEstado, true);
                cn.funactivarDesactivarCombobox(cmbBanco, true);
                sCod = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtSaldo.Text = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtNoCuenta.Text = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[2].Value.ToString();
                
                txtNoCuenta.Enabled = true;
                
                string sCmb = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[3].Value.ToString();
                if (sCmb.Equals("Activo"))
                {
                    cmbEstado.SelectedIndex = 0;
                    cmbEstado.Enabled = false;
                    cmbEstado.Visible = false;
                    lblEstado.Visible = false;
                }
                else if (sCmb.Equals("INACTIVO"))
                {
                    cmbEstado.SelectedIndex = 1;
                    cmbEstado.Enabled = true;
                    cmbEstado.Visible = true;
                    lblEstado.Visible = true;
                }             

            } if (estado.Equals("eliminar"))
            {
                sCod = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("macuenta", "SELECT ncodcuenta as Codigo, nsaldo as Saldo ,nnocuenta as NoCuenta, cestado as Estado, ncodbanco as Banco  from macuenta WHERE nnocuenta LIKE '" + txtBuscar.Text + "%'", "consulta", grdDatos);
        }
       
    }
}
