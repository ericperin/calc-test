using Microsoft.AspNetCore.Mvc;
using Softplan.Calc.Domain.Entities;

namespace Softplan.Calc.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<decimal> Get(decimal valorInicial, int meses)
        {
            var taxaJurosController = new TaxaJurosController();
            var valorJuros = taxaJurosController.Get();
            if (valorJuros == null) return BadRequest("Taxa de juros null.");

            var juros = new Juros(valorJuros.Value);
            return juros.Calcula(valorInicial, meses);
        }
    }
}
