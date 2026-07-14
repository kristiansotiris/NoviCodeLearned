namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidAmountException : WalletExceptions
    {
        public override string ErrorCode => "INVALID_AMOUNT";
        public decimal Amount { get; }
        public InvalidAmountException(decimal amount) : base($"Your amount: {amount} is invalid.")
        {
            Amount = amount;
        }
    }
}
