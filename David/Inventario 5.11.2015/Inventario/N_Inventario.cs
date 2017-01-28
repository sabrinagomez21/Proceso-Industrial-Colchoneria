using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario{
    #region Class N_Inventario
    class N_Inventario
    {
    #endregion

        //Autor: David Barrios
        //Fecha: 31/10/15
        #region GetAll Toma todos los valores para grid Frm_InvPrincipal
        public System.Data.DataTable GetAll()
        {
            return D_Inventario.ObtenerRegistros();
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 30/10/15
        #region GetAll Toma todos los valores para grid Materia Prima
        public System.Data.DataTable GetMateria()
        {
            return D_Inventario.ObtenerMateria();
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Inserta Datos de Frm_Edicion 
        public void Insert_Inventario(E_Inventario pInventario)
        {

                if (string.IsNullOrWhiteSpace(pInventario.DI_orden) || string.IsNullOrWhiteSpace(pInventario.DI_cantidad) || string.IsNullOrWhiteSpace(pInventario.DI_tipo))
                {
                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int resultado = D_Inventario.Inserta(pInventario);
                }
        }
        #endregion

        //Autor: Ricardo Von-Raynts
        //Fecha: 29/10/15
        #region Inserta Datos de Frm_MateriaPrima
        public void Insert_Materia(E_Inventario pInventario)
        {
            if (MessageBox.Show("Esta Seguro que desea ingresar el producto", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            if (string.IsNullOrWhiteSpace(pInventario.producto) || string.IsNullOrWhiteSpace(pInventario.cantidad) || string.IsNullOrWhiteSpace(pInventario.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int resultado = D_Inventario.InsertaMateria(pInventario);
                if (resultado > 0)
                {
                    MessageBox.Show("Producto Ingresado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo Realizar la Operacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            }
            else { MessageBox.Show("Operacion Cancelada", "Inventarios"); }
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Actualiza Datos del Frm_Edicion
        public void Actualiza_Inventario(E_Inventario pActualiza)
        {
            if (MessageBox.Show("Esta Seguro que desea Realizar la operacion", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(pActualiza.cantidad) || string.IsNullOrWhiteSpace(pActualiza.descripcion))
                {
                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int resultado = D_Inventario.Actualiza(pActualiza);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Operacion Realizada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Realizar la Operacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else { MessageBox.Show("Operacion Cancelada", "Inventarios"); }
        }
        #endregion


    }
}
