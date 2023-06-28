using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasMedicasController : ControllerBase

    {
        private readonly IReceitasMedicasRepository _ReceitasMedicasRepository;

        public ReceitasMedicasController(IReceitasMedicasRepository ReceitasMedicasRepository)
        {
            _ReceitasMedicasRepository = ReceitasMedicasRepository;
        }

        // GET: api/ReceitasMedicas
        [HttpGet]
        public ActionResult<IEnumerable<ReceitasMedicas>> GetReceitasMedicas()
        {
            var ReceitasMedicas = _ReceitasMedicasRepository.GetReceitasMedicas();
            if (ReceitasMedicas == null)
            {
                return NotFound();
            }
            return Ok(ReceitasMedicas);
        }


        // GET: api/ReceitasMedicas/id/{id}
        [HttpGet("{id}")]
        public ActionResult<ReceitasMedicas> GetReceitasMedicas(int id)
        {
            var ReceitasMedicas = _ReceitasMedicasRepository.GetReceitasMedicasById(id);
            if (ReceitasMedicas == null)
            {
                return NotFound();
            }
            return Ok(ReceitasMedicas);
        }

        // POST: api/ReceitasMedicas
        [HttpPost]
        public ActionResult CreateReceitasMedicas(ReceitasMedicas ReceitasMedicas)
        {
            _ReceitasMedicasRepository.CreateReceitasMedicas(ReceitasMedicas);
            return Ok();
        }

        // PUT: api/ReceitasMedicas/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReceitasMedicas(ReceitasMedicas ReceitasMedicas)
        {

            var existingReceitasMedicas = _ReceitasMedicasRepository.GetReceitasMedicasById(ReceitasMedicas.ID_receita);
            if (existingReceitasMedicas == null)
            {
                return NotFound();
            }

            _ReceitasMedicasRepository.UpdateReceitasMedicas(ReceitasMedicas);

            return NoContent();
        }

        // DELETE: api/ReceitasMedicas/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReceitasMedicas(int id)
        {
            var existingReceitasMedicas = _ReceitasMedicasRepository.GetReceitasMedicasById(id);
            if (existingReceitasMedicas == null)
            {
                return NotFound();
            }

            _ReceitasMedicasRepository.DeleteReceitasMedicas(id);

            return NoContent();
        }
    }


}
