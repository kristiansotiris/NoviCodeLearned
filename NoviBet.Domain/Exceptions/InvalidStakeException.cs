namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidStakeException : BettingException
    {
        public decimal AttemptedValueStake{ get; }
        public override string ErrorCode =>  "INVALID_STAKE";

        public InvalidStakeException(decimal attemptedstake) : base($"Stake {attemptedstake} is invalid, it must be greater than zero.")
        {
            AttemptedValueStake = attemptedstake;
        }
    }
}
