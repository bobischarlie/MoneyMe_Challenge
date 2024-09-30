namespace MoneyMe_Challenge.CORE.Enum
{
    public enum ApplicationStatus
    {
        Applied, //steps = apply(1st step), then for review, then approve or decline
        ForReview,
        Approved,
        Declined
    }
}
