using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public class BoletaModel : BaseModel
    {
        public int PK_TBL_INVE_BOLETA { get; set; }
        public string UBICACION { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string ASIGNADO { get; set; }
        public DateTime FECHA { get; set; }
        public string ENTREGADO_POR { get;set; }
        public string RECIBIDO_POR { get; set; }
        public string DETALLE_MOVIMIENTO { get; set; }
        public string DATOS { get; set; }
    }
}
