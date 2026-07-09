namespace NoviBet.Domain.Exceptions
{
    public sealed class MatchAlreadyFinishedException : BettingException
    {
        public Guid MatchId { get; }

        public override string ErrorCode => "MATCH_ALREADY_FINISHED";

        public MatchAlreadyFinishedException(Guid matchId) : base($"Match '{matchId}' is already finished and cannot be settled again.")
        {
            MatchId = matchId;
        }
    }
}
