using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BackendVeterinaria.Core.Repositories
{
    public interface IAccionRepository
    {

        List<Accion> GetAcciones();
        Accion GetAccion(String id);
        void EliminarAccion(String id);
        Accion GuardarNuevaAccion(Accion accion);
        Accion EditarAccion(Accion accion);




    }
}
