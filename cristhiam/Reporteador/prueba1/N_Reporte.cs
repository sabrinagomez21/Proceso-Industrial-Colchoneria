using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    class N_Reporte
    {
        public System.Data.DataTable GetAll()
        {
            return D_Reporte.ObtenerRegistros();
        }

        public void Insert_Reporte(E_Reporte pReporte)
        {
            if (string.IsNullOrWhiteSpace(pReporte.nom_reporte) || string.IsNullOrWhiteSpace(pReporte.usuario) || string.IsNullOrWhiteSpace(pReporte.fecha_hora))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_Reporte.Inserta(pReporte);

                if (resultado > 0)
                {
                    MessageBox.Show("Reporte Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Reporte", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void Delete_Reporte(E_Reporte pReporte)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Reporte Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (D_Reporte.Eliminar(pReporte.id) > 0)
                {
                    MessageBox.Show("Reporte Eliminado Correctamente!", "Reporte Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo eliminar el Reporte", "Reporte No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
