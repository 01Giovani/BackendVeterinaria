using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using BackendVeterinaria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Services
{
    public class ServicioService : IServicioService
    {
        private IServicioRepository _servicioRepository;
        public ServicioService(
            IServicioRepository servicioRepository
            )
        {
            _servicioRepository = servicioRepository;
        }

        public Servicio EditarServicio(Servicio servicio)
        {
            return _servicioRepository.EditarServicio(servicio);
        }

        public void EliminarServicio(Guid id)
        {
            _servicioRepository.EliminarServicio(id);
        }

        public Servicio GetServicio(Guid id)
        {
            return _servicioRepository.GetServicio(id);
        }

        public List<Servicio> GetServicios()
        {
            return _servicioRepository.GetServicios();
        }

        public Servicio GuardarNuevoServicio(Servicio servicio)
        {
            return _servicioRepository.GuardarNuevoServicio(servicio);
        }
    }
}
