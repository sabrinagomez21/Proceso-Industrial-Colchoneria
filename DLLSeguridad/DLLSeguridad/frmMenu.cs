using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLSeguridad
{
    public partial class frmMenu : Form
    {
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolBoton;
        private ToolStripDropDownButton dropDownButton1;
        private ToolStripMenuItem MenuItem;
        public frmMenu()
        {
            InitializeComponent();
            CargarInfo();
            //Pruebas();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        public void CargarInfo()
        {

            int TotModul = new N_Login().ContarModulos();
            toolStrip1 = new System.Windows.Forms.ToolStrip();

            for (int i = 1; i <= TotModul; i++)
            {
                string nameddB = new N_Login().NombreModulos(i);
                dropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
                dropDownButton1.Text = nameddB;
                dropDownButton1.Tag = i;

                int TotAppli = new N_Login().ContarAplicaciones(i);
                List<string> list2 = new N_Login().NombreAplica(i);


                //var lista = list1.Contains(list2).ToString();
                //MessageBox.Show(" " + lista);


                //Esta Parte es funcional
                //foreach (string nameDDI in list2)
                //{


                //    MenuItem = new System.Windows.Forms.ToolStripMenuItem();
                //    MenuItem.Text = nameDDI;
                //    MenuItem.Tag = nameDDI;
                //    MenuItem.Name = nameDDI;
                //    dropDownButton1.DropDownItems.Add(MenuItem);

                //}

                    dropDownButton1.Click += new EventHandler(Pruebas);
                //dropDownButton1.DropDownItems.Add(nameDDI);



                toolStrip1.Items.Add(dropDownButton1);
                Controls.Add(toolStrip1);
            }

            //CargarAppDispo();
        }

        public void Pruebas(object sender, EventArgs ea)
        {

            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            //MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripDropDownButton dropDownButton1 = sender as ToolStripDropDownButton;
            dropDownButton1.DropDownItems.Clear();
            //ToolStripMenuItem MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            List<string> NameAppUsu = new N_Login().NombreAppUsuario(E_Login.IdUser);
            //dropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            List<string> NomAppli = new N_Login().NombreAplica(Convert.ToInt32(dropDownButton1.Tag));
            int tot = NomAppli.Count;
            int tot1 = NameAppUsu.Count;
            //MessageBox.Show(" " + tot);
            //MessageBox.Show(Convert.ToString(MenuItem.Tag));
            list1 = NomAppli.Except(NameAppUsu).ToList();
            //int tot = 0;
            //int j = 0;


            foreach (string nA in NomAppli)
            {


                MenuItem = new System.Windows.Forms.ToolStripMenuItem();
                MenuItem.Text = nA;
                MenuItem.Enabled = false;
                
                foreach (string List in NameAppUsu)
                {


                    if (List == nA)
                    {



                        //MenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        //MenuItem.Text = List;
                        MenuItem.Enabled = true;



                    }
                    else
                    {

                        //MenuItem = new System.Windows.Forms.ToolStripMenuItem();
                        //MenuItem.Text = List;
                        //MenuItem.Enabled = false;

                    }
                    dropDownButton1.DropDownItems.Add(MenuItem);
                }


                //tot = NomAppli.Count;
            }







           




        }
 

        public void CargarAppDispo()
        {
            int k = 1;
            foreach (string nameApps in new N_Login().NombreAppUsuario(E_Login.IdUser))
            {
                if (k == 1)
                {
                    int TotModul = new N_Login().ContarModulos();
                    toolStrip1 = new System.Windows.Forms.ToolStrip();
                    for (int i = 1; i <= TotModul; i++)
                    {
                        string nameddB = new N_Login().NombreModulos(i);
                        dropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
                        dropDownButton1.Text = nameddB;
                        int TotAppli = new N_Login().ContarAplicaciones(i);



                        //int tot = nameApps.Count;


                        //string NameApp = new N_Rol().NombreAplica(i);

                        foreach (string nameDDI in new N_Login().NombreAplica(i))
                        {


                            MenuItem = new System.Windows.Forms.ToolStripMenuItem();
                            MenuItem.Text = nameDDI;
                            MenuItem.Tag = nameDDI;
                            //MessageBox.Show("" + MenuItem.Tag);

                            if (MenuItem.Text == nameApps)
                            {
                                MenuItem.Enabled = true;
                            }
                            else
                            {
                                MenuItem.Enabled = false;
                            }
                            dropDownButton1.DropDownItems.Add(MenuItem);
                        }
                        //dropDownButton1.DropDownItems.Add(nameDDI);



                        toolStrip1.Items.Add(dropDownButton1);
                        Controls.Add(toolStrip1);


                    }
                }

                k++;
            }
        }


    }
}
