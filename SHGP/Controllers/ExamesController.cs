using Microsoft.AspNetCore.Http;
using SHGP.Model;
using Microsoft.AspNetCore.Mvc;

namespace SHGP.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ExamesController : ControllerBase

    {
        private readonly IExamesRepository _ExamesRepository;

        public ExamesController(IExamesRepository ExamesRepository)
        {
            _ExamesRepository = ExamesRepository;
        }

        // GET: api/Exames
        [HttpGet]
        public ActionResult<IEnumerable<Exames>> GetExames()
        {
            var Exames = _ExamesRepository.GetExames();
            if (Exames == null)
            {
                return NotFound();
            }
            return Ok(Exames);
        }


        // GET: api/Exames/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Exames> GetExames(int id)
        {
            var Exames = _ExamesRepository.GetExamesById(id);
            if (Exames == null)
            {
                return NotFound();
            }
            return Ok(Exames);
        }

        // POST: api/Exames
        [HttpPost]
        public ActionResult CreateExames(Exames Exames)
        {
            _ExamesRepository.CreateExames(Exames);
            return Ok();
        }

        // PUT: api/Exames/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateExames(Exames Exames)
        {

            var existingExames = _ExamesRepository.GetExamesById(Exames.ID_exames);
            if (existingExames == null)
            {
                return NotFound();
            }

            _ExamesRepository.UpdateExames(Exames);

            return NoContent();
        }

        // DELETE: api/Exames/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteExames(int id)
        {
            var existingExames = _ExamesRepository.GetExamesById(id);
            if (existingExames == null)
            {
                return NotFound();
            }

            _ExamesRepository.DeleteExames(id);

            return NoContent();
        }
    }




}
