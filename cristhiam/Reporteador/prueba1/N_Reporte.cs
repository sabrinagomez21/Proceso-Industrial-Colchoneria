using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1{
    #region Class N_Reporte
    class N_Reporte
    {
    #endregion

        //Autor: Dennys Choy
        //Fecha: 29/10/15
        #region GetAll Toma todos los valores para grid
        public System.Data.DataTable GetAll()
        {
            return D_Reporte.ObtenerRegistros();
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Inserta Reporte
        public void Insert_Reporte(E_Reporte pReporte)
        {
            if (MessageBox.Show("Esta Seguro que desea Agregar el Reporte", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                if (string.IsNullOrWhiteSpace(pReporte.vnomreporte) || string.IsNullOrWhiteSpace(pReporte.dfechareporte))
                {MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }else{
                    int resultado = D_Reporte.Inserta(pReporte);
                    if (resultado > 0){
                        MessageBox.Show("Reporte Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else{MessageBox.Show("No se pudo guardar el Reporte", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }}}else{MessageBox.Show("Reporte Cancelado", "Reporte");}
        }
        #endregion

        //Autor: Cristhiam Duarte
        //Fecha: 29/10/15
        #region Elimina Reporte
        public void Delete_Reporte(E_Reporte pReporte)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Reporte Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {if (D_Reporte.Eliminar(pReporte.vnomreporte) > 0){
                    MessageBox.Show("Reporte Eliminado Correctamente!", "Reporte Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else MessageBox.Show("No se pudo eliminar el Reporte", "Reporte No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

    }}
