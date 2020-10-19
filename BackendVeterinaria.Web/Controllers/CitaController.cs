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
    public class CitaController : ApiController
    {
        private static IMapper _mapper;
        private ICitaService _citaService;
        public CitaController(
            ICitaService citaService
            )
        {
            _citaService = citaService;
        }


        static CitaController()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Cliente, ClienteDTO>().ReverseMap();
                x.CreateMap<Cita, CitaDTO>().ReverseMap();
            });

            _mapper = config.CreateMapper();
        }

        [Route("Api/Cita/GetCitas")]
        public List<CitaDTO> GetCitas()
        {

            List<Cita> citas = _citaService.GetCitas();
            return _mapper.Map<List<CitaDTO>>(citas);
        }

        [Route("Api/Cita/Eliminar")]
        public void Eliminar(Guid id)
        {

            _citaService.EliminarCita(id);
        }

        [Route("Api/Cita/GetCita")]
        public CitaDTO GetCita(Guid id)
        {
            Cita cita = _citaService.GetCita(id);
            return _mapper.Map<CitaDTO>(cita);
        }

        [Route("Api/Cita/GuardarCita")]
        [HttpPost]
        public CitaDTO GuardarCita(CitaDTO cita)
        {
            cita.Codigo = Guid.NewGuid();
            Cita objCita = _mapper.Map<Cita>(cita);
            
            return _mapper.Map<CitaDTO>(_citaService.GuardarNuevaCita(objCita));            
        }
    }
}
