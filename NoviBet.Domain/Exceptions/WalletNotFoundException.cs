namespace NoviBet.Domain.Exceptions
{
    public sealed class WalletNotFoundException : WalletExceptions
    {
        public override string ErrorCode => "WALLET_NOT_FOUND";

        public Guid WalletId { get; }
        public WalletNotFoundException(string message) : base(message) { }

        public WalletNotFoundException(string message, Exception innerException) : base(message, innerException) { }


        public WalletNotFoundException(Guid walletId) : base($"Wallet with id: {walletId} is not found.")
        {
            WalletId = walletId;
        }


    }
}
