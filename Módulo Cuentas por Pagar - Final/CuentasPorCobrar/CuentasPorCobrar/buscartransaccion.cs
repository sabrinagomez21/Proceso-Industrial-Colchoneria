using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;

namespace Navegador
{
    public partial class buscartransaccion : Form
    {
        public buscartransaccion()
        {
            InitializeComponent();
        }

        private void buscartransaccion_Load(object sender, EventArgs e)
        {
            string tabla = "matipotransaccion";
            string basedatos = "COLCHONERIA";
        
            funllenarCombo(tabla, basedatos, comboBox2);

        }

        private void funllenarCombo(string tabla, string basedatos, ComboBox cb)
        {
            clasnegocio cnegocio = new clasnegocio();
            String query = "SHOW COLUMNS FROM " + tabla + " FROM " + basedatos + ";";
            cnegocio.funconsultarRegistrosCombo("Field", query, "Field", cb);
        }

        public int opcion;

        private void rbmayor_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            opcion = 1;
        }

        private void rbmenor_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            opcion = 2;
        }

        private void rbigual_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            opcion = 3;
        }

        private void rbentre_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            opcion = 4;
        }

        string condicion;
        string squerybuscar;
        String ssigno;
        public void sfuncrearBusqueda(String tabla, String basedatos, String camposvisualizar)
        {

            clasnegocio cnegocio = new clasnegocio();
            if (opcion == 1) { ssigno = ">"; condicion = comboBox2.Text + ssigno + "'" + textBox1.Text + "'"; }
            if (opcion == 2) { ssigno = "<"; condicion = comboBox2.Text + ssigno + "'" + textBox1.Text + "'"; }
            if (opcion == 3) { ssigno = "="; condicion = comboBox2.Text + ssigno + "'" + textBox1.Text + "'"; }
            if (opcion == 4) { condicion = comboBox2.Text + " BETWEEN " + "'" + textBox1.Text + "'" + " AND " + "'" + textBox2.Text + "'"; }

            squerybuscar = "SELECT " + camposvisualizar + " FROM " + tabla + " WHERE " + condicion + "";
            //MessageBox.Show(squerybuscar);
            cnegocio.funconsultarRegistros(tabla, squerybuscar, "consulta", griddatosBusqueda);
            // cnegocio.funconsultarRegistros("clientes", "SELECT * from cliente", "consulta", griddatosBusqueda);
          }

        private void button1_Click(object sender, EventArgs e)
        {
            sfuncrearBusqueda("matipotransaccion", "colchoneria", "ncodtipotransaccion , vbincdec , vnombredocumento, vestado ");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}

