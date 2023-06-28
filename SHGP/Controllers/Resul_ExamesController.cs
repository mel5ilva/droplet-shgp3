using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Resul_ExamesController : ControllerBase

    {
        private readonly IResul_ExamesRepository _Resul_ExamesRepository;

        public Resul_ExamesController(IResul_ExamesRepository Resul_ExamesRepository)
        {
            _Resul_ExamesRepository = Resul_ExamesRepository;
        }

        // GET: api/Resul_Exames
        [HttpGet]
        public ActionResult<IEnumerable<Resul_Exames>> GetResul_Exames()
        {
            var Resul_Exames = _Resul_ExamesRepository.GetResul_Exames();
            if (Resul_Exames == null)
            {
                return NotFound();
            }
            return Ok(Resul_Exames);
        }


        // GET: api/Resul_Exames/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Resul_Exames> GetResul_Exames(int id)
        {
            var Resul_Exames = _Resul_ExamesRepository.GetResul_ExamesById(id);
            if (Resul_Exames == null)
            {
                return NotFound();
            }
            return Ok(Resul_Exames);
        }

        // POST: api/Resul_Exames
        [HttpPost]
        public ActionResult CreateResul_Exames(Resul_Exames Resul_Exames)
        {
            _Resul_ExamesRepository.CreateResul_Exames(Resul_Exames);
            return Ok();
        }

        // PUT: api/Resul_Exames/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateResul_Exames(Resul_Exames Resul_Exames)
        {

            var existingResul_Exames = _Resul_ExamesRepository.GetResul_ExamesById(Resul_Exames.ID_res_exames);
            if (existingResul_Exames == null)
            {
                return NotFound();
            }

            _Resul_ExamesRepository.UpdateResul_Exames(Resul_Exames);

            return NoContent();
        }

        // DELETE: api/Resul_Exames/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteResul_Exames(int id)
        {
            var existingResul_Exames = _Resul_ExamesRepository.GetResul_ExamesById(id);
            if (existingResul_Exames == null)
            {
                return NotFound();
            }

            _Resul_ExamesRepository.DeleteResul_Exames(id);

            return NoContent();
        }
    }


}
