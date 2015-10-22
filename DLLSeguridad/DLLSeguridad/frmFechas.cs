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

        private void rbDesactivado_CheckedChanged(object sender, EventArgs e)
        {
            rbfecha2.Checked = false;
            rbfecha1.Checked = false;
            btnaccept.Enabled = true;
            this.Width = 513;
        }

        private void rbfecha2_CheckedChanged(object sender, EventArgs e)
        {
            rbDesactivado.Checked = false;
            rbfecha1.Checked = false;
            btnaccept.Enabled = true;
            this.Width = 790;
        }

        private void mcFecha1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha1=mcFecha1.SelectionRange.End.Date.ToString("yyyy/MM/dd");
            mcFecha2.MinDate = mcFecha1.SelectionEnd;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcFecha2_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha2 = mcFecha2.SelectionRange.End.Date.ToString("yyyy/MM/dd");
        }

        private void rbfecha1_CheckedChanged(object sender, EventArgs e)
        {
            rbDesactivado.Checked = false;
            rbfecha2.Checked = false;
            btnaccept.Enabled = true;
            this.Width = 513;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            if (rbfecha1.Checked == true)
            {
                if (fecha1 != null)
                {
                    E_Usuario.date1 = fecha1;
                    E_Usuario.date2 = null;
                    presentacionHandler.Fecha(fecha1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fecha");
                }

            }
            else if (rbfecha2.Checked == true)
            {
                if (fecha1 != null || fecha2 != null)
                {
                    E_Usuario.date1 = fecha1;
                    E_Usuario.date2 = fecha2;
                    presentacionHandler.Fechas(fecha1, fecha2);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar ambas fechas");
                }

            }
            else{
                E_Usuario.date1 = null;
                E_Usuario.date2 = null;
            }
        }  
    }
}
