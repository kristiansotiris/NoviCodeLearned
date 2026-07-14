namespace NoviBet.Domain.Exceptions
{
    public abstract class WalletExceptions: Exception
    {
        
        public abstract string ErrorCode { get; }
        protected WalletExceptions(string message) : base(message){ }
        protected WalletExceptions(string message, Exception innerException) : base(message, innerException) { }
    }
}
