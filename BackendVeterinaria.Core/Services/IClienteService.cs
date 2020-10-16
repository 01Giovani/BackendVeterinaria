using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Services
{
    public interface IClienteService
    {
        List<Cliente> GetClientes();
        Cliente GetCliente(Guid id);
        void EliminarCliente(Guid id);
        Cliente GuardarNuevoCliente(Cliente cliente);
        Cliente EditarCliente(Cliente cliente);
    }
}
