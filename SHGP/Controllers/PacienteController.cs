using Microsoft.AspNetCore.Http;
using SHGP.Model;
using SHGP.Repository;
using Microsoft.AspNetCore.Mvc;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase

    {
        private readonly IPacienteRepository _PacienteRepository;

        public PacienteController(IPacienteRepository PacienteRepository)
        {
            _PacienteRepository = PacienteRepository;
        }

        // GET: api/Paciente
        [HttpGet]
        public ActionResult<IEnumerable<Paciente>> GetPaciente()
        {
            var Paciente = _PacienteRepository.GetPaciente();
            if (Paciente == null)
            {
                return NotFound();
            }
            return Ok(Paciente);
        }


        // GET: api/Paciente/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Paciente> GetPaciente(int id)
        {
            var Paciente = _PacienteRepository.GetPacienteById(id);
            if (Paciente == null)
            {
                return NotFound();
            }
            return Ok(Paciente);
        }

        // POST: api/Paciente
        [HttpPost]
        public ActionResult CreatePaciente(Paciente Paciente)
        {
            _PacienteRepository.CreatePaciente(Paciente);
            return Ok();
        }

        // PUT: api/Paciente/{id}
        [HttpPut("{id}")]
        public IActionResult UpdatePaciente(Paciente Paciente)
        {

            var existingPaciente = _PacienteRepository.GetPacienteById(Paciente.ID_paciente);
            if (existingPaciente == null)
            {
                return NotFound();
            }

            _PacienteRepository.UpdatePaciente(Paciente);

            return NoContent();
        }

        // DELETE: api/Paciente/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePaciente(int id)
        {
            var existingPaciente = _PacienteRepository.GetPacienteById(id);
            if (existingPaciente == null)
            {
                return NotFound();
            }

            _PacienteRepository.DeletePaciente(id);

            return NoContent();
        }
    }


}
