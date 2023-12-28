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

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("obterUsuarios")]
        public ActionResult<IEnumerable<Usuario>> FindAll() {
            try
            {
                var listUsuarios = _usuarioService.FindAll();

                if(!listUsuarios.Any())
                {
                    return NotFound();
                }

                return Ok(listUsuarios);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao retornar usuários!");
            }
        }

        [HttpPost]
        [Route("criarUsuario")]
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
        [Route("atualizarUsuario")]
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
