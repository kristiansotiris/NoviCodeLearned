namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidMatchIdException : BettingException
    {
        public Guid MatchId { get; }
        public override string ErrorCode => "INVALID_MATCH_ID";

        public InvalidMatchIdException(Guid guidId) : base($"Your match id: {guidId} is not found. ")
        {
            MatchId = guidId;
        }
    }
}
