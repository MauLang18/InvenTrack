using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public class UserModel
    {
        public int PK_TBL_INVE_USUARIO { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public string NOMBRE { get; set;}
        public string APELLIDO1 { get; set; }
        public string APELLIDO2 { get; set; }
    }
}
