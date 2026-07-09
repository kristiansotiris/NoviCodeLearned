namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidSelectionsException : BettingException 
    {
        public override string ErrorCode => "INVALID_SELECTIONS";
        public InvalidSelectionsException() : base("A bet must contain at least one selection") { }
    }
}
