using MoneyMe_Challenge.CORE.Contracts;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Services.Interface
{
    public interface IQuoteService
    {
        Task<Guid> UpsertQuoteRequestAsync(QuoteRequestContract quote);
        Task<Quote> GetQuoteAsync(Guid quoteId);
        Task<Quote> UpdateApplicationStatus(Quote quote);
    }
}
