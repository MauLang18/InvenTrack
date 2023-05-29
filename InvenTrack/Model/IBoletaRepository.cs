using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public interface IBoletaRepository
    {
        bool Add(BoletaModel boletaModel);
        bool Edit(BoletaModel boletaModel);
        bool Remove(BoletaModel boletaModel);
        List<BoletaModel> GetByAll(BoletaModel boletaModel);
        BoletaModel GetById(BoletaModel boletaModel);
        BoletaModel GetById2(BoletaModel boletaModel);
        List<BoletaModel> GetByDatos(BoletaModel boletaModel);
    }
}
