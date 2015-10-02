using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Errores
{
    public class cErrorN
    {
        public void insert(cError pEreor)
        {
            if ((pEreor.iIdUsuario==null) || (pEreor.sAccion==null))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = cErrorD.Agregar(pEreor);

                if (resultado > 0)
                {
                    MessageBox.Show("Ocurrio Un error y este fue Guardado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }
        public DataTable ErrorUsuario(int id)
        {
            cError pCliente = new cError();
            return cErrorD.Consultar(id);
        }
        public DataTable ErrorAdmin()
        {
            cError pCliente = new cError();
            return cErrorD.Registros();
        }
    }
}
