using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH
{
    public partial class frmExtra1 : Form
    {
        public frmExtra1()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\  |*.pdf";
            ofd.ShowDialog();

            if (ofd.FileName == @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\DETALLE.pdf")
            {
                axAcroPDF1.LoadFile(ofd.FileName);

            }else{
                MessageBox.Show("Documento no encontrado");
            }
            
            

           }

        private void desarrolloOrganizacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();

             ofd.Filter = @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\ |*.pdf";
            ofd.ShowDialog();

            if (ofd.FileName == @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\DESARROLLO.pdf")
            {
                axAcroPDF1.LoadFile(ofd.FileName);

            }else{
                MessageBox.Show("Documento no encontrado");
            }
            
            

           }

        private void fODAToolStripMenuItem_Click(object sender, EventArgs e)
        { OpenFileDialog ofd = new OpenFileDialog();

        ofd.Filter = @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\  |*.pdf";
            ofd.ShowDialog();

            if (ofd.FileName == @"C:\Users\Gomez\Downloads\RRHH\RRHH\bin\Debug\FODA.pdf")
            {
                axAcroPDF1.LoadFile(ofd.FileName);

            }else{
                MessageBox.Show("Documento no encontrado");
            }
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Dispose();
            this.Close();
        }
        }
        }
    

