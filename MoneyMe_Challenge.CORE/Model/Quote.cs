using MoneyMe_Challenge.CORE.Enum;

namespace MoneyMe_Challenge.CORE.Model
{
    public class Quote
    {
        public Guid Id { get; set; }
        public decimal AmountRequired { get; set; }
        public int Term { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }

        public decimal? RepaymentAmount { get; set; }
        public decimal? EstablishmentFee { get; set; }
        public decimal? TotalInterest { get; set; }
        public string? Product { get; set; }
        public ApplicationStatus Status { get; set; }


    }
}
