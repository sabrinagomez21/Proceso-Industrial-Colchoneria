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
        string result = "0";
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
            recluta.Show();
        }

        private void dESARROLLOORGANIZACIONALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cONTRATACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sELECCIONDEPERSONALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContrato llena = new frmContrato();
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
            planilla.Show();
        }

        private void cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCapacitacion capacita = new frmCapacitacion();
            capacita.Show();
        }

        private void rELACIONESLABORALESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEvaluacionDesempeño desempeño = new frmEvaluacionDesempeño();
            desempeño.Show();
        }

        private void frmPRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void dETALLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtra1 extra = new frmExtra1();
            extra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {using (OdbcConnection cnn = new OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};server=localhost;uid=root;database=colchoneria;port=3306"))
                {
                    cnn.Open();
                        string query = "SELECT doc FROM documentos where nombre = 'FODA.pdf'";
                        OdbcCommand cmd = new OdbcCommand(query, cnn);

                        OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        griDatos.DataSource = dt;

                        string getValue = cmd.ExecuteScalar().ToString();
          
                        PrintDocument ss = new PrintDocument();
                        MessageBox.Show("esto lleva ´" + getValue);
                        ss.DocumentName = cmd.ExecuteScalar().ToString();
                        ss.Print();
                        cnn.Close();
                        
                        
                        




                }
            
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
    }
}




                    //if (ofd.FileName != "")
                      // {
                        //axAcroPDF1.LoadFile(ofd.FileName);
                        //}else{
                          //     MessageBox.Show("Documento no encontrado");
                           //   }
                            //    }
              //catch (Exception Ex)
               // {
                 //   MessageBox.Show(Ex.Message, "Error ---------------", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //}

          
//           }
                /*   string resultado;
                    string query = "SELECT nombre FROM documentos where nombre = 'FODA.pdf' ";
                    OdbcCommand cmd = new OdbcCommand(query, cnn);
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    griDatos.DataSource = dt;
                   // resultado = Convert.ToString(dt);
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "PDF file |*.pdf";
                    saveFileDialog1.Title = "guardando documento";
                    saveFileDialog1.ShowDialog();
                    //saveFileDialog1.FileName = dt.ToString();

                    if (saveFileDialog1.FileName != "")
                    {

                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        saveFileDialog1.FileName = dt.ToString();
                        axAcroPDF1.LoadFile(saveFileDialog1.FileName);
                        axAcroPDF1.Print();
                       fs.Close();
                    }
                    */
                  

                   
               // }
               // catch (Exception Ex)
                //{
                 //   MessageBox.Show(Ex.Message, "Error ---------------", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                //}



            
   

    




   
