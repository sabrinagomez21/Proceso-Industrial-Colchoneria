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
    //Autor: Cristhiam Duarte
    //Fecha: 31/10/15
    #region inicia clase variables
    public partial class Frm_Edicion : Form
    {
        string producto;
        string cantidad;
        string NoOrden;
        string descripcion;
        int id;
        int operacion;
        string cantIE;
    #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 31/10/15
        #region Toma de Variables Frm_InvPrincipal
        public Frm_Edicion(string Iid, string Iproducto, string Icantidad, string Idescripcion)
        {
            InitializeComponent();
            producto = Iproducto;
            cantidad = Icantidad;
            descripcion = Idescripcion;
            id = Convert.ToInt32(Iid);
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 31/10/15
        #region LLenado de variables Load y Cbox
        private void Form1_Load(object sender, EventArgs e)
        {
            Cbox_tipo.Items.Add("Ingreso");
            Cbox_tipo.Items.Add("Egreso");
            Txt_Producto.Text = producto;
            Txt_Cantidad.Text = cantidad;
            Txt_Descripcion.Text = descripcion;
            
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 31/10/15
        #region Boton de Ingreso
        private void Btn_ingreso_Click(object sender, EventArgs e)
        {
            if (Txt_Egresoingreso.Text == ""){MessageBox.Show("Complete los Campos requeridos");
            }else{
                if (Cbox_tipo.Text == "Ingreso")
                {
                    operacion = Convert.ToInt32(Txt_Cantidad.Text) + Convert.ToInt32(Txt_Egresoingreso.Text);
                }else{
                    operacion = Convert.ToInt32(Txt_Cantidad.Text) - Convert.ToInt32(Txt_Egresoingreso.Text);
                }
                cantIE = Txt_Egresoingreso.Text;
                NoOrden = Txt_Orden.Text.Trim();
                E_Inventario pInserta = new E_Inventario(); //constructor llamada de variables
                pInserta.DI_orden = NoOrden;
                pInserta.producto = producto;
                pInserta.DI_cantidad = cantIE;
                pInserta.DI_tipo = Cbox_tipo.Text;
                new N_Inventario().Insert_Inventario(pInserta); //envia las variables a capa para ingreso

                E_Inventario pActualiza = new E_Inventario(); //constructor llamada de variables
                pActualiza.id = id;
                pActualiza.cantidad = Convert.ToString(operacion);
                pActualiza.descripcion = Txt_Descripcion.Text;
                new N_Inventario().Actualiza_Inventario(pActualiza); //envia las variables a capa para ingreso
            }this.Close();
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 31/10/15
        #region Cierra Form y carga anterior
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_InvPrincipal form = new Frm_InvPrincipal();
            form.MdiParent = Mdi_Form.ActiveForm;
            form.Show();
        }
        #endregion
    }
}
