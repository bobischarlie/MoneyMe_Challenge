using Microsoft.AspNetCore.Mvc;
using MoneyMe_Challenge.API.Services.Interface;
using MoneyMe_Challenge.CORE.Contracts;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Controllers
{
    [Route("Quote")]
    public class QuoteRequestController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        private readonly IConfiguration _configuration;
        public QuoteRequestController(IQuoteService quoteService, IConfiguration configuration)
        {
            _quoteService = quoteService;
            _configuration = configuration;
        }

        [HttpPost()]
        [Route("RequestQuote")]
        public async Task<IActionResult> RequestForQuote([FromBody] QuoteRequestContract quote)
        {
            var quoteId = await _quoteService.UpsertQuoteRequestAsync(quote);
            var returnURL = _configuration.GetSection("Appsettings").GetSection("moneyMeUIURL").Value + quoteId;
            return Ok(returnURL);
        }

        [HttpGet()]
        [Route("{quoteId}")]
        public async Task<IActionResult> GetQuote([FromRoute] Guid quoteId)
        {
            try
            {
                var quote = await _quoteService.GetQuoteAsync(quoteId);
                if (quote == null)
                {
                    return NotFound();
                }
                return Ok(quote);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut()]
        [Route("{quoteId}")]
        public async Task<IActionResult> SubmitApplication([FromRoute] Guid quoteId, [FromBody] Quote quote)
        {
            try
            {
                quote.Id = quoteId;
                var updatedQuote = await _quoteService.UpdateApplicationStatus(quote);
                if(updatedQuote == null)
                { 
                    return NotFound();
                }
                return Ok(updatedQuote);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
