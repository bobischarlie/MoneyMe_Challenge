namespace MoneyMe_Challenge.CORE.Model
{
    public class Quote
    {
        public decimal AmountRequired { get; set; }
        public int Term { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }

    }
}
