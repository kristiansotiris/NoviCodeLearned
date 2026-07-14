
namespace NoviBet.Domain.Exceptions
{
    public sealed class InsufficientFundsException : WalletExceptions
    {
        public override string ErrorCode => "INVALID_FUND";
        public decimal Balance { get; }
        public decimal Amount { get; }

        public InsufficientFundsException(decimal balance, decimal amount) : base($"Player balance is {balance} and made and invalid fund of {amount}")
        {
            Balance = balance;
            Amount = amount;
        }

    }
}
