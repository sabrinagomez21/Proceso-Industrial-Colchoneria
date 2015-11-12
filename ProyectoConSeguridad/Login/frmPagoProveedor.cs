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
    public partial class frmPagoProveedor : Form
    {
        string scodigo, ssaldo, smonto, sCadena;
        public frmPagoProveedor()
        {
            InitializeComponent();
            funLlenar();
        }

        private void funLlenar()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodtipotransaccion", "SELECT concat(ncodtipotransaccion, '.', vnombredocumento) as nombre from matipotransaccion where vnombredocumento = 'PagoProveedor'", "nombre", cmbDocumento);
            cnegocio.funconsultarRegistrosCombo("ncodcuenta", "SELECT concat(ncodcuenta, '.', nnocuenta) as nombre from macuenta", "nombre", cmbCuenta);
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
        string funCortador(string sDato)
        {
            sCadena = "";
            int estado = 0;
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                   /* if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else if (sDato.Substring(i, 1) == ".")
                    {
                        sCadena = "";
                    }
                    else
                    {
                        break;
                    }*/
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
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("maproveedorbanco", "SELECT ncodproveedor as Codigo, cnombreproveedor as Nombre ,cestado as Estado, nsaldopendiente as Saldo  from maproveedorbanco WHERE cestado = 'ACTIVO' and cnombreproveedor LIKE '" + txtBuscar.Text + "%'", "consulta", dataGridView1);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtBuscar, true);
            cnegocio.funactivarDesactivarCombobox(cmbCuenta, true);
            btncancelar.Enabled = true;
            btnnuevo.Enabled = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            btnguardar.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarTextbox(txtBuscar, false);
            cn.funactivarDesactivarCombobox(cmbCuenta, false);
            txtBuscar.Clear();


            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
            btnimprimir.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
                {
                    smonto = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    scodigo = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Error al obtener Datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al obtener Datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
               
           
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            try
            {
                if ((smonto != "") || (scodigo != ""))
                {
                    txtFecha.Text = fecha.Year + "-" + fecha.Month + "-" + fecha.Day;
                    txtMonto.Text = smonto;
                    txtDocumento.Text = funCortadorID(cmbDocumento.Text);
                    txtCuenta.Text = funCortadorID(cmbCuenta.Text);
                    TextBox[] datos = { txtFecha, txtMonto, txtDocumento, txtCuenta };
                    string tabla = "trdocumentos";
                    Boolean permiso = true;
                    clasnegocio cn = new clasnegocio();
                    cn.AsignarObjetos(tabla, permiso, datos);

                    clasnegocio cnegocio = new clasnegocio();
                    cnegocio.funconsultarRegistrosCombo("ncoddocumento", "SELECT ncoddocumento from trdocumentos where dfecha = '" + txtFecha.Text + "' and nmonto = '" + txtMonto.Text + "' and ncodtipotransaccion = '" + txtDocumento.Text + "' and ncodcuenta = '" + txtCuenta.Text + "'", "ncoddocumento", cmbCodigo);

                    txtProveedor.Text = scodigo;
                    txtCodigo.Text = cmbCodigo.Text;

                    TextBox[] datos1 = { txtCodigo, txtProveedor };
                    string tabla1 = "trpagoproveedor";
                    Boolean permiso1 = true;
                    clasnegocio cn1 = new clasnegocio();
                    cn1.AsignarObjetos(tabla1, permiso1, datos1);
                   

                    MessageBox.Show("Se Ha Realizado el Pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cnegocio.funconsultarRegistrosCombo("ncodcuenta", "SELECT concat(ncodcuenta, '.', nsaldo) as nombre from macuenta where ncodcuenta = '" + txtCuenta.Text + "'", "nombre", cmbSaldo);
                    string ssub = cmbSaldo.Text;
                    string sadd = funCortador(ssub);
                    System.Console.WriteLine("sub->" + ssub+ "add->"+sadd);
                    txtSaldo.Text = sadd;

                    string ssaldo = "";
                    string stotal = "";
                    string scuenta = "";
                    scuenta = txtCuenta.Text;
                    ssaldo = txtSaldo.Text;
                    double dsaldo, dmonto, dtotal;
                    dsaldo = Convert.ToDouble(ssaldo);
                    dmonto = Convert.ToDouble(smonto);
                    dtotal = dsaldo - dmonto;
                    System.Console.WriteLine("saldo ->" + dsaldo + "monto->" + dmonto + "total->" + dtotal);
                    stotal = dtotal.ToString();
                    txtTotal.Text = stotal;

                    TextBox[] aDatosEdit = { txtTotal };
                    string sTabla = "macuenta";
                    string sCodigo = "ncodcuenta";
                    Boolean bPermiso = true;

                    cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, scuenta, sCodigo);


                    cnegocio.funconsultarRegistrosCombo("ncodproveedor", "SELECT concat(ncodproveedor, '.', nsaldopendiente) as nombre from maproveedorbanco where ncodproveedor = '" + txtProveedor.Text + "'", "nombre", cmbSaldoPendiente);
                    string spendiente = cmbSaldoPendiente.Text;
                    string ssaldopendiente = funCortador(spendiente);
                    txtSaldoPendiente.Text = ssaldopendiente;

                    string spendientesaldo = "";
                    string spendientetotal = "";
                    spendientesaldo = txtSaldoPendiente.Text;
                    double dpendiente, dpendientetotal;
                    dpendiente = Convert.ToDouble(spendientesaldo);
                    dpendientetotal = dpendiente - dmonto;
                    spendientetotal = dpendientetotal.ToString();
                    txtTotalPendiente.Text = spendientetotal;

                    TextBox[] aDatosEdit1 = { txtTotalPendiente };
                    string sTabla1 = "maproveedorbanco";
                    string sCodigo1 = "ncodproveedor";
                    string scuenta1 = txtProveedor.Text;
                    

                    cn.EditarObjetos(sTabla1, bPermiso, aDatosEdit1, scuenta1, sCodigo1);






                    txtTotalPendiente.Clear();
                    txtSaldoPendiente.Clear();
                    txtProveedor.Clear();
                    txtMonto.Clear();
                    txtFecha.Clear();
                    txtDocumento.Clear();
                    txtCuenta.Clear();
                    txtCodigo.Clear();
                    txtBuscar.Clear();
                    txtSaldo.Clear();

                    smonto = "";
                    scodigo = "";

                   


                }
                else
                {
                    MessageBox.Show("Error al obtener Datos"+e, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al realizar la operacion"+e, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
