using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Model;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class QuoteRepository : GenericRepository<QuoteEntity>, IQuoteRepository
    {
        public QuoteRepository(AppDbContext context) : base(context)
        {

        }
    }
}