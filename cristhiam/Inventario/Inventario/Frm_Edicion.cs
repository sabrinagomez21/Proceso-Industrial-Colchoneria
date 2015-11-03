using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Inventario
{
    public partial class Frm_Edicion : Form
    {
        string producto;
        string cantidad;
        string NoOrden;
        string descripcion;
        string id;
        int suma;
        int cant;
        int ingresoegreso;
        int resta;
        public Frm_Edicion(string Iid, string Iproducto, string Icantidad, string Idescripcion)
        {
            InitializeComponent();
            producto = Iproducto;
            cantidad = Icantidad;
            descripcion = Idescripcion;
            id = Iid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Producto.Text = producto;
            Txt_Cantidad.Text = cantidad;
            Txt_Descripcion.Text = descripcion;
        }

        private void Btn_ingreso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea ingresar esa cantidad al producto: " + Txt_Producto.Text, "Ingresar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                suma = Convert.ToInt32(Txt_Cantidad.Text) + Convert.ToInt32(Txt_Egresoingreso.Text);
                NoOrden = Txt_Orden.Text;

                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("INSERT INTO compras (orden, cantidad) VALUES ('" + NoOrden + "','" + Txt_Egresoingreso.Text + "');", cConectar.SqlConexion);
                cConectar.sqlCmd.ExecuteNonQuery();
                cConectar.SqlConexion.Close();

                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("UPDATE inventario SET cantidad = '" + suma + "',  descripcion = '" + Txt_Descripcion.Text + "' WHERE id = " + id + ";", cConectar.SqlConexion);
                cConectar.sqlCmd.ExecuteNonQuery();
                cConectar.SqlConexion.Close();
                this.Close();

                Frm_InvPrincipal form = new Frm_InvPrincipal();
                form.MdiParent = Mdi_Form.ActiveForm;
                form.Show();
            }
            else
            {
                limpiar();
            }

        }

        private void Btn_Egreso_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea remover esa cantidad al producto: " + Txt_Producto.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            resta = Convert.ToInt32(Txt_Cantidad.Text) - Convert.ToInt32(Txt_Egresoingreso.Text);
            NoOrden = Txt_Orden.Text;

            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("INSERT INTO produccion (orden, cantidad) VALUES ('" + NoOrden + "','" + Txt_Egresoingreso.Text + "');", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();

            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("UPDATE inventario SET cantidad = '" + resta + "',  descripcion = '" + Txt_Descripcion.Text + "' WHERE id = " + id + ";", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            this.Close();

            Frm_InvPrincipal form = new Frm_InvPrincipal();
            form.MdiParent = Mdi_Form.ActiveForm;
            form.Show();
            }
            else
            {
                limpiar();
            }
        }
        public void limpiar()
        {
            Txt_Orden.Clear();
            Txt_Egresoingreso.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_InvPrincipal form = new Frm_InvPrincipal();
            form.MdiParent = Mdi_Form.ActiveForm;
            form.Show();
        }
    }
}
