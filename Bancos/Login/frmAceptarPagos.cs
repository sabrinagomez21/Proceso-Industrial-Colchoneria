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
    public partial class frmAceptarPagos : Form
    {
        string sCadena;
        public frmAceptarPagos()
        {
            InitializeComponent();
            funLlenar();
        }
        private void funLlenar()
        {
            clasnegocio cnegocio = new clasnegocio();
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


        void funLlenarTabla()
        {
            string sCuenta = funCortadorID(cmbCuenta.Text);
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("trdocumentos", "SELECT maproveedor.vnombre as nombre, trdocumentos.ncoddocumento as codigo, trdocumentos.dfecha as fecha, trdocumentos.dmonto as monto, matipotransaccion.vnombredocumento FROM maproveedor, trdocumentos, matipotransaccion, trpagoproveedor WHERE maproveedor.ncodproveedor = trpagoproveedor.ncodproveedor AND trpagoproveedor.ncoddocumento = trdocumentos.ncoddocumento AND trdocumentos.ncodtipotransaccion = matipotransaccion.ncodtipotransaccion AND matipotransaccion.vnombredocumento = 'PagoProveedor' AND trdocumentos.ncodcuenta = '" + sCuenta + "' and trdocumentos.ncoddocumento NOT IN (SELECT trdocumentosaceptados.ncoddocumento FROM trdocumentosaceptados)", "consulta", grdDatos);

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            funLlenarTabla();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            string sCod;
            string sMonto;
            string sNumero;
            double dMonto, dSaldo, dTotal;
            string sSaldo, sTotal;
            Boolean bPermiso = true;
            int iFila = grdDatos.RowCount;
            for (int i = 0; i < iFila - 1; i++)
            {

                sCod = grdDatos.Rows[i].Cells[1].Value.ToString();
                sMonto = grdDatos.Rows[i].Cells[3].Value.ToString();
                TextBox txtcodigo = new TextBox();
                txtcodigo.Text = sCod;
                txtcodigo.Tag = "ncoddocumento";

                TextBox txtmonto = new TextBox();
                txtmonto.Text = sMonto;
                txtmonto.Tag = "nmonto";

                TextBox txtestado = new TextBox();
                txtestado.Text = "Activo";
                txtestado.Tag = "cestado";

                TextBox[] datos = { txtestado, txtmonto, txtcodigo };
                string tabla = "trdocumentosaceptados";
                Boolean permiso = true;

                cn.AsignarObjetos(tabla, permiso, datos);

                string sCuenta = funCortadorID(cmbCuenta.Text);
                cn.funconsultarRegistrosCombo("macuenta", "SELECT concat(ncodcuenta, '.', nsaldo) as Doc FROM macuenta WHERE ncodcuenta='" + sCuenta + "'", "Doc", cmbSaldo);
                TextBox txtSaldo = new TextBox();
                System.Console.WriteLine(cmbSaldo.Text);
                txtSaldo.Text = funCortador(cmbSaldo.Text);


                sSaldo = txtSaldo.Text;
                dSaldo = Convert.ToDouble(sSaldo);
                dMonto = Convert.ToDouble(sMonto);
                System.Console.WriteLine("SALDO:  " + dSaldo + "Monto:  " + dMonto);
                dTotal = dSaldo - dMonto;
                sTotal = dTotal.ToString();

                TextBox txtTotal = new TextBox();
                txtTotal.Text = sTotal;
                txtTotal.Tag = "nsaldo";

                TextBox[] aDatosEdit1 = { txtTotal };
                string sTabla1 = "macuenta";
                string sCodigo1 = "ncodcuenta";
                string scuenta1 = funCortadorID(cmbSaldo.Text);


                cn.EditarObjetos(sTabla1, bPermiso, aDatosEdit1, scuenta1, sCodigo1);

            }
            funLlenarTabla();
        }

        private void frmAceptarPagos_Load(object sender, EventArgs e)
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarCombobox(cmbCuenta, true);
            btncancelar.Enabled = true;
            btnnuevo.Enabled = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = true;
            btnbuscar.Enabled = false;
            btnguardar.Enabled = true;
            btnimprimir.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarCombobox(cmbCuenta, false);
            btncancelar.Enabled = false;
            btnnuevo.Enabled = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnrefrescar.Enabled = false;
            btnbuscar.Enabled = false;
            btnguardar.Enabled = false;
        }
    }
}
