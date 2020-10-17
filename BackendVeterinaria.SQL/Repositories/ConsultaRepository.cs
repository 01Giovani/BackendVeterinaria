using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.SQL.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {

        //constructor
        private VeterinariaContext _db;
        public ConsultaRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Consulta> GetConsulta()
        {
            return _db.Consultas.AsNoTracking().ToList();
        }

        public Consulta GetConsulta(Guid id)
        {
            return _db.Consultas.AsNoTracking().FirstOrDefault(result => result.Codigo == id);
        }

        public void EliminarConsulta(Guid id)
        {
            Consulta consulta = _db.Consultas.FirstOrDefault(x => x.Codigo == id);
            if (consulta != null)
            {

                _db.Consultas.Remove(consulta);
                _db.SaveChanges();
            }
        }


        public Consulta GuardarNuevoConsulta(Consulta consulta)
        {
            _db.Consultas.Add(consulta);
            _db.SaveChanges();

            return consulta;
        }

        public Consulta EditarConsulta(Consulta consulta)
        {

            Consulta consultaRemoto = _db.Consultas.FirstOrDefault(x => x.Codigo == consulta.Codigo);
            if (consultaRemoto != null)
            {
                consultaRemoto.Fecha = consulta.Fecha;
                consultaRemoto.IdMascota = consulta.IdMascota;
                consultaRemoto.IdMedico = consulta.IdMedico;
                consultaRemoto.Dictamen = consulta.Dictamen;
                consultaRemoto.IdCita = consulta.IdCita;

                _db.SaveChanges();
            }

            return consultaRemoto;
        }

    }
}

