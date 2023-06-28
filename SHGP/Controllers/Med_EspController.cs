using Microsoft.AspNetCore.Http;
using SHGP.Model;
using Microsoft.AspNetCore.Mvc;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Med_EspController : ControllerBase

    {
        private readonly IMed_EspRepository _Med_EspRepository;

        public Med_EspController(IMed_EspRepository Med_EspRepository)
        {
            _Med_EspRepository = Med_EspRepository;
        }

        // GET: api/Med_Esp
        [HttpGet]
        public ActionResult<IEnumerable<Med_Esp>> GetMed_Esp()
        {
            var Med_Esp = _Med_EspRepository.GetMed_Esp();
            if (Med_Esp == null)
            {
                return NotFound();
            }
            return Ok(Med_Esp);
        }


        // GET: api/Med_Esp/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Med_Esp> GetMed_Esp(int id)
        {
            var Med_Esp = _Med_EspRepository.GetMed_EspById(id);
            if (Med_Esp == null)
            {
                return NotFound();
            }
            return Ok(Med_Esp);
        }

        // POST: api/Med_Esp
        [HttpPost]
        public ActionResult CreateMed_Esp(Med_Esp Med_Esp)
        {
            _Med_EspRepository.CreateMed_Esp(Med_Esp);
            return Ok();
        }

        // PUT: api/Med_Esp/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMed_Esp(Med_Esp Med_Esp)
        {

            var existingMed_Esp = _Med_EspRepository.GetMed_EspById(Med_Esp.ID_med_esp);
            if (existingMed_Esp == null)
            {
                return NotFound();
            }

            _Med_EspRepository.UpdateMed_Esp(Med_Esp);

            return NoContent();
        }

        // DELETE: api/Med_Esp/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMed_Esp(int id)
        {
            var existingMed_Esp = _Med_EspRepository.GetMed_EspById(id);
            if (existingMed_Esp == null)
            {
                return NotFound();
            }

            _Med_EspRepository.DeleteMed_Esp(id);

            return NoContent();
        }
    }

}
