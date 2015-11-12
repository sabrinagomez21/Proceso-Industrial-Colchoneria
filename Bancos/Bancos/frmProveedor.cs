﻿using System;
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
    public partial class frmProveedor : Form
    {
        string estado = "";
        string sCod;
        public frmProveedor()
        {
            InitializeComponent();
            funActualizarGrid();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maproveedorbanco", "SELECT ncodproveedor as Codigo, cnombreproveedor as Nombre, cestado as Estado, nsaldopendiente as Saldo   from maproveedorbanco where cestado = 'ACTIVO'", "consulta", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (estado.Equals("editar"))
            {
                clasnegocio cn = new clasnegocio();
                cn.funactivarDesactivarTextbox(txtProvedor, true);
                cn.funactivarDesactivarTextbox(txtSaldo, true);
                sCod = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txtProvedor.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                txtSaldo.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
                

            } if (estado.Equals("eliminar"))
            {
                sCod = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtProvedor, true);
            cnegocio.funactivarDesactivarTextbox(txtSaldo, true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtProvedor.Clear();
            txtSaldo.Clear();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtProvedor, false);
            cn.funactivarDesactivarTextbox(txtSaldo, false);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            if (estado.Equals("editar"))
            {
                
                TextBox[] aDatosEdit = { txtProvedor, txtSaldo };
                string sTabla = "maproveedorbanco";
                string sCodigo = "ncodproveedor";

                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);


            }
            else if (estado.Equals("eliminar"))
            {
                string sTabla = "maproveedorbanco";
                string sCampoLlavePrimaria = "ncodproveedor";
                string sCampoEstado = "cestado";
                System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
            }
            else if (estado.Equals(""))
            {
                
                TextBox[] aDatos = {txtProvedor, txtEstado, txtSaldo };
                string sTabla = "maproveedorbanco";
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                funActualizarGrid();
                txtProvedor.Clear();
                txtSaldo.Clear();
            }

            estado = "";
            cn.funactivarDesactivarTextbox(txtProvedor, false);
            cn.funactivarDesactivarTextbox(txtSaldo, false);
            txtProvedor.Clear();
            txtSaldo.Clear();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
            funActualizarGrid();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtProvedor, false);
            cn.funactivarDesactivarTextbox(txtSaldo, false);
            txtBuscar.Visible = false;
            lblBuscar.Visible = false;
            lblProveedor.Visible = true;
            lblSaldo.Visible = true;
            txtProvedor.Visible = true;
            txtSaldo.Visible = true;
            txtProvedor.Clear();
            txtSaldo.Clear();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
            funActualizarGrid();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
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
            txtProvedor.Visible = false;
            lblProveedor.Visible = false;
            txtSaldo.Visible = false;
            lblSaldo.Visible = false;
            txtBuscar.Visible = true;
            lblBuscar.Visible = true;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maproveedorbanco", "SELECT ncodproveedor as Codigo, cnombreproveedor as Nombre ,cestado as Estado, nsaldopendiente as Saldo  from maproveedorbanco WHERE cestado = 'ACTIVO' and cnombreproveedor LIKE '" + txtBuscar.Text + "%'", "consulta", dataGridView1);
        }

    }
}

