using Microsoft.AspNetCore.Mvc;
using MoneyMe_Challenge.API.Services.Interface;
using MoneyMe_Challenge.CORE.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoneyMe_Challenge.API.Controllers
{
    [Route("blacklist")]
    public class BlacklistController : ControllerBase
    {
        private readonly IBlacklistService _blacklistService;
        public BlacklistController(IBlacklistService blacklistService)
        {
            _blacklistService = blacklistService;
        }

        [HttpGet()]
        [Route("GetBlacklisted")]
        public async Task<IActionResult> GetBlacklist([FromQuery] string mobileNo, [FromQuery] string emailDomain)
        {
            try
            {
                var blacklist = await _blacklistService.GetBlacklistAsync(mobileNo, emailDomain);

                var apiResult = new ApiResultContract() { Data = blacklist };
                if (blacklist == null)
                {
                    apiResult.Message = "Mobile No and email domain is not blacklisted.";
                    return Ok(apiResult);
                }
                apiResult.Rows = blacklist.Count;
                return Ok(apiResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
