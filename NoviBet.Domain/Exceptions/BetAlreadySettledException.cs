namespace NoviBet.Domain.Exceptions
{
    public sealed class BetAlreadySettledException : BettingException
    {
        public override string ErrorCode => "BET_ALREADY_SETTLED";
        public Guid BetId { get; }
        public BetAlreadySettledException(Guid guidId) : base($"Bet {guidId} has already been settled and cannot be settled again.")
        {
            BetId = guidId;
        }

    }
}
