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

namespace Login
{
    public partial class frmCrearCuenta : Form
    {
        string estado = "";
        string sCod;
        string sCodigoBanco;
        string sCadena;
        public frmCrearCuenta()
        {
            InitializeComponent();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            funLlenarcmbBancos();
            funLlenarTabla();
            cmbEstado.SelectedIndex = 0;
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

        void funLimpiar()
        {
            txtNoCuenta.Text = "";
            txtSaldo.Text = "";
            txtEstado.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        string funCortadorID(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
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
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNoCuenta.Clear();
            txtSaldo.Clear();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
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
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            btnanterior.Enabled = false;
            btnirPrimero.Enabled = false;
            btnsiguiente.Enabled = false;
            btnirUltimo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //string tabla = "macuenta";
            //Boolean permiso = true;

            string sTabla = "macuenta";
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            //string sCadena = cmbBanco.Text;
            System.Console.WriteLine(sCadena);
            txtBancos.Clear();
            txtBancos.Text = funCortadorID(cmbBanco.Text);
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
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
            lblEstado.Visible = false;
            txtEstado.Visible = false;
            funLimpiar();
            funLlenarTabla(); 
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

            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;

            funLlenarTabla();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funLlenarTabla();
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
            btnguardar.Enabled = false;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
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

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            clasnegocio nuevo = new clasnegocio();
            nuevo.funactivarDesactivarBoton(btnnuevo, Convert.ToBoolean(Permisos.btnnuevo));
            nuevo.funactivarDesactivarBoton(btneditar, Convert.ToBoolean(Permisos.btneditar));
            nuevo.funactivarDesactivarBoton(btneliminar, Convert.ToBoolean(Permisos.btneliminar));
            nuevo.funactivarDesactivarBoton(btnguardar, Convert.ToBoolean(Permisos.btnguardar));
            nuevo.funactivarDesactivarBoton(btncancelar, Convert.ToBoolean(Permisos.btncancelar));
            nuevo.funactivarDesactivarBoton(btnrefrescar, Convert.ToBoolean(Permisos.btnrefrescar));
            nuevo.funactivarDesactivarBoton(btnimprimir, Convert.ToBoolean(Permisos.btnimprimir));
            nuevo.funactivarDesactivarBoton(btnbuscar, Convert.ToBoolean(Permisos.btnbuscar));
            nuevo.funactivarDesactivarBoton(btnirPrimero, Convert.ToBoolean(Permisos.btnirPrimiero));
            nuevo.funactivarDesactivarBoton(btnanterior, Convert.ToBoolean(Permisos.btnanterior));
            nuevo.funactivarDesactivarBoton(btnsiguiente, Convert.ToBoolean(Permisos.btnsiguiente));
            nuevo.funactivarDesactivarBoton(btnirUltimo, Convert.ToBoolean(Permisos.btnirUltimo));
        }
    }
}
