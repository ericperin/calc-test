using Microsoft.AspNetCore.Mvc;

namespace Softplan.Calc.Api.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("https://github.com/ericperin/calc-test");
        }
    }
}
