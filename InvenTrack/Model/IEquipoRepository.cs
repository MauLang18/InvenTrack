using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public interface IEquipoRepository
    {
        bool Add(EquipoModel equipoModel);
        bool Edit(EquipoModel equipoModel);
        bool Remove(EquipoModel equipoModel);
        List<EquipoModel> GetByAll(EquipoModel equipoModel);
        List<EquipoModel> GetByDatos(EquipoModel equipoModel);
    }
}
