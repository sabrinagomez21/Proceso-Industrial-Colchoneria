using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prueba1
{
    class E_Reporte
    {
        #region Atributos y Encapsulamiento

        public int Id { get; set; }
        public string nom_reporte { get; set; }
        public string usuario { get; set; }
        public string fecha_hora { get; set; }

        #endregion

        #region Constructor

        public E_Reporte(int pId, string pReporte, string pUsuario, string pFecha_hora)
        {
            this.Id = pId;
            this.nom_reporte = pReporte;
            this.usuario = pUsuario;
            this.fecha_hora = pFecha_hora;
        }

        #endregion
    }
}
