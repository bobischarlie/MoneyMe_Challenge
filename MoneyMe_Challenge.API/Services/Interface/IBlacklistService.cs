using MoneyMe_Challenge.CORE.Entity;
using MoneyMe_Challenge.CORE.Model;

namespace MoneyMe_Challenge.API.Services.Interface
{
    public interface IBlacklistService
    {
        Task<List<Blacklist>> GetBlacklistAsync(string mobileNo, string emailDomain);
    }
}
