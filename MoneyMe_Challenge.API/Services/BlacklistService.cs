using AutoMapper;
using MoneyMe_Challenge.API.Services.Interface;
using MoneyMe_Challenge.CORE.Model;
using MoneyMe_Challenge.DATA.Repository.Interface;

namespace MoneyMe_Challenge.API.Services
{
    public class BlacklistService : IBlacklistService
    {
        private readonly IBlacklistRepository _blacklistRepository;
        private readonly IMapper _mapper;
        public BlacklistService(IBlacklistRepository blacklistRepository, IMapper mapper)
        {
            _blacklistRepository = blacklistRepository;
            _mapper = mapper;
        }

        public async Task<List<Blacklist>> GetBlacklistAsync(string mobileNo, string emailDomain)
        {
            var blacklistEntity = await _blacklistRepository.GetBlacklistedByValueAsync(mobileNo, emailDomain);
            if (blacklistEntity == null)
            {
                return null;
            }
            var blacklist = _mapper.Map<List<Blacklist>>(blacklistEntity);
            return blacklist;
            
        }
    }
}
