using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase

    {
        private readonly IAgendamentoRepository _AgendamentoRepository;

        public AgendamentoController(IAgendamentoRepository AgendamentoRepository)
        {
            _AgendamentoRepository = AgendamentoRepository;
        }

        // GET: api/Agendamento
        [HttpGet]
        public ActionResult<IEnumerable<Agendamento>> GetAgendamentos()
        {
            var Agendamentos = _AgendamentoRepository.GetAgendamentos();
            if (Agendamentos == null)
            {
                return NotFound();
            }
            return Ok(Agendamentos);
        }


        // GET: api/Agendamento/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Agendamento> GetAgendamento(int id)
        {
            var Agendamento = _AgendamentoRepository.GetAgendamentoById(id);
            if (Agendamento == null)
            {
                return NotFound();
            }
            return Ok(Agendamento);
        }
        
        // POST: api/Agendamento
        [HttpPost]
        public ActionResult CreateAgendamento(Agendamento Agendamento)
        {
            _AgendamentoRepository.CreateAgendamento(Agendamento);
            return Ok();
        }

        // PUT: api/Agendamento/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateAgendamento( Agendamento Agendamento)
        {
          
            var existingAgendamento = _AgendamentoRepository.GetAgendamentoById(Agendamento.ID_agendamento);
            if (existingAgendamento == null)
            {
                return NotFound();
            }

            _AgendamentoRepository.UpdateAgendamento( Agendamento);

            return NoContent();
        }

        // DELETE: api/Agendamento/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteAgendamento(int id)
        {
            var existingAgendamento = _AgendamentoRepository.GetAgendamentoById(id);
            if (existingAgendamento == null)
            {
                return NotFound();
            }

            _AgendamentoRepository.DeleteAgendamento(id);

            return NoContent();
        }
    }

}
