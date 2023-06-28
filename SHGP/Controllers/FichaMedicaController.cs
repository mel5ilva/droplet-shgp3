using Microsoft.AspNetCore.Http;
using SHGP.Model;
using Microsoft.AspNetCore.Mvc;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ficha_MedicaController : ControllerBase

    {
        private readonly IFicha_MedicaRepository _Ficha_MedicaRepository;

        public Ficha_MedicaController(IFicha_MedicaRepository Ficha_MedicaRepository)
        {
            _Ficha_MedicaRepository = Ficha_MedicaRepository;
        }

        // GET: api/Ficha_Medica
        [HttpGet]
        public ActionResult<IEnumerable<Ficha_Medica>> GetFicha_Medica()
        {
            var Ficha_Medica = _Ficha_MedicaRepository.GetFicha_Medica();
            if (Ficha_Medica == null)
            {
                return NotFound();
            }
            return Ok(Ficha_Medica);
        }


        // GET: api/Ficha_Medica/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Ficha_Medica> GetFicha_Medica(int id)
        {
            var Ficha_Medica = _Ficha_MedicaRepository.GetFicha_MedicaById(id);
            if (Ficha_Medica == null)
            {
                return NotFound();
            }
            return Ok(Ficha_Medica);
        }

        // POST: api/Ficha_Medica
        [HttpPost]
        public ActionResult CreateFicha_Medica(Ficha_Medica Ficha_Medica)
        {
            _Ficha_MedicaRepository.CreateFicha_Medica(Ficha_Medica);
            return Ok();
        }

        // PUT: api/Ficha_Medica/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateFicha_Medica(Ficha_Medica Ficha_Medica)
        {

            var existingFicha_Medica = _Ficha_MedicaRepository.GetFicha_MedicaById(Ficha_Medica.ID_ficha);
            if (existingFicha_Medica == null)
            {
                return NotFound();
            }

            _Ficha_MedicaRepository.UpdateFicha_Medica(Ficha_Medica);

            return NoContent();
        }

        // DELETE: api/Ficha_Medica/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteFicha_Medica(int id)
        {
            var existingFicha_Medica = _Ficha_MedicaRepository.GetFicha_MedicaById(id);
            if (existingFicha_Medica == null)
            {
                return NotFound();
            }

            _Ficha_MedicaRepository.DeleteFicha_Medica(id);

            return NoContent();
        }
    }


}
