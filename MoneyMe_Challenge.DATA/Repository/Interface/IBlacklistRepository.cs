using MoneyMe_Challenge.CORE.Entity;

namespace MoneyMe_Challenge.DATA.Repository.Interface
{
    public interface IBlacklistRepository :IGenericRepository<BlacklistEntity>
    {
        Task<List<BlacklistEntity>> GetBlacklistedByValueAsync(string mobileNo, string emailDomain);
    }
}
