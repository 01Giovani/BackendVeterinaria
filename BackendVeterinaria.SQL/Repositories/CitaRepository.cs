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
    public class CitaRepository: ICitaRepository
    {
        private VeterinariaContext _db;
        public CitaRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Cita> GetCitas()
        {
            return _db.Citas.Include(x=>x.Cliente).AsNoTracking().ToList();
        }

        public Cita GetCita(Guid id)
        {
            return _db.Citas.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarCita(Guid id)
        {
            Cita cita = _db.Citas.FirstOrDefault(x => x.Codigo == id);
            if (cita != null)
            {

                _db.Citas.Remove(cita);
                _db.SaveChanges();
            }
        }

        public Cita GuardarNuevaCita(Cita cita)
        {
            _db.Citas.Add(cita);
            _db.SaveChanges();

            return cita;
        }

        public Cita EditarCita(Cita cita)
        {

            Cita citaRemota = _db.Citas.FirstOrDefault(x => x.Codigo == cita.Codigo);
            if (citaRemota != null)
            {
                citaRemota.FechaReservada = cita.FechaReservada;
                citaRemota.FechaIngreso = cita.FechaIngreso;
                citaRemota.MotivoConsulta = cita.MotivoConsulta;
             

                _db.SaveChanges();
            }

            return citaRemota;
        }

        public List<Cita> GetCitasSinConsulta()
        {
            return _db.Citas.Include(x=>x.Cliente).Where(x => ( x.Consultas.Count == 0) || (x.Consultas.FirstOrDefault().Facturas.Count == 0)).ToList();
        }
    }
}
