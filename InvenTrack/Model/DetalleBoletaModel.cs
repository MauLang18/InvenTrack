using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public class DetalleBoletaModel : BaseModel
    {
        public int PK_TBL_INVE_DETALLE_BOLETA { get; set; }
        public int FK_TBL_INVE_BOLETA { get; set; }
        public int FK_TBL_INVE_EQUIPO { get; set; }

        public string ID_SISTEMA { get; set; }
        public string TIPO_EQUIPO { get; set; }
        public string MARCA { get; set; }
        public string SERIE { get; set; }
        public string MODELO { get; set; }
        public string DETALLES { get; set; }
    }
}
