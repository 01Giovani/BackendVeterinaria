using BackendVeterinaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendVeterinaria.Core.DTO
{
    public class MascotaDTO
    {
        public Guid Codigo { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }
        public Guid IdCliente { get; set; }
        public string Cliente { get; set; }
    }
}
