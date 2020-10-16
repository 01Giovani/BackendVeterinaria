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
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;
        public ClienteService(
            IClienteRepository clienteRepository
            )
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente EditarCliente(Cliente cliente)
        {
            return _clienteRepository.EditarCliente(cliente);
        }

        public void EliminarCliente(Guid id)
        {
            _clienteRepository.EliminarCliente(id);
        }

        public Cliente GetCliente(Guid id)
        {
            return _clienteRepository.GetCliente(id);
        }

        public List<Cliente> GetClientes()
        {
            return _clienteRepository.GetClientes();
        }

        public Cliente GuardarNuevoCliente(Cliente cliente)
        {
            return _clienteRepository.GuardarNuevoCliente(cliente);
        }
    }
}
