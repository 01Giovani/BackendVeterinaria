using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class ClienteRepository: IClienteRepository
    {

        //constructor
        private  VeterinariaContext _db;
        public ClienteRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Cliente> GetClientes()
        {            
            return _db.Clientes.AsNoTracking().ToList();
        }

        public Cliente GetCliente(Guid id)
        {
            return _db.Clientes.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarCliente(Guid id)
        {
            Cliente cliente = _db.Clientes.FirstOrDefault(x => x.Codigo == id);
            if (cliente != null) {

                _db.Clientes.Remove(cliente);
                _db.SaveChanges();            
            }
        }


        public Cliente GuardarNuevoCliente(Cliente cliente)
        {
            _db.Clientes.Add(cliente);
            _db.SaveChanges();

            return cliente;
        }

        public Cliente EditarCliente(Cliente cliente) {

            Cliente clienteRemoto = _db.Clientes.FirstOrDefault(x => x.Codigo == cliente.Codigo);
            if(clienteRemoto != null)
            {
                clienteRemoto.Nombre = cliente.Nombre;
                clienteRemoto.Apellido = cliente.Apellido;
                clienteRemoto.Direccion = cliente.Direccion;
                clienteRemoto.Telefono = cliente.Telefono;
                clienteRemoto.Email = cliente.Email;

                _db.SaveChanges();
            }

            return clienteRemoto;
        }

    }
}
