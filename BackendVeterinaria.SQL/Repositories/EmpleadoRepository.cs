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
    public class EmpleadoRepository: IEmpleadoRepository
    {
        private VeterinariaContext _db;
        public EmpleadoRepository(VeterinariaContext db)
        {
            _db = db;
        }

        public List<Empleado> GetMedicos()
        {
            return _db.Empleados.Include(x => x.Usuario).ToList();
        }
    }
}
