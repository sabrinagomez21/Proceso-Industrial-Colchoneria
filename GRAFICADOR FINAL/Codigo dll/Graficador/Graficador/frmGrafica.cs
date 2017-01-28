using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using InsertarGraficador;

namespace Graficador
{
    public partial class frmGrafica : Form
    {
        public frmGrafica()
        {
            InitializeComponent();

        }
        public frmGrafica(e_Grafica Datos)
        {

            InitializeComponent();
            e_Grafica nuevo = new e_Grafica();

            clasInsertarTabGrafica obj = new clasInsertarTabGrafica();
            if (Datos.sGrafica.Equals("pie"))
            {
                graficoPie(Datos.sTitulo, Datos.sEjeX, Datos.sEjeY, Datos.x, Datos.y);
                obj.funInsertarGrafico(Datos.sGrafica, Datos.sTitulo, Datos.sEjeX, Datos.sEjeY, Datos.x, null, Datos.y, null);
            }
            else if (Datos.sGrafica.Equals("barras"))
            {
                graficoBarras(Datos.sTitulo, Datos.sEjeX, Datos.sEjeY, Datos.x, Datos.y);
                obj.funInsertarGrafico(Datos.sGrafica, Datos.sTitulo, Datos.sEjeX, Datos.sEjeY, Datos.x, null, Datos.y, null);
            }
            else if (Datos.sGrafica.Equals("lineal"))
            {
                graficoLineal(Datos.sTitulo, Datos.sEjeX, Datos.sEjeY, Datos.dx, Datos.y);
                obj.funInsertarGrafico(Datos.sGrafica, Datos.sTitulo, Datos.sEjeX, Datos.sEjeY, null, Datos.dx, Datos.y, null);
            }
        }



        public void graficoBarras(String stitulo, String sxTitulo, String syTitulo, string[] sBarras, double[] valores)
        {
            //Hacemos una instancia al panel del grafico en el Form
            GraphPane myPane = zgc.GraphPane;

            // Le Colocamos titulos al grafico
            myPane.Title.Text = stitulo;
            myPane.XAxis.Title.Text = sxTitulo;
            myPane.YAxis.Title.Text = syTitulo;

            // Le indicamos al eje x que manejara valores String o texto
            myPane.XAxis.Type = AxisType.Text;

            // Creamos las barras en base al arreglo de valores que reciba la funcion
            // Sus parametros son (Etiqueta opcional de las barras, valor de eje x, valor de eje y, color)
            BarItem myBar = myPane.AddBar(null, null, valores, Color.Blue);

            // Paso opcional que coloca los valores dentro de la barra
            // Sus parametros son (panelGrafico, Si se ubican en el centro, y numero de decimales)
            // "F0" = cero decimales, "F1" = un decimal, etc.
            BarItem.CreateBarLabels(myPane, true, "F0");

            // Colocamos en el eje x las etiquetas de los elementos a comparar
            myPane.XAxis.Scale.TextLabels = sBarras;

            // Dibujamos la grafica
            zgc.AxisChange();
        }

        public void graficoPie(String stitulo, String sxTitulo, String syTitulo, string[] sEtiquetas, double[] valores)
        {
            //Hacemos una instancia al panel del grafico en el Form
            GraphPane myPane = zgc.GraphPane;

            //Le Colocamos titulos al grafico
            myPane.Title.Text = stitulo;
            myPane.XAxis.Title.Text = sxTitulo;
            myPane.YAxis.Title.Text = syTitulo;

            //Agregamos los valores a las etiquetas para poder verlos en la grafica
            for (int i = 0; i < sEtiquetas.Length; i++)
                sEtiquetas[i] = sEtiquetas[i] + " " + valores[i].ToString();

            //Agregamos los slices a la grafica
            myPane.AddPieSlices(valores, sEtiquetas);

            //Paso opcional para poder poner desplegar el total de los valores	
            //Creamos una instancia del objeto CurveList que es la que almacena los   valores de la grafica
            CurveList curves = myPane.CurveList;

            //Recorremos dicha lista sumando los valores en una variable local
            double total = 0;
            for (int x = 0; x < curves.Count; x++)
                total += ((PieItem)curves[x]).Value;

            //Creamos un objeto de texto que utiliza ZedGraph y le asignamos el total
            //Los parametros son (texto, tamaño vertical, tamaño horizontal, panel que asigna zedgraph)   	
            TextObj text = new TextObj("Total: " + total.ToString(), 0.18F, 0.40F, CoordType.PaneFraction);

            //Añadimos el objeto de texto
            myPane.GraphObjList.Add(text);

            // dibujamos la grafica
            zgc.AxisChange();
        }

        public void graficoLineal(String stitulo, String sxTitulo, String syTitulo, double[] x, double[] y)
        {
            //Hacemos una instancia al panel del grafico en el Form, zgc es el   nombre del panel para este ejemplo
            GraphPane myPane = zgc.GraphPane;

            // Creamos una lista de los puntos que se colocaran en el grafico
            PointPairList listPointsOne = new PointPairList();

            // Creamos una curva la cual sera graficada correspondiendo a los          puntos de la lista
            LineItem myCurveOne;

            // Le Colocamos titulos al grafico
            myPane.Title.Text = stitulo;
            myPane.XAxis.Title.Text = sxTitulo;
            myPane.YAxis.Title.Text = syTitulo;

            // asignamos los puntos a la lista
            for (int i = 0; i < x.Length; i++)
            {
                listPointsOne.Add(x[i], y[i]);
            }

            // le asignamos a la curva los puntos a graficar
            myCurveOne = myPane.AddCurve(null, listPointsOne, Color.Black, SymbolType.Circle);

            // dibujamos la grafica
            zgc.AxisChange();
        }

        private void frmGrafica_Load(object sender, EventArgs e)
        {

        }

        private void zgc_Load(object sender, EventArgs e)
        {

        }


    }
}
