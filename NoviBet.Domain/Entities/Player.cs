using NoviBet.Domain.Enums;

namespace NoviBet.Domain.Entities
{
    public class Player : IPlayer
    {
        public Guid Id { get; }
        public string Name { get; private set; }
        public PlayersRole Role { get; }

        public Player(string name, PlayersRole role)
        {
            Id = Guid.NewGuid();
            Name = name;
            Role = role;
        }
    }
}
