using MoneyMe_Challenge.CORE.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyMe_Challenge.CORE.Entity
{
    [Table("Blacklist")]
    public class BlacklistEntity : BaseEntity
    {
        public string Value { get; set; }
        public string Description { get; set; }

        public BlacklistType Type { get; set; }
    }
}
