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
    public class CitaService : ICitaService
    {
        private ICitaRepository _citaRepository;
        public CitaService(
            ICitaRepository citaRepository
            )
        {
            _citaRepository = citaRepository;
        }

        public Cita EditarCita(Cita cita)
        {
            return _citaRepository.EditarCita(cita);
        }

        public void EliminarCita(Guid id)
        {
            _citaRepository.EliminarCita(id);
        }

        public Cita GetCita(Guid id)
        {
            return _citaRepository.GetCita(id);
        }

        public List<Cita> GetCitas()
        {
            return _citaRepository.GetCitas();
        }

        public Cita GuardarNuevaCita(Cita cita)
        {
            return _citaRepository.GuardarNuevaCita(cita);
        }
    }
}
