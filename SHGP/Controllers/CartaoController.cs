using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SHGP.Model;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoController : ControllerBase
    {
        private readonly ICartaoRepository _CartaoRepository;

        public CartaoController(ICartaoRepository CartaoRepository)
        {
            _CartaoRepository = CartaoRepository;
        }

        // GET: api/Cartao
        [HttpGet]
        public ActionResult<IEnumerable<Cartao>> GetCartao()
        {
            var Cartaos = _CartaoRepository.GetCartao();
            if (Cartaos == null)
            {
                return NotFound();
            }
            return Ok(Cartaos);
        }


        // GET: api/Cartao/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Cartao> GetCartaoById(int id)
        {
            var Cartao = _CartaoRepository.GetCartaoById(id);
            if (Cartao == null)
            {
                return NotFound();
            }
            return Ok(Cartao);
        }
      
        // POST: api/Cartao
        [HttpPost]
        public ActionResult CreateCartao(Cartao Cartao)
        {
            _CartaoRepository.CreateCartao(Cartao);
            return Ok(); // Retorna uma resposta HTTP 200 (OK) sem nenhum conteúdo adicional
        }

        // PUT: api/Cartao/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCartao(int id, Cartao Cartao)
        {
            if (id != Cartao.ID_cartao)
            {
                return BadRequest();
            }

            var existingCartao = _CartaoRepository.GetCartaoById(id);
            if (existingCartao == null)
            {
                return NotFound();
            }

            _CartaoRepository.UpdateCartao(Cartao);

            return NoContent();
        }

        // DELETE: api/Cartao/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCartao(int id)
        {
            var existingCartao = _CartaoRepository.GetCartaoById(id);
            if (existingCartao == null)
            {
                return NotFound();
            }

            _CartaoRepository.DeleteCartao(id);

            return NoContent();
        }
    }

}
