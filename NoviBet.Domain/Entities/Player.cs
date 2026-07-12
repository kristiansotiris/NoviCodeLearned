using NoviBet.Domain.Enums;

namespace NoviBet.Domain.Entities
{
    public class Player : IPlayer
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public PlayersRole Role { get; }
        public Wallet PlayerWallet { get; }

        public Player(string name, PlayersRole role)
        {
            Name = name;
            Role = role;
            PlayerWallet = new Wallet();
        }
    }
}
