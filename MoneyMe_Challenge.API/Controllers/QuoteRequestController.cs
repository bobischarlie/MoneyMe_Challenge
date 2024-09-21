using Microsoft.AspNetCore.Mvc;
using MoneyMe_Challenge.API.Services.Interface;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Controllers
{
    public class QuoteRequestController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        public QuoteRequestController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }
        [HttpPost()]
        [Route("RequestQuote")]
        public async Task<IActionResult> Index([FromBody] Quote quote)
        {
            await _quoteService.Add(quote);
            return Ok();
        }
    }
}
