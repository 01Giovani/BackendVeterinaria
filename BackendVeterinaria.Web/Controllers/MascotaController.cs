using AutoMapper;
using BackendVeterinaria.Core.DTO;
using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendVeterinaria.Web.Controllers
{
    public class MascotaController : ApiController
    {
        private static IMapper _mapper;
        private IMascotaService _mascotaService;
        public MascotaController(
            IMascotaService mascotaService
            )
        {
            _mascotaService = mascotaService;
        }

        static MascotaController()
        {
            var config = new MapperConfiguration(x =>
            {
                
                x.CreateMap<Mascota, MascotaDTO>();
            });

            _mapper = config.CreateMapper();
        }

        public List<MascotaDTO> GetMascotas()
        {

            List<Mascota> mascotas = _mascotaService.GetMascotas();
            return _mapper.Map<List<MascotaDTO>>(mascotas);
        }


        public void Eliminar(Guid id)
        {

            _mascotaService.EliminarMascota(id);
        }

        public MascotaDTO GetMascota(Guid id)
        {
            Mascota mascota = _mascotaService.GetMascota(id);
            return _mapper.Map<MascotaDTO>(mascota);
        }

    }
}
