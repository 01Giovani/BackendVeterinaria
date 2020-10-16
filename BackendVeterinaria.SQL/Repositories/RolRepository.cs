using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class RolRepository: IRolRepository
    {

        private VeterinariaContext _db;
        public RolRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Rol> GetRoles()
        {
            return _db.Roles.AsNoTracking().ToList();
        }

        public Rol GetRol(String id)
        {
            return _db.Roles.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarRol(String id)
        {
            Rol rol = _db.Roles.FirstOrDefault(x => x.Codigo == id);
            if (rol != null)
            {

                _db.Roles.Remove(rol);
                _db.SaveChanges();
            }
        }

        public Rol GuardarNuevoRol(Rol rol)
        {
            _db.Roles.Add(rol);
            _db.SaveChanges();

            return rol;
        }


        public Rol EditarRol(Rol rol)
        {

            Rol rolRemoto = _db.Roles.FirstOrDefault(x => x.Codigo == rol.Codigo);
            if (rolRemoto != null)
            {
                rolRemoto.Descripcion = rol.Descripcion;
                
                _db.SaveChanges();
            }

            return rol;
        }




    }
}
