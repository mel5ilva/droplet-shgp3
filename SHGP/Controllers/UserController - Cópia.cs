using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdministradorController : ControllerBase
    {
        private readonly IAdministradorRepository _administradorRepository;

        public AdministradorController(IAdministradorRepository administradorRepository)
        {
            _administradorRepository = administradorRepository;
        }

        [HttpGet]
        public IActionResult GetAdministradores()
        {
            var administradores = _administradorRepository.GetAdministradores();
            return Ok(administradores);
        }

        [HttpGet("{id}")]
        public IActionResult GetAdministrador(int id)
        {
            var administrador = _administradorRepository.GetAdministrador(id);
            if (administrador == null)
            {
                return NotFound();
            }
            return Ok(administrador);
        }

        [HttpPost]
        public IActionResult CreateAdministrador(Administrador administrador)
        {
            var created = _administradorRepository.CreateAdministrador(administrador);
            if (created)
            {
                return CreatedAtAction(nameof(GetAdministrador), new { id = administrador.ID_administrador }, administrador);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdministrador(int id, Administrador administrador)
        {
            if (id != administrador.ID_administrador)
            {
                return BadRequest();
            }

            var existingAdministrador = _administradorRepository.GetAdministrador(id);
            if (existingAdministrador == null)
            {
                return NotFound();
            }

            var updated = _administradorRepository.UpdateAdministrador(administrador);
            if (updated)
            {
                return NoContent();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdministrador(int id)
        {
            var existingAdministrador = _administradorRepository.GetAdministrador(id);
            if (existingAdministrador == null)
            {
                return NotFound();
            }

            var deleted = _administradorRepository.DeleteAdministrador(id);
            if (deleted)
            {
                return NoContent();
            }
            return BadRequest();
        }
    }
}
