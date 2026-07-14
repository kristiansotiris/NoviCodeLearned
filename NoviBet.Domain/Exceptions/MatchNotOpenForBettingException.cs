namespace NoviBet.Domain.Exceptions
{
    public sealed class MatchNotOpenForBettingException : MatchExceptions
    {
        public override string ErrorCode => "MATCH_NOT_FOR_BET";

        public MatchNotOpenForBettingException(string message) : base(message) { }
    }
}
