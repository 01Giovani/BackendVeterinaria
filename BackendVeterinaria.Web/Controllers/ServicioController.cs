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
using System.Web.Http.Cors;

namespace BackendVeterinaria.Web.Controllers
{
    public class ServicioController : ApiController
    {
        private static IMapper _mapper;
        private IServicioService _servicioService;
        public ServicioController(
            IServicioService servicioService
            )
        {
            _servicioService = servicioService;
        }

        static ServicioController()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Servicio, ServicioDTO>().ReverseMap();
                //x.CreateMap<Consulta, ConsultaDTO>().ReverseMap();
            });

            _mapper = config.CreateMapper();
        }

        [Route("Api/Servicio/GetServicios")]
        public List<ServicioDTO> GetServicios()
        {

            List<Servicio> servicios = _servicioService.GetServicios();
            return _mapper.Map<List<ServicioDTO>>(servicios);
        }

        [Route("Api/Servicio/Eliminar")]
        public void Eliminar(Guid id)
        {

            _servicioService.EliminarServicio(id);
        }

        [Route("Api/Servicio/GetServicio")]
        public ServicioDTO GetServicio(Guid id)
        {
            Servicio servicio = _servicioService.GetServicio(id);
            return _mapper.Map<ServicioDTO>(servicio);
        }

        [Route("Api/Servicio/Guardar")]
        [HttpPost]
        public ServicioDTO GuardarServicio(ServicioDTO servicio)
        {
            servicio.Codigo = Guid.NewGuid();
            Servicio objServicio = _mapper.Map<Servicio>(servicio);

            return _mapper.Map<ServicioDTO>(_servicioService.GuardarNuevoServicio(objServicio));
        }
    }
}
