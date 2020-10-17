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

        [Route("Api/Cliente/GetClientes")]
        public List<ClienteDTO> GetClientes()
        {

            List<Cliente> clientes = _clienteService.GetClientes();
            return _mapper.Map<List<ClienteDTO>>(clientes);
        }

        [Route("Api/Cliente/Eliminar")]
        public void Eliminar(Guid id) {

            _clienteService.EliminarCliente(id);
        }

        [Route("Api/Cliente/GetCliente")]
        public ClienteDTO GetCliente(Guid id)
        {
            Cliente cliente = _clienteService.GetCliente(id);
            return _mapper.Map<ClienteDTO>(cliente);
        }

        [Route("Api/Cliente/Guardar")]
        [HttpPost]
        public ClienteDTO GuardarCliente(ClienteDTO cliente)
        {
            cliente.Codigo = Guid.NewGuid();
            Cliente objCliente = _mapper.Map<Cliente>(cliente);
            
            return _mapper.Map<ClienteDTO>(_clienteService.GuardarNuevoCliente(objCliente));
        }
    }
}
