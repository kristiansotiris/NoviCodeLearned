namespace NoviBet.Domain.Exceptions
{
    public sealed class BetNotFoundException : BettingException
    {
        public override string ErrorCode =>  "BET_NOT_FOUND";
        public Guid Id { get; }

        public BetNotFoundException(string message) : base(message) { }
        public BetNotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public BetNotFoundException(Guid id) : base($"Bet with id: {id} is not found.")
        {
            Id = id;
        }
    }
}
