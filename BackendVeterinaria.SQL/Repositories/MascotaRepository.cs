using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BackendVeterinaria.SQL.Repositories
{
    public class MascotaRepository : IMascotaRepository
    {
        //constructor
        private VeterinariaContext _db;
        public MascotaRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Mascota> GetMascotas()
        {
            return _db.Mascotas.Include(x=>x.Cliente).AsNoTracking().ToList();
        }

        public Mascota GetMascota(Guid id)
        {
            return _db.Mascotas.AsNoTracking().FirstOrDefault(x => x.Codigo == id);
        }

        public void EliminarMascota(Guid id)
        {            
            Mascota mascota = _db.Mascotas.FirstOrDefault(x => x.Codigo == id);
            if (mascota != null)
            {

                _db.Mascotas.Remove(mascota);
                _db.SaveChanges();
            }
        }

        public Mascota GuardarNuevaMascota(Mascota mascota)
        {            
            _db.Mascotas.Add(mascota);
            _db.SaveChanges();

            return mascota;
        }

        public Mascota EditarMascota(Mascota mascota)
        {
            
            Mascota mascotaRemoto = _db.Mascotas.FirstOrDefault(x => x.Codigo == mascota.Codigo);
            if (mascotaRemoto != null)
            {
                mascotaRemoto.Nombre = mascota.Nombre;
                mascotaRemoto.Especie = mascota.Especie;
                mascotaRemoto.Raza = mascota.Raza;
                mascotaRemoto.Color = mascota.Color;
                mascotaRemoto.Tamaño = mascota.Tamaño;
                mascotaRemoto.IdCliente = mascota.IdCliente;
                _db.SaveChanges();
            }

            return mascotaRemoto;
        }

        public List<Mascota> GetMascotasCliente(Guid idCliente)
        {
            return _db.Mascotas.Where(x => x.IdCliente == idCliente).ToList();
        }
    }
}
