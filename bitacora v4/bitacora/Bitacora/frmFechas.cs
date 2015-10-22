//La función del siguiente formulario es la de gestionar las consultas contando con un filtro de fechas pudiendo selecinar entre
//la opción de una fecha o entre 2 fechas

//Programador y Analista: José Wilfredo Chacón Cartagena
//Fecha de Asignación: 08/10/2015
//Fecha de Entrega: 21/10/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitacora
{
    public partial class frmFechas : Form
    {
        private Presentacion presentacionHandler;
        private string fecha1;
        private string fecha2;
        public frmFechas()
        {
            InitializeComponent();
        }
        public frmFechas(Presentacion Form)
        {
            InitializeComponent();
            presentacionHandler = Form;
        }

        //Habilita el boton aceptar
        private void rbDesactivado_CheckedChanged(object sender, EventArgs e)
        {
            rbfecha2.Checked = false;
            rbfecha1.Checked = false;
            btnaccept.Enabled = true;
            this.Width = 513;
        }

        //Habilitar un segundo calendario y el boton aceptar
        private void rbfecha2_CheckedChanged(object sender, EventArgs e)
        {
            rbDesactivado.Checked = false;
            rbfecha1.Checked = false;
            btnaccept.Enabled = true;
            this.Width = 790;
        }

        //Obtiene la fecha seleccionada
        private void mcFecha1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha1=mcFecha1.SelectionRange.End.Date.ToString("yyyy/MM/dd");
        }

        //Cierra el formulario
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Obtiene la fecha seleccionada
        private void mcFecha2_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha2 = mcFecha2.SelectionRange.End.Date.ToString("yyyy/MM/dd");
        }

        //Habilita 1 calendario y el boton aceptar
        private void rbfecha1_CheckedChanged(object sender, EventArgs e)
        {
            rbDesactivado.Checked = false;
            rbfecha2.Checked = false;
            btnaccept.Enabled = true;
            this.Width = 513;
        }

        //Verifica si se ha seleccionado una fecha, si se seleccionaron 2 fechas, sino no se selecciono nada, en caso de no seleccionar
        //nada entonces el boton permanece deshabilitado
        private void btnaccept_Click(object sender, EventArgs e)
        {
            if (rbfecha1.Checked == true)
            {
                E_Usuario.date1 = fecha1;
                E_Usuario.date2 = null;
                presentacionHandler.Fecha(fecha1);
                this.Close();
            }
            else if (rbfecha2.Checked == true)
            {
                E_Usuario.date1 = fecha1;
                E_Usuario.date2 = fecha2;
                presentacionHandler.Fechas(fecha1, fecha2);
                this.Close();
            }
            else{
                E_Usuario.date1 = null;
                E_Usuario.date2 = null;
            }
        }  
    }
}
