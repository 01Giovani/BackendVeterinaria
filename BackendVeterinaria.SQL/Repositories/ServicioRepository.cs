using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class ServicioRepository : IServicioRepository
    {

        //constructor
        private VeterinariaContext _db;
        public ServicioRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Servicio> GetServicios()
        {
            return _db.Servicios.AsNoTracking().ToList();
        }

        public Servicio GetServicio(Guid id)
        {
            return _db.Servicios.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarServicio(Guid id)
        {
            Servicio servicio = _db.Servicios.FirstOrDefault(x => x.Codigo == id);
            if (servicio != null)
            {

                _db.Servicios.Remove(servicio);
                _db.SaveChanges();
            }
        }


        public Servicio GuardarNuevoServicio(Servicio servicio)
        {
            _db.Servicios.Add(servicio);
            _db.SaveChanges();

            return servicio;
        }

        public Servicio EditarServicio(Servicio servicio)
        {

            Servicio servicioRemoto = _db.Servicios.FirstOrDefault(x => x.Codigo == servicio.Codigo);
            if (servicioRemoto != null)
            {
                servicioRemoto.Nombre = servicio.Nombre;
                servicioRemoto.Descripcion = servicio.Descripcion;
                servicioRemoto.TipoServicio = servicio.TipoServicio;
                servicioRemoto.Periocidad = servicio.Periocidad;
                servicioRemoto.Activo = servicio.Activo;
                servicioRemoto.Precio = servicio.Precio;

                _db.SaveChanges();
            }

            return servicioRemoto;
        }

    }
}
