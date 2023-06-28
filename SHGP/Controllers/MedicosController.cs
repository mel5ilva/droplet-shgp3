using Microsoft.AspNetCore.Http;
using SHGP.Model;
using Microsoft.AspNetCore.Mvc;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicosController : ControllerBase

    {
        private readonly IMedicosRepository _MedicosRepository;

        public MedicosController(IMedicosRepository MedicosRepository)
        {
            _MedicosRepository = MedicosRepository;
        }

        // GET: api/Medicos
        [HttpGet]
        public ActionResult<IEnumerable<Medicos>> GetMedicos()
        {
            var Medicos = _MedicosRepository.GetMedicos();
            if (Medicos == null)
            {
                return NotFound();
            }
            return Ok(Medicos);
        }


        // GET: api/Medicos/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Medicos> GetMedicos(int id)
        {
            var Medicos = _MedicosRepository.GetMedicosById(id);
            if (Medicos == null)
            {
                return NotFound();
            }
            return Ok(Medicos);
        }

        // POST: api/Medicos
        [HttpPost]
        public ActionResult CreateMedicos(Medicos Medicos)
        {
            _MedicosRepository.CreateMedicos(Medicos);
            return Ok();
        }

        // PUT: api/Medicos/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateMedicos(Medicos Medicos)
        {

            var existingMedicos = _MedicosRepository.GetMedicosById(Medicos.ID_medico);
            if (existingMedicos == null)
            {
                return NotFound();
            }

            _MedicosRepository.UpdateMedicos(Medicos);

            return NoContent();
        }

        // DELETE: api/Medicos/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteMedicos(int id)
        {
            var existingMedicos = _MedicosRepository.GetMedicosById(id);
            if (existingMedicos == null)
            {
                return NotFound();
            }

            _MedicosRepository.DeleteMedicos(id);

            return NoContent();
        }
    }

}
