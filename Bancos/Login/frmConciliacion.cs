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
    public partial class frmConciliacion : Form
    {
        string sCadena;
        public frmConciliacion()
        {
            InitializeComponent();
            DateTime fecha = DateTime.Today;
            lblfeha.Text = fecha.Year.ToString() + "/" + fecha.Month.ToString() + "/" + fecha.Day.ToString();
            funBuscarCuentas();
        }
        private void funBuscarCuentas()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodcuenta", "SELECT concat(ncodcuenta, '.', nnocuenta) as nombre from macuenta", "nombre", cmbcuenta);
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
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
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
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }
        private void grbConciliacion_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtEncargado, true);
            cnegocio.funactivarDesactivarCombobox(cmbcuenta, true);
            cnegocio.funactivarDesactivarCombobox(cmbMes, true);
            btnrefrescar.Enabled = true;
            btncancelar.Enabled = true;

        }

        private void pnlInformacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEncargado.Text != "")
                {
                    txtcuenta.Text = funCortadorID(cmbcuenta.Text);
                    txtFecha.Text = lblfeha.Text;
                    TextBox[] datos = { txtFecha, txtEncargado, txtEstado, txtcuenta };
                    string tabla = "maencabezadoconciliacion";
                    Boolean permiso = true;
                    clasnegocio cn = new clasnegocio();
                    cn.AsignarObjetos(tabla, permiso, datos);
                    btnimprimir.Enabled = true;
                    btnguardar.Enabled = true;
                    funLlenarTabla();
                }

            }
            catch
            {
                MessageBox.Show("No se han encontrado datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEncargado.Text != "")
                {
                    txtcuenta.Text = funCortadorID(cmbcuenta.Text);
                    txtFecha.Text = lblfeha.Text;
                    TextBox[] datos = { txtFecha, txtEncargado, txtEstado, txtcuenta };
                    string tabla = "maencabezadoconciliacion";
                    Boolean permiso = true;
                    clasnegocio cn = new clasnegocio();
                    cn.AsignarObjetos(tabla, permiso, datos);
                    btnimprimir.Enabled = true;
                    btnguardar.Enabled = true;
                    funLlenarTabla();
                }

            }
            catch
            {
                MessageBox.Show("No se han encontrado datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void funLlenarTabla()
        {
            string mes;
            mes = cmbMes.SelectedItem.ToString();
            string cuenta = funCortador(cmbcuenta.Text);
            clasnegocio cnegocio = new clasnegocio();
            try
            {
                switch (mes)
                {
                    case "Enero":

                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-1-1' and '2015-1-31'", "consulta", dataGridView1);
                        break;
                    case "Febrero":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-2-1' and '2015-2-28'", "consulta", dataGridView1);
                        break;
                    case "Marzo":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-3-1' and '2015-3-31'", "consulta", dataGridView1);
                        break;
                    case "Abril":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-4-1' and '2015-4-30'", "consulta", dataGridView1);
                        break;
                    case "Mayo":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-5-1' and '2015-5-31'", "consulta", dataGridView1);
                        break;
                    case "Junio":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-6-1' and '2015-6-30'", "consulta", dataGridView1);
                        break;
                    case "Julio":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-7-1' and '2015-7-31'", "consulta", dataGridView1);
                        break;
                    case "Agosto":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-8-1' and '2015-8-31'", "consulta", dataGridView1);
                        break;
                    case "Septiembre":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-9-1' and '2015-9-30'", "consulta", dataGridView1);
                        break;
                    case "Octubre":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-10-1' and '2015-10-31'", "consulta", dataGridView1);
                        break;
                    case "Noviembre":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-11-1' and '2015-11-30'", "consulta", dataGridView1);
                        break;
                    case "Diciembre":
                        cnegocio.funconsultarRegistros("trdocumentos", "SELECT trdocumentos.ncoddocumento as Codigo, trdocumentos.dfecha as Fecha, matipotransaccion.vnombredocumento as Nombre, trdocumentos.dmonto as Monto FROM trdocumentos, matipotransaccion, macuenta WHERE trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND trdocumentos.ncodcuenta = macuenta.ncodcuenta AND macuenta.nnocuenta = '" + cuenta + "' AND trdocumentos.dfecha BETWEEN '2015-12-1' and '2015-12-31'", "consulta", dataGridView1);
                        break;

                }
            }catch{
                MessageBox.Show("No se han encontrado datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodconcilicacion", "SELECT ncodconcilicacion as codigo from maencabezadoconciliacion where dfecha = '" + lblfeha.Text + "' and encargado = '" + txtEncargado.Text + "' ", "codigo", cmbCodigo);
            txtCodigo.Text = cmbCodigo.Text;
            string sCod;
            clasnegocio cn = new clasnegocio();
            int iFila = dataGridView1.RowCount;
            

            for (int i = 0; i < iFila - 1; i++)
            {
                
                    sCod = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    txtCodDoc.Text = sCod;
                    TextBox[] datos = {txtCodigo, txtCodDoc };
                    string tabla = "trdetalleconciliacion";
                    Boolean permiso = true;
                    
                    cn.AsignarObjetos(tabla, permiso, datos);

                   
               
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtEncargado, false);
            cnegocio.funactivarDesactivarCombobox(cmbMes, false);
            cnegocio.funactivarDesactivarCombobox(cmbcuenta, false);
            btnguardar.Enabled = false;
            btnimprimir.Enabled = false;
            txtEncargado.Clear();


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funimprimir(txtComentario);
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
            cnegocio.funUltimo(dataGridView1);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio(); 
            cnegocio.funUltimo(dataGridView1);
        }

        private void frmConciliacion_Load(object sender, EventArgs e)
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
