using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BackendVeterinaria.SQL.Repositories
{
    public class AccionRepository: IAccionRepository
    {

        private VeterinariaContext _db;
        public AccionRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Accion> GetAcciones()
        {
            return _db.Acciones.AsNoTracking().ToList();
        }

        public Accion GetAccion(String id)
        {
            return _db.Acciones.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarAccion(String id)
        {
            Accion accion = _db.Acciones.FirstOrDefault(x => x.Codigo == id);
            if (accion != null)
            {

                _db.Acciones.Remove(accion);
                _db.SaveChanges();
            }
        }

        public Accion GuardarNuevaAccion(Accion accion)
        {
            _db.Acciones.Add(accion);
            _db.SaveChanges();

            return accion;
        }

        public Accion EditarAccion(Accion accion)
        {

            Accion accionRemota = _db.Acciones.FirstOrDefault(x => x.Codigo == accion.Codigo);
            if (accionRemota != null)
            {
                accionRemota.Nombre = accion.Nombre;
    
             

                _db.SaveChanges();
            }

            return accionRemota;
        }
    }
}
