using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.Repositories
{
    public interface IRolRepository
    {
        List<Rol> GetRol();
        Rol GetRol(String id);
        void EliminarRol(String id);
        Rol GuardarNuevoRol(Rol rol);
        Rol EditarRol(Rol rol);



    }
}
