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
                        cBNuevo.Checked = true;
                    }
                    else
                    {
                        cBNuevo.Checked = false;
                    }
                    
                }
                else if (i == 1)
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
                else if (i == 2)
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
                else if (i == 3)
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
                else if (i == 4)
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
                else if (i == 5)
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
                else if (i == 6)
                {
                    if (Variable == 1)
                    {
                        cBActualizar.Checked = true;
                    }
                    else
                    {
                        cBActualizar.Checked = false;
                    }
                }
                else if (i == 7)
                {
                    if (Variable == 1)
                    {
                        cBImprimir.Checked = true;
                    }
                    else
                    {
                        cBImprimir.Checked = false;
                    }
                }
                else if (i == 8)
                {
                    if (Variable == 1)
                    {
                        cBPrimReg.Checked = true;
                    }
                    else
                    {
                        cBPrimReg.Checked = false;
                    }
                }
                else if (i == 9)
                {
                    if (Variable == 1)
                    {
                        cBAntReg.Checked = true;
                    }
                    else
                    {
                        cBAntReg.Checked = false;
                    }
                }
                else if (i == 10)
                {
                    if (Variable == 1)
                    {
                        cBSigReg.Checked = true;
                    }
                    else
                    {
                        cBSigReg.Checked = false;
                    }
                }
                else if (i == 11)
                {
                    if (Variable == 1)
                    {
                        cBUltReg.Checked = true;
                    }
                    else
                    {
                        cBUltReg.Checked = false;
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
            Nego.EditaAplicaciones(sApp, sIdUser, cbNuevo(), cbInser(), cbElimina(), cbEdit(),cbBusca(), cbCancela(),cbActualizar(),
                cbImprimir(), cbPrimerRegistro(), cbAnteriorRegistro(), cbSiguienteRegistro(), cbUltimoRegistro());
            frmAsignacionAplicacion Emp = new frmAsignacionAplicacion();
            Emp.txtCodigoPerfil.Text = Convert.ToString(E_Rol.IdUser);
            Emp.txtNombrePerfil.Text = E_Rol.NameUser;
            this.Close();
            Emp.Show();
            Emp.CargarAppAsig();

        }

        private bool cbNuevo()
        {
            bool bPermisoNuevo;
            if (cBNuevo.Checked)
            {
                bPermisoNuevo = true;
            }
            else
            {
                bPermisoNuevo = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoNuevo;
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

        private bool cbActualizar()
        {
            bool bPermisoActuaizar;
            if (cBActualizar.Checked)
            {
                bPermisoActuaizar = true;
            }
            else
            {
                bPermisoActuaizar = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoActuaizar;
        }

        private bool cbImprimir()
        {
            bool bPermisoImprimir;
            if (cBImprimir.Checked)
            {
                bPermisoImprimir = true;
            }
            else
            {
                bPermisoImprimir = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoImprimir;
        }

        private bool cbPrimerRegistro()
        {
            bool bPermisoPrimReg;
            if (cBPrimReg.Checked)
            {
                bPermisoPrimReg = true;
            }
            else
            {
                bPermisoPrimReg = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoPrimReg;
        }

        private bool cbAnteriorRegistro()
        {
            bool bPermisoAntReg;
            if (cBAntReg.Checked)
            {
                bPermisoAntReg = true;
            }
            else
            {
                bPermisoAntReg = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoAntReg;
        }
        private bool cbSiguienteRegistro()
        {
            bool bPermisoSigReg;
            if (cBSigReg.Checked)
            {
                bPermisoSigReg = true;
            }
            else
            {
                bPermisoSigReg = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoSigReg;
        }

        private bool cbUltimoRegistro()
        {
            bool bPermisoUltReg;
            if (cBUltReg.Checked)
            {
                bPermisoUltReg = true;
            }
            else
            {
                bPermisoUltReg = false;
            }
            //MessageBox.Show(iPermisoInserta);
            return bPermisoUltReg;
        }

    }
}
