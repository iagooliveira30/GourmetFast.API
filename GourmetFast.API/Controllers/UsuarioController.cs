using GourmetFast.Core.Entidades;
using GourmetFast.Core.DTO;
using Microsoft.AspNetCore.Mvc; 
using GourmetFast.Services.Services;
using GourmetFast.Services.Interfaces;

namespace GourmetFast.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly IUsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> FindAll() {
            try
            {
                var listUsuarios = _usuarioService.FindAll();

                return Ok(listUsuarios);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        [HttpPost]
        public ActionResult CreateUsuario(UsuarioDTO usuarioDTO)
        {
            try
            {
                _usuarioService.CreateUsuario(usuarioDTO);

                return Ok("Usuário cadastrado com sucesso!");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
            
        }

        [HttpPut]
        public ActionResult UpdateUsuario(Guid id, [FromBody]UsuarioDTO usuarioDTO)
        {
            if(usuarioDTO == null)
            {
                return BadRequest("Usuário não pode ser nulo!");
            }

            _usuarioService.UpdateUsuario(id, usuarioDTO);

            return Ok("Usuário :" + usuarioDTO.Name + " cadastrado com sucesso!");
        }
    }
}
