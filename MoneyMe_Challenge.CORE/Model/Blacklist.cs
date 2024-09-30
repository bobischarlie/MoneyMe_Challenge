using MoneyMe_Challenge.CORE.Enum;

namespace MoneyMe_Challenge.CORE.Model
{
    public class Blacklist
    {
        public string Value { get; set; }
        public string Description { get; set; }
        public BlacklistType Type { get; set; }
    }
}
