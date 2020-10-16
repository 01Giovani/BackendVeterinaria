using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Repositories
{
    public interface IFacturaRepository
    {

        List<Factura> GetFacturas();
        Factura GetFactura(Guid id);
        void EliminarFactura(Guid id);
        Factura GuardarNuevaFactura(Factura factura);
        Factura EditarFactura(Factura factura);




    }
}
