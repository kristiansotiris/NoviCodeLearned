namespace NoviBet.Domain.Exceptions
{
    public abstract class PlayerException : Exception
    {
        public abstract string ErrorCode { get; }
        
        public PlayerException(string message) : base(message)
        {
        }

        public PlayerException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
