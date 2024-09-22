using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Services.Interface
{
    public interface IQuoteService
    {
        Task<Guid> UpsertAsync(Quote quote);
        Task<Quote> GetQuoteAsync(Guid quoteId);
    }
}
