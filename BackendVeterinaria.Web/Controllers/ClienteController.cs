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
    public class ClienteController : ApiController
    {
        private static IMapper _mapper;
        private IClienteService _clienteService;
        public ClienteController(
            IClienteService clienteService
            )
        {
            _clienteService = clienteService;
        }

        static ClienteController()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Cliente, ClienteDTO>();
                x.CreateMap<Mascota, MascotaDTO>();                
            });

            _mapper = config.CreateMapper();
        }
       
        public List<ClienteDTO> GetClientes()
        {
            List<Cliente> clientes = _clienteService.GetClientes();
            return _mapper.Map<List<ClienteDTO>>(clientes);
        }
    }
}
