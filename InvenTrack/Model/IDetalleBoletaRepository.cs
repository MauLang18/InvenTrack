using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InvenTrack.Model
{
    public interface IDetalleBoletaRepository
    {
        bool Add(DetalleBoletaModel detalleBoletaModel);
        bool Edit(DetalleBoletaModel detalleBoletaModel);
        bool Remove(DetalleBoletaModel detalleBoletaModel);
        List<DetalleBoletaModel> GetByAll(DetalleBoletaModel detalleBoletaModel);
    }
}
