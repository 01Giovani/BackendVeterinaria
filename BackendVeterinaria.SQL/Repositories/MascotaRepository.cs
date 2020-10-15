using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class MascotaRepository: IMascotaRepository
    {
        private VeterinariaContext _db;
        public MascotaRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public Mascota EditarMascota(Mascota mascota)
        {
            throw new NotImplementedException();
        }

        public void EliminarMascota(Guid id)
        {
            throw new NotImplementedException();
        }

        public Mascota GetMascota(Guid id)
        {
            return _db.Mascotas.AsNoTracking().FirstOrDefault(x => x.Codigo == id);
        }

        public List<Mascota> GetMascotas()
        {
            return _db.Mascotas.AsNoTracking().ToList();
        }

        public Mascota GuardarNuevaMascota(Mascota mascota)
        {
            throw new NotImplementedException();
        }
    }
}
