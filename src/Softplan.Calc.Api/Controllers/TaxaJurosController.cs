using Microsoft.AspNetCore.Mvc;

namespace Softplan.Calc.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<double> Get()
        {
            return Ok(0.01);
        }
    }
}
