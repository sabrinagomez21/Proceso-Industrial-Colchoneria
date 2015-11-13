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
    public partial class frmCrearBanco : Form
    {
        string estado = "";
        string sCod;
        string sCadena;
        public frmCrearBanco()
        {
            InitializeComponent();
            cmbEstado.SelectedIndex = 0;
            funLlenarTabla();
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
        }

        void funLlenarTabla()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mabanco", "SELECT ncodbanco as No, vnombrebanco as Nombre, vdireccion as Direccion, cestado as Estado from mabanco", "consulta", grdDatos);
        }

        string funCortador(string sDato)
        {
            sCadena = "";
            int estado = 0;
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {

                    switch (estado)
                    {
                        case 0:
                            if (sDato.Substring(i, 1) != ".")
                            {
                                sCadena = sCadena + sDato.Substring(i, 1);
                            }
                            else if (sDato.Substring(i, 1) == ".")
                            {
                                sCadena = "";
                                estado = 1;
                            }
                            else
                            {
                                break;
                            }
                            break;
                        case 1:
                            if (sDato.Substring(i, 1) != ".")
                            {
                                sCadena = sCadena + sDato.Substring(i, 1);
                            }
                            else if (sDato.Substring(i, 1) == ".")
                            {
                                sCadena = sCadena + sDato.Substring(i, 1);
                            }
                            else
                            {
                                break;
                            }

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

        void funLimpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEstado.Text = "";
            cmbEstado.SelectedIndex = 0;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtEstado, true);
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNombre.Clear();
            txtDireccion.Clear();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtDireccion, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string sTabla = "mabanco";
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            txtEstado.Text = cmbEstado.SelectedItem.ToString();




            if (estado.Equals("editar"))
            {
                TextBox[] aDatosEdit = { txtNombre, txtDireccion, txtEstado };
                string sCodigo = "ncodbanco";

                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);


            }
            else if (estado.Equals("eliminar"))
            {
                //string sTabla = "matipotransaccion";
                string sCampoLlavePrimaria = "ncodbanco";
                string sCampoEstado = "cestado";
                //System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {
                //string sTabla = "matipotransaccion";
                txtEstado.Text = "Activo";
                TextBox[] datos = { txtNombre, txtDireccion, txtEstado };
                cn.AsignarObjetos(sTabla, bPermiso, datos);

                funLimpiar();
                funLlenarTabla();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtNombre, false);
            cn.funactivarDesactivarTextbox(txtDireccion, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtNombre.Clear();
            txtDireccion.Clear();
            btnguardar.Enabled = true;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            funLlenarTabla();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
            lblDireccion.Visible = false;
            txtDireccion.Visible = false;
            cmbEstado.Visible = false;
            lblEstado.Visible = false;
            txtBuscar.Visible = true;
            txtBuscar.Enabled = true;
            //lblBuscar.Visible = true;
            btnguardar.Enabled = false;
            btncancelar.Enabled = true;
            btnnuevo.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
        }

        private void btnirPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdDatos);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDatos);
        }

        private void btnirUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDatos);
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtNombre, true);
                cn.funactivarDesactivarTextbox(txtDireccion, true);
                cn.funactivarDesactivarCombobox(cmbEstado, true);
                sCod = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtDireccion.Text = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[2].Value.ToString();
                cmbEstado.Visible = true;
                txtNombre.Enabled = true;
                lblEstado.Visible = true;
                cmbEstado.Enabled = true;
                string sCmb = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[3].Value.ToString();
                if (sCmb.Equals("Activo"))
                {
                    cmbEstado.SelectedIndex = 0;
                    cmbEstado.Enabled = false;
                    cmbEstado.Visible = false;
                    lblEstado.Visible = false;
                }
                else if (sCmb.Equals("Inactivo"))
                {
                    cmbEstado.SelectedIndex = 1;
                }

            } if (estado.Equals("eliminar"))
            {
                sCod = grdDatos.Rows[grdDatos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("mabanco", "SELECT ncodbanco as Codigo, vnombrebanco as Nombre ,vdireccion as Operacion, cestado as Estado  from mabanco WHERE vnombrebanco LIKE '" + txtBuscar.Text + "%'", "consulta", grdDatos);
        }
    }
}
