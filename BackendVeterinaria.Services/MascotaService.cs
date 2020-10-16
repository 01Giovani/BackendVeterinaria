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
    public class MascotaService : IMascotaService
    {
        private IMascotaRepository _mascotaRepository;
        public MascotaService(
            IMascotaRepository mascotaRepository
            )
        {
            _mascotaRepository = mascotaRepository;
        }

        public Mascota EditarMascota(Mascota mascota)
        {
            return _mascotaRepository.EditarMascota(mascota);
        }

        public void EliminarMascota(Guid id)
        {
            _mascotaRepository.EliminarMascota(id);
        }

        public Mascota GetMascota(Guid id)
        {
            return _mascotaRepository.GetMascota(id);
        }

        public List<Mascota> GetMascotas()
        {
            return _mascotaRepository.GetMascotas();
        }

        public Mascota GuardarNuevaMascota(Mascota mascota)
        {
            return _mascotaRepository.GuardarNuevaMascota(mascota);
        }
    }
}
