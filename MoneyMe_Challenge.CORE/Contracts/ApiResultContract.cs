namespace MoneyMe_Challenge.CORE.Contracts
{
    public class ApiResultContract
    {
        public int Rows { get; set; } = 0;
        public string Message { get; set; }
        public object? Data { get; set; }
    }
}
