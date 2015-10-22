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
    public partial class Prueba : Form
    {
       
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            ActualizarForm();
        }

        private void ActualizarForm()
        {
            try
            {
                dgprueba.DataSource = new N_Rol().GetAll(); // tiene todos los registro del datatable
                dgprueba.Refresh();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
