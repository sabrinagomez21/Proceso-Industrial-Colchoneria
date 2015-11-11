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
    public partial class frmEmpleados : Form
    {
        string estado = "";
        string sCod;
        public frmEmpleados()
        {
            InitializeComponent();
            funActualizarGrid();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maempleadobanco", "SELECT ncodempleado as Codigo, cnombre as Nombre ,nsalario as Salario, nnocuenta as Cuenta, cestado as Estado  from maempleadobanco where cestado = 'ACTIVO'", "consulta", dgvEmpleado);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtCuenta, true);
            cnegocio.funactivarDesactivarTextbox(txtSalario, true);
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
            txtNombre.Clear();
            txtCuenta.Clear();
            txtSalario.Clear();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtCuenta, false);
            cn.funactivarDesactivarTextbox(txtSalario, false);
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
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            if (estado.Equals("editar"))
            {
                
                TextBox[] aDatosEdit = { txtNombre, txtSalario, txtCuenta };
                string sTabla = "maempleadobanco";
                string sCodigo = "ncodempleado";

                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);


            }
            else if (estado.Equals("eliminar"))
            {
                string sTabla = "maempleadobanco";
                string sCampoLlavePrimaria = "ncodempleado";
                string sCampoEstado = "cestado";
                System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {
                
                TextBox[] aDatos = { txtNombre, txtSalario, txtCuenta, txtEstado };
                string sTabla = "maempleadobanco";
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                funActualizarGrid();
                txtNombre.Clear();
                txtCuenta.Clear();
                txtSalario.Clear();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtCuenta, false);
            cn.funactivarDesactivarTextbox(txtSalario, false);
            txtNombre.Clear();
            txtCuenta.Clear();
            txtSalario.Clear();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
            funActualizarGrid();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtCuenta, false);
            cn.funactivarDesactivarTextbox(txtSalario, false);
            txtNombreBuscar.Visible = false;
            lblNombreBuscar.Visible = false;
            lblNombre.Visible = true;
            lblCuenta.Visible = true;
            lblSalario.Visible = true;
            txtNombre.Visible = true;
            txtCuenta.Visible = true;
            txtSalario.Visible = true;
            txtNombre.Clear();
            txtCuenta.Clear();
            txtSalario.Clear();
            


            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = true;
            funActualizarGrid();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvEmpleado);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funAnterior(dgvEmpleado); 
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvEmpleado);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvEmpleado);
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtNombre, true);
                cn.funactivarDesactivarTextbox(txtCuenta, true);
                cn.funactivarDesactivarTextbox(txtSalario, true);
                sCod = dgvEmpleado.Rows[dgvEmpleado.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleado.Rows[dgvEmpleado.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtSalario.Text = dgvEmpleado.Rows[dgvEmpleado.CurrentCell.RowIndex].Cells[2].Value.ToString();
                txtCuenta.Text = dgvEmpleado.Rows[dgvEmpleado.CurrentCell.RowIndex].Cells[3].Value.ToString();

            } if (estado.Equals("eliminar"))
            {
                sCod = dgvEmpleado.Rows[dgvEmpleado.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            lblNombre.Visible = false;
            txtCuenta.Visible = false;
            lblCuenta.Visible = false;
            txtSalario.Visible = false;
            lblSalario.Visible = false;
            txtNombreBuscar.Visible = true;
            lblNombreBuscar.Visible = true;

            btnguardar.Enabled = false;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void txtNombreBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maempleadobanco", "SELECT ncodempleado as Codigo, cnombre as Nombre ,nsalario as Salario, nnocuenta as Cuenta, cestado as Estado  from maempleadobanco where cestado = 'ACTIVO' AND cnombre LIKE '"+txtNombreBuscar.Text+"%'", "consulta", dgvEmpleado);

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
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
