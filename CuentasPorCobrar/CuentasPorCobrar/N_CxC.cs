using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasPorCobrar
{
    class N_CxC: D_CxC
    {
        public void fInsertarTipoTransaccion(E_CxC cxc)
        {
            if (string.IsNullOrWhiteSpace(cxc.sNombreTransaccion.ToString()) || string.IsNullOrWhiteSpace(cxc.sOperacionTransaccion.ToString()) )
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = D_CxC.Insertar(cxc);

                if (resultado > 0)
                {
                    MessageBox.Show("Transaccion insertada con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        /*
        public void Update_Cliente(E_CxC cxc)
        {
            if (string.IsNullOrWhiteSpace(cxc.iNoCliente.ToString()) || string.IsNullOrWhiteSpace(cxc.iNoDocto.ToString()) || string.IsNullOrWhiteSpace(cxc.sFrecha)
                || string.IsNullOrWhiteSpace(cxc.sTransaccion) || string.IsNullOrWhiteSpace(cxc.iValor.ToString()))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (D_CxC.Actualizar(cxc) > 0)
                {
                    MessageBox.Show("Se actualizo la transaccion", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la transaccion", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public void Delete_Cliente(E_CxC pCliente)
        {
            if (MessageBox.Show("Esta Seguro que desea eliminar el Cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (D_Cliente.Eliminar(pCliente.Id) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo eliminar el Cliente", "Cliente No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public E_Cliente GetSingle_Cliente(int id)
        {
            E_Cliente pCliente = new E_Cliente();
            pCliente.Id = id;
            return D_Cliente.Consultar(pCliente);
        }

        public System.Data.DataTable GetAll()
        {
            return D_Cliente.ObtenerRegistros();
        } */
    }
}
