using Microsoft.EntityFrameworkCore;
using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.DATA.Repository
{
    public class BlacklistRepository : GenericRepository<BlacklistEntity>, IBlacklistRepository
    {
        private readonly AppDbContext _appDbContext;
        public BlacklistRepository(AppDbContext context) :base(context)
        {
            _appDbContext = context;
        }
        public async Task<List<BlacklistEntity>> GetBlacklistedByValueAsync(string mobileNo, string emailDomain)
        {
            var blackList = await _appDbContext.Blacklist.Where(b => b.Value == mobileNo ||b.Value == emailDomain).
                ToListAsync();
            if (blackList == null)
            { 
                return null;
            }
            return blackList;
        }
    }
}
