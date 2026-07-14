namespace NoviBet.Domain.Exceptions
{
    public sealed class WalletAlreadyExistsException : WalletExceptions
    {
        public override string ErrorCode => "WALLET_ALREADY_EXISTS";

        public Guid WalletId { get; }
        public WalletAlreadyExistsException(string message) : base(message) { }

        public WalletAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }

        public WalletAlreadyExistsException(Guid walletId)
            : base($"Wallet with ID '{walletId}' already exists.")
        {
            WalletId = walletId;
        }
    }
}
