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
    public class FacturaController : ApiController
    {
        private static IMapper _mapper;
        private IFacturaService _facturaService;
        public FacturaController(
            IFacturaService facturaService
            )
        {
            _facturaService = facturaService;
        }

        static FacturaController()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Cliente, ClienteDTO>();
                x.CreateMap<Factura, FacturaDTO>();
            });

            _mapper = config.CreateMapper();
        }

        public List<FacturaDTO> GetFacturas()
        {

            List<Factura> facturas = _facturaService.GetFacturas();
            return _mapper.Map<List<FacturaDTO>>(facturas);
        }


        public void Eliminar(Guid id)
        {

            _facturaService.EliminarFactura(id);
        }

        public FacturaDTO GetFactura(Guid id)
        {
            Factura factura = _facturaService.GetFactura(id);
            return _mapper.Map<FacturaDTO>(factura);
        }
    }
}
