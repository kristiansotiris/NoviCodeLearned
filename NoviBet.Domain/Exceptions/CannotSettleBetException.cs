namespace NoviBet.Domain.Exceptions
{
    public sealed class CannotSettleBetException : BettingException
    {
        public override string ErrorCode => "INVALID_BET_SETTLE";

        public Guid Id { get; }

        public CannotSettleBetException(Guid id) : base($"Your Bet Settle with id: {id} is invalid.")
        {
            Id = id;
        }
    }
}
