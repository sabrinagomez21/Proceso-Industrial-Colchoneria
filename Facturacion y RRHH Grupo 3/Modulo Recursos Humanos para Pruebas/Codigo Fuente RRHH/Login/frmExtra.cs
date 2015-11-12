using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmExtra : Form
    {
        public frmExtra()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\DETALLE  |*.pdf";
            ofd.ShowDialog();

            if (ofd.FileName == @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\DETALLE.pdf")
            {
                axAcroPDF1.LoadFile(ofd.FileName);

            }
            else
            {
                MessageBox.Show("Documento no encontrado");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
