using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendVeterinaria.Core.Model;

namespace BackendVeterinaria.Core.Repositories
{


    public interface IServicioRepository
    {
        List<Servicio> GetServicio();
        Servicio GetServicio(Guid id);
        void EliminarServicio(Guid id);
        Servicio GuardarNuevoServicio(Servicio servicio);
        Servicio EditarServicio(Servicio servicio);
    }
}
