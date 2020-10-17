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
    public class FacturaService : IFacturaService
    {
        private IFacturaRepository _facturaRepository;
        public FacturaService(
            IFacturaRepository facturaRepository
            )
        {
            _facturaRepository = facturaRepository;
        }

        public Factura EditarFactura(Factura factura)
        {
            return _facturaRepository.EditarFactura(factura);
        }

        public void EliminarFactura(Guid id)
        {
            _facturaRepository.EliminarFactura(id);
        }

        public Factura GetFactura(Guid id)
        {
            return _facturaRepository.GetFactura(id);
        }

        public List<Factura> GetFacturas()
        {
            return _facturaRepository.GetFacturas();
        }

        public Factura GuardarNuevaFactura(Factura factura)
        {
            return _facturaRepository.GuardarNuevaFactura(factura);
        }
    }
}