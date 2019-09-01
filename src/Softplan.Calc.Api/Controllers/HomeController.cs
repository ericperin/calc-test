using Microsoft.AspNetCore.Mvc;

namespace Softplan.Calc.Api.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "https://github.com/ericperin/calc-test";
        }
    }
}
