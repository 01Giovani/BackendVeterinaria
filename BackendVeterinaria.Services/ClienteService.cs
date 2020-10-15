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
        public List<Cliente> GetClientes()
        {
            return _clienteRepository.GetClientes();
        }
    }
}
