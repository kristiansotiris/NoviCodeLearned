namespace NoviBet.Domain.Exceptions
{
    public abstract class BettingException : Exception
    {
        public abstract string ErrorCode { get; }
        
        protected BettingException(string message) : base(message){ }
        protected BettingException(string message, Exception innerException) : base(message, innerException){ }

    }
}
