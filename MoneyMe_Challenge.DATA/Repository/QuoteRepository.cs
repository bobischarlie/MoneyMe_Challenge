using Microsoft.EntityFrameworkCore;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class QuoteRepository : GenericRepository<QuoteEntity>, IQuoteRepository
    {
        private AppDbContext _appDbContext;
        public QuoteRepository(AppDbContext context) : base(context) 
        {
            _appDbContext = context;
        }

        public Task<QuoteEntity> GetQuoteRequestBefore(string firstName, string lastName, DateOnly dateOfBirth)
        {
            var quoteEntity = _appDbContext.Quote
                 .Where(q => q.FirstName == firstName && q.LastName == lastName && q.DateOfBirth == dateOfBirth)
                 .FirstOrDefaultAsync();
            if (quoteEntity == null)
            {
                return null;
            }
            return quoteEntity;
        }

    }
}