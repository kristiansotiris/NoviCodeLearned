namespace NoviBet.Domain.Exceptions
{
    public sealed class InvalidPlayerNameException : PlayerException
    {
        public override string ErrorCode => "INVALID_PLAYER_NAME";
        public string Name { get; }

        public InvalidPlayerNameException(string playerName)
            : base($"The player name '{playerName}' is invalid.")
        {
            Name = playerName;
        }
    }
}
