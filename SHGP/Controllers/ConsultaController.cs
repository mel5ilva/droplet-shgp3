using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultaController : ControllerBase
    {
        private readonly IConsultaRepository _consultaRepository;

        public ConsultaController(IConsultaRepository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        // GET: api/Consulta
        [HttpGet]
        public IActionResult GetConsultas()
        {
            var consultas = _consultaRepository.GetConsultas();
            return Ok(consultas);
        }

        // GET: api/Consulta/{id}
        [HttpGet("{id}")]
        public IActionResult GetConsultaById(int id)
        {
            var consulta = _consultaRepository.GetConsultasbyId(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return Ok(consulta);
        }

        // GET: api/Consulta/paciente/{id}
        [HttpGet("paciente/{id}")]
        public IActionResult GetConsultaPaciente(int id)
        {
            var consulta = _consultaRepository.GetConsultaPaciente(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return Ok(consulta);
        }

        // GET: api/Consulta/medico/{id}
        [HttpGet("medico/{id}")]
        public IActionResult GetConsultaMedico(int id)
        {
            var consulta = _consultaRepository.GetConsultaMedico(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return Ok(consulta);
        }

        // POST: api/Consulta
        [HttpPost]
        public IActionResult CreateConsulta(Consulta consulta)
        {
            var created = _consultaRepository.CreateConsulta(consulta);
            if (!created)
            {
                return BadRequest();
            }
            return Ok();
        }

        // PUT: api/Consulta/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateConsulta( Consulta consulta)
        {
            

            var updated = _consultaRepository.UpdateConsulta(consulta);
            if (!updated)
            {
                return NotFound();
            }
            return Ok();
        } [HttpDelete("{id}")]
        public IActionResult DeleteConsulta( int id)
        {
            

            var updated = _consultaRepository.DeleteConsulta(id);
            if (!updated)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
