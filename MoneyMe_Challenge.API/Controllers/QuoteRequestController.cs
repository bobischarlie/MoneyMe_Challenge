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
            var returnURL = await _quoteService.UpsertAsync(quote);
            return Ok(returnURL);
        }

        [HttpGet()]
        [Route("quote/{quoteId}")]
        public async Task<IActionResult> GetQuote([FromRoute] Guid quoteId)
        {
            var quote = await _quoteService.GetQuoteAsync(quoteId);
            if (quote == null)
            {
                return NotFound();
            }
            return Ok(quote);
        }
    }
}
