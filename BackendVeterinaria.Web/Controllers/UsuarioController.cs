using AutoMapper;
using BackendVeterinaria.Core.DTO;
using BackendVeterinaria.Core.Model;
using BackendVeterinaria.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendVeterinaria.Web.Controllers
{
    public class UsuarioController : ApiController
    {
        private static IMapper _mapper;
        private IUsuarioService _usuarioService;
        public UsuarioController(
            IUsuarioService usuarioService
            )
        {
            _usuarioService = usuarioService;
        }

        static UsuarioController()
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<Usuario, UsuarioDTO>();
  
            });

            _mapper = config.CreateMapper();
        }

        public List<UsuarioDTO> GetUsuarios()
        {

            List<Usuario> usuarios = _usuarioService.GetUsuarios();
            return _mapper.Map<List<UsuarioDTO>>(usuarios);
        }


        public void Eliminar(string id)
        {

            _usuarioService.EliminarUsuario(id);
        }

        public UsuarioDTO GetUsuario(string id)
        {
            Usuario usuario = _usuarioService.GetUsuario(id);
            return _mapper.Map<UsuarioDTO>(usuario);
        }
    }
}