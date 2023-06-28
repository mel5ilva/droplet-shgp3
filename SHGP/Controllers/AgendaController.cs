using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase

    {
        private readonly IAgendaRepository _AgendaRepository;

        public AgendaController(IAgendaRepository AgendaRepository)
        {
            _AgendaRepository = AgendaRepository;
        }

        // GET: api/Agenda
        [HttpGet]
        public ActionResult<IEnumerable<Agenda>> GetAgendas()
        {
            var Agendas = _AgendaRepository.GetAgendas();
            if (Agendas == null)
            {
                return NotFound();
            }
            return Ok(Agendas);
        }


        // GET: api/Agenda/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Agenda> GetAgenda(int id)
        {
            var Agenda = _AgendaRepository.GetAgendaById(id);
            if (Agenda == null)
            {
                return NotFound();
            }
            return Ok(Agenda);
        }

        // POST: api/Agenda
        [HttpPost]
        public ActionResult CreateAgenda(Agenda Agenda)
        {
            _AgendaRepository.CreateAgenda(Agenda);
            return Ok();
        }

        // PUT: api/Agenda/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateAgenda(Agenda Agenda)
        {

            var existingAgenda = _AgendaRepository.GetAgendaById(Agenda.ID_agenda);
            if (existingAgenda == null)
            {
                return NotFound();
            }

            _AgendaRepository.UpdateAgenda(Agenda);

            return NoContent();
        }

        // DELETE: api/Agenda/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteAgenda(int id)
        {
            var existingAgenda = _AgendaRepository.GetAgendaById(id);
            if (existingAgenda == null)
            {
                return NotFound();
            }

            _AgendaRepository.DeleteAgenda(id);

            return NoContent();
        }
    }

}
