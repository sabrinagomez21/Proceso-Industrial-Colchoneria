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
    public partial class frmRplanilla : Form
    {
        public frmRplanilla()
        {
            InitializeComponent();
        }

        string basedatos = "COLCHONERIA";
        string tabla = "TrPLANILLA";
        string tabla2 = "MaEMPLEADO";

        string squery;
        string empleado;
        private void frmRplanilla_Load(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtHorasEx, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoB, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoN, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldoxh, false);
            cnegocio.funactivarDesactivarTextbox(txtsueldoxhe, false);
            cnegocio.funactivarDesactivarBoton(btnnuevo, false);
            cnegocio.funactivarDesactivarBoton(btnguardar, false);
            cnegocio.funactivarDesactivarBoton(btneditar, false);
            cnegocio.funactivarDesactivarBoton(btneliminar, false);
            cnegocio.funactivarDesactivarBoton(btncancelar, false);
            cnegocio.funactivarDesactivarTextbox(txtSueldo, false);


            sfundatos(tabla, basedatos, "nsalario,vhorasnormales,vhorasextra,vnombreempleado,vapellidoempleado,nsemanas,vdetalle,ncodempresa");

        }

        public void sfundatos(String tabla, String basedatos, String camposvisualizar)
        {
            clasnegocio cnegocio = new clasnegocio();
            squery = ("SELECT " + camposvisualizar + " FROM " + tabla + " INNER JOIN " + tabla2 + " ON " + tabla + ".ncodempleado=" + tabla2 + ".ncodempleado");

            cnegocio.funconsultarRegistros(tabla, squery, "consulta", grdRplanilla);

        }


        private void grdRplanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empleado = grdRplanilla[0, grdRplanilla.CurrentCell.RowIndex].Value.ToString();

            clasnegocio cnegocio = new clasnegocio();
            squery = "SELECT nsalario from " + tabla2 + "WHERE ncodempleado= " + empleado;
            txtSueldo.Text = empleado;
            //salario = Convert.ToInt32(squery);
            //txtSueldo.Text =Convert.ToString(salario);
        }

        

        
        private void txtSueldo_TextChanged_1(object sender, EventArgs e)
        {
            float Sueldoxh, sueldoxhe, sueldon;
            string horast, horaste;
            if (string.IsNullOrWhiteSpace(txtSueldo.Text))
            {
            }
            else
            {
                Sueldoxh = (float.Parse(txtSueldo.Text) / 30) / 8;
                txtSueldoxh.Text = Convert.ToString(Sueldoxh);
                sueldoxhe = Sueldoxh * float.Parse("1.5");
                txtsueldoxhe.Text = Convert.ToString(sueldoxhe);
                horast = grdRplanilla[1, grdRplanilla.CurrentCell.RowIndex].Value.ToString();
                txtSueldoB.Text = Convert.ToString(float.Parse(horast) * Sueldoxh);
                horaste = grdRplanilla[2, grdRplanilla.CurrentCell.RowIndex].Value.ToString();
                txtHorasEx.Text = Convert.ToString(float.Parse(horaste) * sueldoxhe);
                sueldon = (float.Parse(txtSueldoB.Text)) + (float.Parse(txtHorasEx.Text));
                txtSueldoN.Text = Convert.ToString(sueldon);
            }
        }

        private void grdRplanilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSueldoxh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnirprimero_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdRplanilla);
        
        }

        private void btnanterior_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdRplanilla);

        }

        private void btnsiguiente_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdRplanilla);

        }

        private void btnirultimo_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdRplanilla);


        }

        private void btnrefrescar_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("TrPLANILLA", "SELECT vhorasnormales AS Horas_trabajadas,vhorasextra as Horas_extras,nsemanas as Semanas,vdetalle as Detalle,ncodempleado as Empleado,ncodempresa as Empresa", "consulta", grdRplanilla);
        
        }

    }

}
