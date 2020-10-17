using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
    public class UsuarioDTO
    {
        public Guid Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime UltimoLogin { get; set; }
        public string Activo { get; set; }
        public string Contraseña { get; set; }
    }
}
