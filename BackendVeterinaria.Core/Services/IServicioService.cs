using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Services
{
    public interface IServicioService
    {
        List<Servicio> GetServicios();
        Servicio GetServicio(Guid id);
        void EliminarServicio(Guid id);
        Servicio GuardarNuevoServicio(Servicio servicio);
        Servicio EditarServicio(Servicio servicio);
    }
}
