using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoAsignacionAplicacion
{
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
            CargarLbx();
            
        }

        
        public E_Rol EmpleadoSeleccionado { get; set; }
        private void CargarLbx()
        {
            try
            {
                lbxEditaAppAsig.DisplayMember = "vnombreAplicacion";
                lbxEditaAppAsig.ValueMember = "iidAplicacion";
                lbxEditaAppAsig.DataSource = new N_Rol().AppAsig(Convert.ToString(E_Rol.IdUser)); // tiene todos los registro del datatable
                lbxEditaAppAsig.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void lbxEditaAppAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sApp = lbxEditaAppAsig.GetItemText(lbxEditaAppAsig.SelectedValue);
            string sIdUser = Convert.ToString(E_Rol.IdUser);
            N_Rol Nego = new N_Rol();
            //Nego.PermisosAsigna(sIdUser, sApp);
            //Contador para los checkbox 
            int i = 0;

            //Trae las variables de la base de datos para ponerle cheque si tiene permiso
            foreach (int Variable in Nego.PermisosAsigna(sIdUser, sApp))
            {
                if(i==0)
                {
                    if (Variable == 1)
                    {
                        cbInsertar.Checked = true;
                    }
                    else
                    {
                        cbInsertar.Checked = false;
                    }
                    
                }
                else if (i == 1)
                {
                    if (Variable == 1)
                    {
                        cbEliminar.Checked = true;
                    }
                    else
                    {
                        cbEliminar.Checked = false;
                    }


                }
                else if (i == 2)
                {
                    if (Variable == 1)
                    {
                        cBEditar.Checked = true;
                    }
                    else
                    {
                        cBEditar.Checked = false;
                    }

                }
                else if (i == 3)
                {
                    if (Variable == 1)
                    {
                        cBBuscar.Checked = true;
                    }
                    else
                    {
                        cBBuscar.Checked = false;
                    }

                }
                else if (i == 4)
                {
                    if (Variable == 1)
                    {
                        cBCancelar.Checked = true;
                    }
                    else
                    {
                        cBCancelar.Checked = false;
                    }

                }

                i++;
            }
           
            
        }

        private void btnEditaGuarda_Click(object sender, EventArgs e)
        {
            string sApp = lbxEditaAppAsig.GetItemText(lbxEditaAppAsig.SelectedValue);
            string sIdUser = Convert.ToString(E_Rol.IdUser);
            N_Rol Nego = new N_Rol();
            Nego.EditaAplicaciones(sApp, sIdUser, cbInser(), cbElimina(), cbEdit(), cbBusca(), cbCancela());
        }

        private bool cbInser()
        {
            bool bPermisoInserta;
            if (cbInsertar.Checked)
            {
                bPermisoInserta = true;
            }
            else
            {
                bPermisoInserta = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoInserta;
        }

        private bool cbElimina()
        {
            bool bPermisoElimina;
            if (cbEliminar.Checked)
            {
                bPermisoElimina = true;
            }
            else
            {
                bPermisoElimina = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoElimina;
        }

        private bool cbEdit()
        {
            bool bPermisoEdita;
            if (cBEditar.Checked)
            {
                bPermisoEdita = true;
            }
            else
            {
                bPermisoEdita = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoEdita;
        }

        private bool cbBusca()
        {
            bool bPermisoBusca;
            if (cBBuscar.Checked)
            {
                bPermisoBusca = true;
            }
            else
            {
                bPermisoBusca = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoBusca;
        }

        private bool cbCancela()
        {
            bool bPermisoCancelar;
            if (cBCancelar.Checked)
            {
                bPermisoCancelar = true;
            }
            else
            {
                bPermisoCancelar = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoCancelar;
        }
    }
}
