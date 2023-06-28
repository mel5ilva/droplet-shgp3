using Microsoft.AspNetCore.Http;
using SHGP.Model;
using Microsoft.AspNetCore.Mvc;
using SHGP.Repository;

namespace SHGP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase

    {
        private readonly IPagamentosRepository _PagamentosRepository;

        public PagamentosController(IPagamentosRepository PagamentosRepository)
        {
            _PagamentosRepository = PagamentosRepository;
        }

        // GET: api/Pagamentos
        [HttpGet]
        public ActionResult<IEnumerable<Pagamentos>> GetPagamentos()
        {
            var Pagamentos = _PagamentosRepository.GetPagamentos();
            if (Pagamentos == null)
            {
                return NotFound();
            }
            return Ok(Pagamentos);
        }


        // GET: api/Pagamentos/id/{id}
        [HttpGet("{id}")]
        public ActionResult<Pagamentos> GetPagamentos(int id)
        {
            var Pagamentos = _PagamentosRepository.GetPagamentosById(id);
            if (Pagamentos == null)
            {
                return NotFound();
            }
            return Ok(Pagamentos);
        }

        // POST: api/Pagamentos
        [HttpPost]
        public ActionResult CreatePagamentos(Pagamentos Pagamentos)
        {
            _PagamentosRepository.CreatePagamentos(Pagamentos);
            return Ok();
        }

        // PUT: api/Pagamentos/{id}
        [HttpPut("{id}")]
        public IActionResult UpdatePagamentos(Pagamentos Pagamentos)
        {

            var existingPagamentos = _PagamentosRepository.GetPagamentosById(Pagamentos.ID_pagamento);
            if (existingPagamentos == null)
            {
                return NotFound();
            }

            _PagamentosRepository.UpdatePagamentos(Pagamentos);

            return NoContent();
        }

        // DELETE: api/Pagamentos/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePagamentos(int id)
        {
            var existingPagamentos = _PagamentosRepository.GetPagamentosById(id);
            if (existingPagamentos == null)
            {
                return NotFound();
            }

            _PagamentosRepository.DeletePagamentos(id);

            return NoContent();
        }
    }

}
