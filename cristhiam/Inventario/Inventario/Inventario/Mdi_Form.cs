using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Mdi_Form : Form
    {
        public Mdi_Form()
        {
            InitializeComponent();
        }

        private void Mdi_Form_Load(object sender, EventArgs e)
        {
            
        }

        //Autor: Cristhiam Duarte
        //Fecha: 23/10/15
        #region Materia Prima
        private void materiaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Frm_MateriaPrima materiaprima = new Frm_MateriaPrima();
            materiaprima.MdiParent = this;
            materiaprima.Show();   
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 23/10/15
        #region Inventario principal
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_InvPrincipal form = new Frm_InvPrincipal();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 23/10/15
        #region Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
