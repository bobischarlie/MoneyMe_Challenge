using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Services.Interface
{
    public interface IQuoteService
    {
        Task Add(Quote quote);
    }
}
