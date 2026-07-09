namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidOddsException : BettingException
    {
        public override string ErrorCode => "INVALID_ODD_VALUE";
        public decimal AttemptedValue { get; }

        public InvalidOddsException(decimal attemptedValue) : base($"Your requested {attemptedValue} is not valid.")
        {
            AttemptedValue = attemptedValue;
        }
    }
}
