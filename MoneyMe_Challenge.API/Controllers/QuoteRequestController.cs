using Microsoft.AspNetCore.Mvc;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Controllers
{
    public class QuoteRequestController : ControllerBase
    {
        [HttpPost]
        [Route("GetQuotation")]
        public IActionResult Index([FromBody]Quote quote)
        {

            return Ok();
        }
    }
}
