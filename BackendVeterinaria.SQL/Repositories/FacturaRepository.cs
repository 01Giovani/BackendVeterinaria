using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class FacturaRepository: IFacturaRepository
    {
        private VeterinariaContext _db;

        public FacturaRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Factura> GetFacturas()
        {
            return _db.Facturas.AsNoTracking().ToList();
        }

        public Factura GetFactura(Guid id)
        {
            return _db.Facturas.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarFactura(Guid id)
        {
            Factura factura = _db.Facturas.FirstOrDefault(x => x.Codigo == id);
            if (factura != null)
            {

                _db.Facturas.Remove(factura);
                _db.SaveChanges();
            }
        }

        public Factura GuardarNuevaFactura(Factura factura)
        {
            _db.Facturas.Add(factura);
            _db.SaveChanges();

            return factura;
        }

        public Factura EditarFactura(Factura factura)
        {

            Factura facturaRemota = _db.Facturas.FirstOrDefault(x => x.Codigo == factura.Codigo);
            if (facturaRemota != null)
            {
                facturaRemota.Fecha = factura.Fecha;
                facturaRemota.Total = factura.Total;
            

                _db.SaveChanges();
            }

            return facturaRemota;
        }


    }
}
