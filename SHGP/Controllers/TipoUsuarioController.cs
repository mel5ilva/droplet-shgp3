using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase

    {
        private readonly ITipoUsuarioRepository _TipoUsuarioRepository;

        public TipoUsuarioController(ITipoUsuarioRepository TipoUsuarioRepository)
        {
            _TipoUsuarioRepository = TipoUsuarioRepository;
        }

        // GET: api/TipoUsuario
        [HttpGet]
        public ActionResult<IEnumerable<TipoUsuario>> GetTipoUsuario()
        {
            var TipoUsuario = _TipoUsuarioRepository.GetTipoUsuario();
            if (TipoUsuario == null)
            {
                return NotFound();
            }
            return Ok(TipoUsuario);
        }


        // GET: api/TipoUsuario/id/{id}
        [HttpGet("{id}")]
        public ActionResult<TipoUsuario> GetTipoUsuario(int id)
        {
            var TipoUsuario = _TipoUsuarioRepository.GetTipoUsuarioById(id);
            if (TipoUsuario == null)
            {
                return NotFound();
            }
            return Ok(TipoUsuario);
        }

        // POST: api/TipoUsuario
        [HttpPost]
        public ActionResult CreateTipoUsuario(TipoUsuario TipoUsuario)
        {
            _TipoUsuarioRepository.CreateTipoUsuario(TipoUsuario);
            return Ok();
        }

        // PUT: api/TipoUsuario/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateTipoUsuario(TipoUsuario TipoUsuario)
        {

            var existingTipoUsuario = _TipoUsuarioRepository.GetTipoUsuarioById(TipoUsuario.ID_tipo_usuario);
            if (existingTipoUsuario == null)
            {
                return NotFound();
            }

            _TipoUsuarioRepository.UpdateTipoUsuario(TipoUsuario);

            return NoContent();
        }

        // DELETE: api/TipoUsuario/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTipoUsuario(int id)
        {
            var existingTipoUsuario = _TipoUsuarioRepository.GetTipoUsuarioById(id);
            if (existingTipoUsuario == null)
            {
                return NotFound();
            }

            _TipoUsuarioRepository.DeleteTipoUsuario(id);

            return NoContent();
        }
    }

}
