namespace NoviBet.Domain.Exceptions
{
    public sealed class PlayerIsNotFoundException : PlayerException
    {
        public override string ErrorCode => "PLAYER_NOT_FOUND";
        public Guid PlayerId { get; }
        public PlayerIsNotFoundException(Guid playerId)
            : base($"Player with ID '{playerId}' was not found.")
        {
            PlayerId = playerId;
        }
    }
}
