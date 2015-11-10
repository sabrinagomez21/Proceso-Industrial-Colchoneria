using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.Odbc;
using System.Diagnostics;
//Programadora y Analista Sabrina Maria Gomez Giron
namespace RRHH
{
    public partial class frmPRINCIPAL : Form
    {
        public frmPRINCIPAL()
        {
            InitializeComponent();
        }
        
        private void dESARROLLOORGANIZACIONLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hIGIENEYSALUDENELTRABAJOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapacitacion capacita = new frmCapacitacion();
            capacita.Show();
        }

        private void rECLUTAMIENTODEPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReclutamiento recluta = new frmReclutamiento();
            recluta.MdiParent = this;
            recluta.Show();
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem.Click += new System.EventHandler(this.rECLUTAMIENTODEPERSONALToolStripMenuItem_Click);
        }


        private void dESARROLLOORGANIZACIONALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cONTRATACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sELECCIONDEPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmReqPuesto llena = new frmReqPuesto();
           
            llena.MdiParent = this;
            llena.Show();

        }

        private void rELACIONESLABORALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvaluacionDesempeño desempeño = new frmEvaluacionDesempeño();
            desempeño.Show();
        }



        private void pLANILLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanilla planilla = new frmPlanilla();
            planilla.Show();
        }

        private void cONTRATADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pLANILLAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPlanilla planilla = new frmPlanilla();
            planilla.MdiParent = this;
            planilla.Show();
        }

        private void cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCapacitacion capacita = new frmCapacitacion();
            capacita.MdiParent = this;
            capacita.Show();
        }

        private void rELACIONESLABORALESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEvaluacionDesempeño desempeño = new frmEvaluacionDesempeño();
            desempeño.MdiParent = this;
            desempeño.Show();
        }

        private void frmPRINCIPAL_Load(object sender, EventArgs e)
        {

            menuStrip2.Visible = false;

        }

        private void dETALLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip2.Visible = true;

            frmExtra1 extra = new frmExtra1();
            extra.MdiParent = this;
            extra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
         }
             private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}




     



   
